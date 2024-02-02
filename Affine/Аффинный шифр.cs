using System;
using System.Drawing;
using System.Windows.Forms;

namespace Affine
{
    public partial class cipherForm : Form
    {
        private string encryptedText; // Добавили поле для хранения зашифрованного текста

        public cipherForm()
        {
            InitializeComponent();
        }

        private void closelogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void cipherForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void cipherForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int keyA = int.Parse(KeyATextBox.Text);
                int keyB = int.Parse(KeyBTextBox.Text);

                if (IsCoprime(keyA, 26))
                {
                    string decryptedMessage = AffineDecrypt(encryptedText, keyA, keyB); // Используем зашифрованный текст
                    ResultTextBox.Text = decryptedMessage;
                }
                else
                {
                    MessageBox.Show("Ключ A должен быть взаимно простым с 26.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int keyA = int.Parse(KeyATextBox.Text);
                int keyB = int.Parse(KeyBTextBox.Text);
                string message = MessageTextBox.Text;

                if (IsCoprime(keyA, 26))
                {
                    encryptedText = AffineEncrypt(message, keyA, keyB); // Сохраняем зашифрованный текст
                    ResultTextBox.Text = encryptedText;
                }
                else
                {
                    MessageBox.Show("Ключ A должен быть взаимно простым с 26.", "Ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        public static string AffineEncrypt(string plainText, int a, int b)
        {
            string cipherText = "";

            char[] chars = plainText.ToCharArray();

            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                {
                    int x = char.ToUpper(c) - 'A';
                    cipherText += char.IsUpper(c)
                        ? Convert.ToChar(((a * x + b) % 26) + 'A')
                        : Convert.ToChar(((a * x + b) % 26) + 'a');
                }
                else
                {
                    cipherText += c;
                }
            }

            return cipherText;
        }

        public static string AffineDecrypt(string cipherText, int a, int b)
        {
            string plainText = "";
            int aInverse = MultiplicativeInverse(a);

            char[] chars = cipherText.ToCharArray();

            foreach (char c in chars)
            {
                if (char.IsLetter(c))
                {
                    int x = char.ToUpper(c) - 'A';
                    x = (x - b + 26) % 26;
                    plainText += char.IsUpper(c)
                        ? Convert.ToChar(((aInverse * x) % 26) + 'A')
                        : Convert.ToChar(((aInverse * x) % 26) + 'a');
                }
                else
                {
                    plainText += c;
                }
            }

            return plainText;
        }

        public static int MultiplicativeInverse(int a)
        {
            for (int x = 1; x < 27; x++)
            {
                if ((a * x) % 26 == 1)
                    return x;
            }

            throw new Exception("Мультипликативное обратное число не найдено!");
        }

        public bool IsCoprime(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a == 1;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Affine
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();

            this.passwordField.AutoSize = false;
            this.passwordField.Size = new Size(this.passwordField.Size.Width, 36);
            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 36);
        }

        private void closelogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closelogin_MouseEnter(object sender, EventArgs e)
        {
            closelogin.ForeColor = Color.Red;
        }

        private void closelogin_MouseLeave(object sender, EventArgs e)
        {
            closelogin.ForeColor = Color.SlateGray;
        }
        Point lastPoint;
        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public bool CheckUserExistsInDatabase(string login, string password)
        {
            DB1 db1 = new DB1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lu AND `password` = @pu", db1.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = CreateHashSHA384(password);
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows.Count > 0;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginuser = loginField.Text;
            string passworduser = passwordField.Text;
            DB1 db1 = new DB1();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @lu AND `password` = @pu", db1.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = CreateHashSHA384(passworduser);
            adapter.SelectCommand = command;
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                this.Hide();
                cipherForm cipherForm = new cipherForm();
                cipherForm.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLabel_MouseEnter(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.DarkGreen;
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.SlateGray;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Введите логин";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }
        private string CreateHashSHA384(String source)
        {
            using (SHA384 sha384Hash = SHA384.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha384Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите логин")
            {
                passwordField.Text = "";
                passwordField.ForeColor = Color.Black;
            }
        }
    }
}

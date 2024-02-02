namespace Affine
{
    partial class cipherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.closelogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyATextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closelogin
            // 
            this.closelogin.AutoSize = true;
            this.closelogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closelogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closelogin.ForeColor = System.Drawing.Color.SlateGray;
            this.closelogin.Location = new System.Drawing.Point(471, 9);
            this.closelogin.Name = "closelogin";
            this.closelogin.Size = new System.Drawing.Size(21, 20);
            this.closelogin.TabIndex = 10;
            this.closelogin.Text = "X";
            this.closelogin.Click += new System.EventHandler(this.closelogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 50);
            this.label2.TabIndex = 18;
            this.label2.Text = "Афинный шифр";
            // 
            // KeyATextBox
            // 
            this.KeyATextBox.Location = new System.Drawing.Point(28, 105);
            this.KeyATextBox.Name = "KeyATextBox";
            this.KeyATextBox.Size = new System.Drawing.Size(52, 20);
            this.KeyATextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ключ А";
            // 
            // KeyBTextBox
            // 
            this.KeyBTextBox.Location = new System.Drawing.Point(105, 105);
            this.KeyBTextBox.Name = "KeyBTextBox";
            this.KeyBTextBox.Size = new System.Drawing.Size(52, 20);
            this.KeyBTextBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(101, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ключ B";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTextBox.Location = new System.Drawing.Point(28, 177);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(195, 97);
            this.MessageTextBox.TabIndex = 26;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.Location = new System.Drawing.Point(281, 177);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(195, 97);
            this.ResultTextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(25, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Текст для шифрования / расшифрования\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(278, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Результат шифрования / расшифрования\r\n";
            // 
            // EncryptButton
            // 
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptButton.ForeColor = System.Drawing.Color.White;
            this.EncryptButton.Location = new System.Drawing.Point(28, 314);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(146, 55);
            this.EncryptButton.TabIndex = 30;
            this.EncryptButton.Text = "Шифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecryptButton.ForeColor = System.Drawing.Color.White;
            this.DecryptButton.Location = new System.Drawing.Point(201, 314);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(146, 55);
            this.DecryptButton.TabIndex = 31;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(42, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "P.S. Шифрование и Дешифрование только на английском языке";
            // 
            // cipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(504, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyBTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyATextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closelogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cipherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cipher";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cipherForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cipherForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closelogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyATextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KeyBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label label6;
    }
}
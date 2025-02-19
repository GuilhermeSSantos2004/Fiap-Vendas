namespace Fiap.Vendas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPassword = new TextBox();
            textPassword = new Label();
            textUser = new Label();
            btnSubmit = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(184, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += textSenha_TextChanged;
            // 
            // textPassword
            // 
            textPassword.AutoSize = true;
            textPassword.Location = new Point(184, 135);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(57, 15);
            textPassword.TabIndex = 2;
            textPassword.Text = "Password";
            textPassword.Click += label1_Click;
            // 
            // textUser
            // 
            textUser.AutoSize = true;
            textUser.Location = new Point(184, 79);
            textUser.Name = "textUser";
            textUser.Size = new Size(30, 15);
            textUser.TabIndex = 3;
            textUser.Text = "User";
            textUser.Click += label2_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(222, 182);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 26);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(222, 214);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(133, 26);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 316);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(textUser);
            Controls.Add(textPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPassword;
        private Label textPassword;
        private Label textUser;
        private Button btnSubmit;
        private Button btnExit;
    }
}

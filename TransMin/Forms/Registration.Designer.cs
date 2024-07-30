namespace TransMin.Forms
{
    partial class Registration
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
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            txtDSurname = new TextBox();
            lblSurname = new Label();
            lblName = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            lblPassword = new Label();
            label1 = new Label();
            btnRegister = new Button();
            lblLogin = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(45, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(60, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(45, 48);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(152, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(45, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(45, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Location = new Point(45, 158);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 23);
            txtName.TabIndex = 4;
            // 
            // txtDSurname
            // 
            txtDSurname.Location = new Point(45, 211);
            txtDSurname.Name = "txtDSurname";
            txtDSurname.Size = new Size(152, 23);
            txtDSurname.TabIndex = 5;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(45, 193);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(54, 15);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(45, 140);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(152, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(45, 320);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(152, 23);
            txtConfirmPassword.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(45, 248);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 302);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 11;
            label1.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(255, 47);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(133, 23);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(313, 100);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 13;
            lblLogin.TabStop = true;
            lblLogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 82);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 14;
            label2.Text = "Already have an Account? ";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 377);
            Controls.Add(label2);
            Controls.Add(lblLogin);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(lblPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblName);
            Controls.Add(lblSurname);
            Controls.Add(txtDSurname);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtName;
        private TextBox txtDSurname;
        private Label lblSurname;
        private Label lblName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label lblPassword;
        private Label label1;
        private Button btnRegister;
        private LinkLabel lblLogin;
        private Label label2;
    }
}
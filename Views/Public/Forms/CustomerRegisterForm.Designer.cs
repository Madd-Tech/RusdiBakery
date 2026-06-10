namespace RusdiBakery.Views.Public.Forms
{
    partial class CustomerRegisterForm
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
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            linkLabel1 = new LinkLabel();
            btnRegister = new Button();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblTitle = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Broadway", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(519, 165);
            label1.TabIndex = 100;
            label1.Text = "Rusdi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Broadway", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LavenderBlush;
            label2.Location = new Point(44, 217);
            label2.Name = "label2";
            label2.Size = new Size(627, 163);
            label2.TabIndex = 101;
            label2.Text = "Bakery";
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Diamond_Close_up_Mobile_Wallpaper;
            panel4.Controls.Add(linkLabel1);
            panel4.Controls.Add(btnRegister);
            panel4.Controls.Add(lblConfirmPassword);
            panel4.Controls.Add(txtConfirmPassword);
            panel4.Controls.Add(lblPassword);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(lblEmail);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtUsername);
            panel4.Controls.Add(lblUsername);
            panel4.Controls.Add(lblTitle);
            panel4.Location = new Point(677, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(582, 793);
            panel4.TabIndex = 99;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(26, 753);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(232, 25);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Plum;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.PaleTurquoise;
            btnRegister.Location = new Point(62, 655);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(458, 56);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Gill Sans Ultra Bold Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.PaleTurquoise;
            lblConfirmPassword.Location = new Point(62, 555);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(196, 32);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(62, 590);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(458, 31);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Gill Sans Ultra Bold Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.PaleTurquoise;
            lblPassword.Location = new Point(62, 440);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(112, 32);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 475);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(458, 31);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Gill Sans Ultra Bold Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.PaleTurquoise;
            lblEmail.Location = new Point(62, 325);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 32);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(62, 360);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(458, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(62, 245);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(458, 31);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Gill Sans Ultra Bold Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.PaleTurquoise;
            lblUsername.Location = new Point(62, 210);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 32);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("ROG Fonts", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Honeydew;
            lblTitle.Location = new Point(107, 52);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Register Customer";
            // 
            // CustomerRegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            BackgroundImage = Properties.Resources.download__23_;
            ClientSize = new Size(1271, 827);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Name = "CustomerRegisterForm";
            Text = "Customer Register";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel4;
        private LinkLabel linkLabel1;
        private Button btnRegister;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblTitle;
    }
}

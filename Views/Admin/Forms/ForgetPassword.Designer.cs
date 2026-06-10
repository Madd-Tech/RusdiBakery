namespace RusdiBakery.Views.Admin.Forms
{
    partial class ForgetPassword
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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            textEmail = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(283, 45);
            label1.TabIndex = 0;
            label1.Text = "Forget Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 115);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // button1
            // 
            button1.Location = new Point(257, 204);
            button1.Name = "button1";
            button1.Size = new Size(255, 34);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(257, 254);
            button2.Name = "button2";
            button2.Size = new Size(255, 34);
            button2.TabIndex = 4;
            button2.Text = "Reset Password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 331);
            label3.Name = "label3";
            label3.Size = new Size(283, 25);
            label3.TabIndex = 5;
            label3.Text = "Password will be sended via email.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 374);
            label4.Name = "label4";
            label4.Size = new Size(343, 25);
            label4.TabIndex = 6;
            label4.Text = "Make sure you have valid registered email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(226, 150);
            textEmail.Multiline = true;
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(332, 33);
            textEmail.TabIndex = 7;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgetPassword";
            Text = "ForgetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label4;
        private TextBox textEmail;
    }
}
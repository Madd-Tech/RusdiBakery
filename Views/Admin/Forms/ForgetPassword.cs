using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.Models;
using RusdiBakery.repos;
using RusdiBakery.Services;

namespace RusdiBakery.Views.Admin.Forms
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textEmail.Text.Trim()))
            // cek apakah email yang dimasukkan kosong atau hanya spasi
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(textEmail.Text.Trim(), out _))
            // cek apakah email yang dimasukkan valid dengan format email yang benar
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            var email = textEmail.Text.Trim();
            var admin = AdminRepo.GetByEmail(email); 
            if (admin == null) // member tidak ditemukan dengan email yang diberikan
            {
                MessageBox.Show("Email not found or admin is not registered yet");
                return;
            }

            // Disable button to prevent double click
            button2.Enabled = false;
            button2.Text = "Sending...";

            try
            {
                await ResetPasswordUsingMember(admin);
            }
            finally
            {
                button2.Enabled = true;
                button2.Text = "Reset Password";
            }
        }

        private async Task ResetPasswordUsingMember(RusdiBakery.Models.Admin admin)
        {
            // Generate a random temporary password
            string tempPassword = GenerateRandomPassword(8);

            string oldPasswordHash = admin.Password ?? "";

            // Update the password in the database before sending, then roll it back if email delivery fails.
            bool success = AdminRepo.UpdatePassword(admin.IdAdmin, tempPassword);

            if (success)
            {
                try 
                {
                    // Send email
                    await EmailService.SendTemporaryPasswordAsync(admin.Email!, tempPassword);

                    MessageBox.Show($"Your password has been reset. Please check your email: {admin.Email}", 
                        "Password Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Form2 loginForm = new Form2();
                    loginForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrWhiteSpace(oldPasswordHash))
                    {
                        AdminRepo.UpdatePasswordHash(admin.IdAdmin, oldPasswordHash);
                    }

                    MessageBox.Show($"Failed to send reset email, so the password was not changed.\nError: {ex.Message}\n\nPlease configure SMTP authentication and try again.",
                        "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Failed to reset password. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateRandomPassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            while (0 < length--)
            {
                res.Append(valid[RandomNumberGenerator.GetInt32(valid.Length)]);
            }
            return res.ToString();
        }
    }
}

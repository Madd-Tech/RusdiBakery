using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.Models;
using RusdiBakery.repos;

namespace RusdiBakery.Views.Admin.Forms
{
    public partial class AdminRegisterForm : Form
    {
        public AdminRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validate all fields are filled
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate passwords match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if email already exists
                if (AdminRepo.IsEmailExists(email))
                {
                    MessageBox.Show("This email is already registered.", "Registration Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create admin object and register
                var admin = new RusdiBakery.Models.Admin
                {
                    Username = username,
                    Email = email,
                    Password = password
                };

                bool success = AdminRepo.Register(admin);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 loginForm = new Form2();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 loginForm = new Form2();
            loginForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RusdiBakery.Views.Admin;
using RusdiBakery.Views.Admin.Forms;
using RusdiBakery.Views.Admin.Panels;
using RusdiBakery.repos;

namespace RusdiBakery
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();
            string password = textBox3.Text;

            // Validate fields are filled
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in email and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var admin = AdminRepo.Login(email, password);

                if (admin != null)
                {
                    MessageBox.Show($"Welcome, {admin.Username}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminLayout AdminLayout = new AdminLayout();
                    AdminLayout.Show();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegisterForm registerForm = new AdminRegisterForm();
            registerForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }
    }
}

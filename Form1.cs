using RusdiBakery.Views.Public.Forms;
using RusdiBakery.repos;

namespace RusdiBakery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e) { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text.Trim();
            string password = textBox3.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in email and password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var customer = CustomerRepo.Login(email, password);

                if (customer != null)
                {
                    // FIX: Simpan customer yang login ke SessionManager
                    SessionManager.CurrentCustomer = customer;

                    MessageBox.Show($"Welcome, {customer.Username}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    PublicLayout PublicLayout = new PublicLayout();
                    PublicLayout.Show();
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
            CustomerRegisterForm registerForm = new CustomerRegisterForm();
            registerForm.Show();
        }
    }
}
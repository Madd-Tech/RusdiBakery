using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RusdiBakery;
using RusdiBakery.repos;
using RusdiBakery.Views.Public.Panels;
using MainMenu = RusdiBakery.Views.Public.Panels.MainMenu;

namespace RusdiBakery.Views.Public.Forms
{
    public partial class PublicLayout : Form
    {
        public PublicLayout()
        {
            InitializeComponent();
            PrimaryPanels.Controls.Clear();
            PrimaryPanels.Controls.Add(new MainMenu());
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimaryPanels.Controls.Clear();
            PrimaryPanels.Controls.Add(new ProductList());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin?", "Konfirmasi",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // FIX: Bersihkan session saat logout
                SessionManager.Clear();

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Yakin?", "Konfirmasi",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                // FIX: Bersihkan session saat logout
                SessionManager.Clear();

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
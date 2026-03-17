using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace RusdiBakery.Views.Admin.Panels
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50; // besar lengkungan

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel1.Region = new Region(path);
        }

        private void secondpanel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50; // besar lengkungan

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(secondpanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(secondpanel.Width - radius, secondpanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, secondpanel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            secondpanel.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50; // besar lengkungan

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(thirdpanel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(thirdpanel.Width - radius, thirdpanel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0,  thirdpanel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            thirdpanel.Region = new Region(path);
        }
    }
}

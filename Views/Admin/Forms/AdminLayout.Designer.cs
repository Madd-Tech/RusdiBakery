namespace RusdiBakery.Views.Admin
{
    partial class AdminLayout
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
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            recipeToolStripMenuItem = new ToolStripMenuItem();
            memberToolStripMenuItem = new ToolStripMenuItem();
            recipeToolStripMenuItem1 = new ToolStripMenuItem();
            MainPanels = new Panel();
            label1 = new Label();
            stockToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Honeydew;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, recipeToolStripMenuItem, memberToolStripMenuItem, recipeToolStripMenuItem1, stockToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1271, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(164, 36);
            filesToolStripMenuItem.Text = "AdminMenu";
            filesToolStripMenuItem.Click += filesToolStripMenuItem_Click;
            // 
            // recipeToolStripMenuItem
            // 
            recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            recipeToolStripMenuItem.Size = new Size(268, 36);
            recipeToolStripMenuItem.Text = "Product Management";
            recipeToolStripMenuItem.Click += recipeToolStripMenuItem_Click;
            // 
            // memberToolStripMenuItem
            // 
            memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            memberToolStripMenuItem.Size = new Size(240, 36);
            memberToolStripMenuItem.Text = "Transaction History";
            memberToolStripMenuItem.Click += memberToolStripMenuItem_Click;
            // 
            // recipeToolStripMenuItem1
            // 
            recipeToolStripMenuItem1.Name = "recipeToolStripMenuItem1";
            recipeToolStripMenuItem1.Size = new Size(16, 36);
            // 
            // MainPanels
            // 
            MainPanels.BackColor = Color.Lavender;
            MainPanels.Location = new Point(25, 149);
            MainPanels.Name = "MainPanels";
            MainPanels.Size = new Size(1220, 633);
            MainPanels.TabIndex = 1;
            MainPanels.Paint += MainPanels_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(39, 64);
            label1.Name = "label1";
            label1.Size = new Size(182, 45);
            label1.TabIndex = 2;
            label1.Text = "Hi, Admin!";
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(89, 36);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(67, 36);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // AdminLayout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__22_1;
            ClientSize = new Size(1271, 827);
            Controls.Add(label1);
            Controls.Add(MainPanels);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminLayout";
            Text = "AdminLayout";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem recipeToolStripMenuItem;
        private Panel MainPanels;
        private Label label1;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem recipeToolStripMenuItem1;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
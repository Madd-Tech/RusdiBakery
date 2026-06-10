namespace RusdiBakery.Views.Public.Panels
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Indigo;
            label3.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightPink;
            label3.Location = new Point(116, 115);
            label3.Name = "label3";
            label3.Size = new Size(306, 52);
            label3.TabIndex = 4;
            label3.Text = "Main Menu Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Indigo;
            label2.Font = new Font("Noto Sans SC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(43, 63);
            label2.Name = "label2";
            label2.Size = new Size(228, 52);
            label2.TabIndex = 5;
            label2.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(686, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 496);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "MainMenu";
            Size = new Size(1188, 682);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
    }
}

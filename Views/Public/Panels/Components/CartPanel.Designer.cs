namespace RusdiBakery.Views.Public.Panels.Components
{
    partial class CartPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            labelTotal = new Label();
            buttonClear = new Button();
            buttonRemove = new Button();
            buttonCheckout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(400, 300);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 1;
            label1.Text = "Your Cart";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotal.ForeColor = Color.Gold;
            labelTotal.Location = new Point(15, 370);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(147, 32);
            labelTotal.TabIndex = 2;
            labelTotal.Text = "Total: IDR 0";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(15, 420);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(120, 45);
            buttonClear.TabIndex = 3;
            buttonClear.Text = "Clear Cart";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(145, 420);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(120, 45);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "Remove Item";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonCheckout
            // 
            buttonCheckout.BackColor = Color.SeaGreen;
            buttonCheckout.FlatStyle = FlatStyle.Flat;
            buttonCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCheckout.ForeColor = Color.White;
            buttonCheckout.Location = new Point(275, 420);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(140, 45);
            buttonCheckout.TabIndex = 5;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = false;
            // 
            // CartPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(buttonCheckout);
            Controls.Add(buttonRemove);
            Controls.Add(buttonClear);
            Controls.Add(labelTotal);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "CartPanel";
            Size = new Size(430, 480);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        private Label label1;
        private Label labelTotal;
        private Button buttonClear;
        private Button buttonRemove;
        private Button buttonCheckout;
    }
}

namespace QuanLyThuVien
{
    partial class TraCuuDocGia
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
            label1 = new Label();
            cmbTim = new ComboBox();
            txbTimDocGia = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 13);
            label1.Name = "label1";
            label1.Size = new Size(173, 26);
            label1.TabIndex = 0;
            label1.Text = "Tra cứu độc giả";
            // 
            // cmbTim
            // 
            cmbTim.FormattingEnabled = true;
            cmbTim.Location = new Point(53, 65);
            cmbTim.Name = "cmbTim";
            cmbTim.Size = new Size(121, 23);
            cmbTim.TabIndex = 1;
            // 
            // txbTimDocGia
            // 
            txbTimDocGia.Location = new Point(191, 65);
            txbTimDocGia.Name = "txbTimDocGia";
            txbTimDocGia.Size = new Size(302, 21);
            txbTimDocGia.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 251);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txbTimDocGia);
            panel1.Controls.Add(cmbTim);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 412);
            panel1.TabIndex = 4;
            // 
            // TraCuuDocGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 408);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "TraCuuDocGia";
            Text = "Thông tin độc giả";
            Load += TraCuuDocGia_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbTim;
        private TextBox txbTimDocGia;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}
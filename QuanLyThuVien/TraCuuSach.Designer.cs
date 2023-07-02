namespace QuanLyThuVien
{
    partial class TraCuuSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuSach));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txbTimKiem = new TextBox();
            dataDanhSachSach = new DataGridView();
            cmbTimKiemTheo = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataDanhSachSach).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(212, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 45);
            label1.TabIndex = 0;
            label1.Text = "Tra cứu sách";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(txbTimKiem);
            groupBox1.Controls.Add(dataDanhSachSach);
            groupBox1.Controls.Add(cmbTimKiemTheo);
            groupBox1.Location = new Point(21, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 409);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sách:";
            // 
            // txbTimKiem
            // 
            txbTimKiem.Location = new Point(263, 52);
            txbTimKiem.Name = "txbTimKiem";
            txbTimKiem.Size = new Size(402, 26);
            txbTimKiem.TabIndex = 2;
            txbTimKiem.TextChanged += txbTimKiem_TextChanged;
            // 
            // dataDanhSachSach
            // 
            dataDanhSachSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataDanhSachSach.Location = new Point(37, 107);
            dataDanhSachSach.Name = "dataDanhSachSach";
            dataDanhSachSach.RowHeadersWidth = 51;
            dataDanhSachSach.RowTemplate.Height = 29;
            dataDanhSachSach.Size = new Size(628, 277);
            dataDanhSachSach.TabIndex = 3;
            // 
            // cmbTimKiemTheo
            // 
            cmbTimKiemTheo.FormattingEnabled = true;
            cmbTimKiemTheo.Location = new Point(37, 52);
            cmbTimKiemTheo.Name = "cmbTimKiemTheo";
            cmbTimKiemTheo.Size = new Size(209, 27);
            cmbTimKiemTheo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(485, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 53);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 520);
            panel2.TabIndex = 3;
            // 
            // TraCuuSach
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 517);
            Controls.Add(panel2);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TraCuuSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tra cứu sách";
            FormClosing += TraCuuSach_FormClosing;
            Load += TraCuuSach_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataDanhSachSach).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataDanhSachSach;
        private ComboBox cmbTimKiemTheo;
        private TextBox txbTimKiem;
        private Panel panel1;
        private Panel panel2;
    }
}
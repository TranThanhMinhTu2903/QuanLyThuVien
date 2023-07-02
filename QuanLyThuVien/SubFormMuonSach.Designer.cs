namespace QuanLyThuVien
{
    partial class SubFormMuonSach
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
            lbTacGia = new Label();
            lbTheLoai = new Label();
            lbTenSach = new Label();
            lbMaSach = new Label();
            lbNgayMuon = new Label();
            lbDocGia = new Label();
            lbPMS = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTacGia
            // 
            lbTacGia.AutoSize = true;
            lbTacGia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTacGia.Location = new Point(47, 140);
            lbTacGia.Margin = new Padding(2, 0, 2, 0);
            lbTacGia.Name = "lbTacGia";
            lbTacGia.Size = new Size(70, 19);
            lbTacGia.TabIndex = 14;
            lbTacGia.Text = "Tác giả:";
            // 
            // lbTheLoai
            // 
            lbTheLoai.AutoSize = true;
            lbTheLoai.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTheLoai.Location = new Point(310, 69);
            lbTheLoai.Margin = new Padding(2, 0, 2, 0);
            lbTheLoai.Name = "lbTheLoai";
            lbTheLoai.Size = new Size(75, 19);
            lbTheLoai.TabIndex = 13;
            lbTheLoai.Text = "Thể loại:";
            // 
            // lbTenSach
            // 
            lbTenSach.AutoSize = true;
            lbTenSach.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenSach.Location = new Point(300, 32);
            lbTenSach.Margin = new Padding(2, 0, 2, 0);
            lbTenSach.Name = "lbTenSach";
            lbTenSach.Size = new Size(85, 19);
            lbTenSach.TabIndex = 12;
            lbTenSach.Text = "Tên sách:";
            // 
            // lbMaSach
            // 
            lbMaSach.AutoEllipsis = true;
            lbMaSach.AutoSize = true;
            lbMaSach.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMaSach.Location = new Point(64, 69);
            lbMaSach.Margin = new Padding(2, 0, 2, 0);
            lbMaSach.Name = "lbMaSach";
            lbMaSach.Size = new Size(78, 19);
            lbMaSach.TabIndex = 11;
            lbMaSach.Text = "Mã sách:";
            // 
            // lbNgayMuon
            // 
            lbNgayMuon.AutoSize = true;
            lbNgayMuon.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgayMuon.Location = new Point(109, 111);
            lbNgayMuon.Margin = new Padding(2, 0, 2, 0);
            lbNgayMuon.Name = "lbNgayMuon";
            lbNgayMuon.Size = new Size(106, 19);
            lbNgayMuon.TabIndex = 10;
            lbNgayMuon.Text = "Ngày mượn:";
            // 
            // lbDocGia
            // 
            lbDocGia.AutoSize = true;
            lbDocGia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDocGia.Location = new Point(47, 32);
            lbDocGia.Margin = new Padding(2, 0, 2, 0);
            lbDocGia.Name = "lbDocGia";
            lbDocGia.Size = new Size(104, 19);
            lbDocGia.TabIndex = 9;
            lbDocGia.Text = "Tên độc giả:";
            // 
            // lbPMS
            // 
            lbPMS.AutoSize = true;
            lbPMS.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbPMS.Location = new Point(137, 0);
            lbPMS.Margin = new Padding(2, 0, 2, 0);
            lbPMS.Name = "lbPMS";
            lbPMS.Size = new Size(287, 37);
            lbPMS.TabIndex = 8;
            lbPMS.Text = "Phiếu mượn sách";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(lbPMS);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 257);
            panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbTacGia);
            groupBox1.Controls.Add(lbTheLoai);
            groupBox1.Controls.Add(lbTenSach);
            groupBox1.Controls.Add(lbMaSach);
            groupBox1.Controls.Add(lbNgayMuon);
            groupBox1.Controls.Add(lbDocGia);
            groupBox1.Location = new Point(28, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 183);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mượn sách";
            // 
            // SubFormMuonSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 255);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "SubFormMuonSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubFormMuonSach";
            Load += SubFormMuonSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lbTacGia;
        private Label lbTheLoai;
        private Label lbTenSach;
        private Label lbMaSach;
        private Label lbNgayMuon;
        private Label lbDocGia;
        private Label lbPMS;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}
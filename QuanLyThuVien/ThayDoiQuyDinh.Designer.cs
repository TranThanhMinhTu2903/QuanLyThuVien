namespace QuanLyThuVien
{
    partial class ThayDoiQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiQuyDinh));
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnMuonTraSach = new Button();
            btnQDnhapsach = new Button();
            btnQDdocgia = new Button();
            panel1 = new Panel();
            numHetHan = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            numMinTuoi = new NumericUpDown();
            numMaxTuoi = new NumericUpDown();
            label2 = new Label();
            panel2 = new Panel();
            numberTienPhat = new NumericUpDown();
            numberMaxSachNgay = new NumericUpDown();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            numberNgayMax = new NumericUpDown();
            numberMaxSoSach = new NumericUpDown();
            label8 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label10 = new Label();
            txtTenMoi = new TextBox();
            cmbTenTheLoai = new ComboBox();
            numberKhoangCachXB = new NumericUpDown();
            label5 = new Label();
            btnThayDoiQuyDinh1 = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numHetHan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinTuoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxTuoi).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberTienPhat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberMaxSachNgay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberNgayMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberMaxSoSach).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberKhoangCachXB).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 18);
            label1.Name = "label1";
            label1.Size = new Size(353, 37);
            label1.TabIndex = 0;
            label1.Text = "Thay đổi các quy định";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Highlight;
            groupBox1.Controls.Add(btnMuonTraSach);
            groupBox1.Controls.Add(btnQDnhapsach);
            groupBox1.Controls.Add(btnQDdocgia);
            groupBox1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(30, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các quy định";
            // 
            // btnMuonTraSach
            // 
            btnMuonTraSach.Location = new Point(300, 43);
            btnMuonTraSach.Name = "btnMuonTraSach";
            btnMuonTraSach.Size = new Size(280, 47);
            btnMuonTraSach.TabIndex = 2;
            btnMuonTraSach.Text = "Quy định về mượn/trả sách ";
            btnMuonTraSach.UseVisualStyleBackColor = true;
            btnMuonTraSach.Click += btnMuonTraSach_Click;
            // 
            // btnQDnhapsach
            // 
            btnQDnhapsach.Location = new Point(586, 43);
            btnQDnhapsach.Name = "btnQDnhapsach";
            btnQDnhapsach.Size = new Size(215, 47);
            btnQDnhapsach.TabIndex = 3;
            btnQDnhapsach.Text = "Quy định về nhập sách";
            btnQDnhapsach.UseVisualStyleBackColor = true;
            btnQDnhapsach.Click += btnQDnhapsach_Click;
            // 
            // btnQDdocgia
            // 
            btnQDdocgia.Location = new Point(79, 43);
            btnQDdocgia.Name = "btnQDdocgia";
            btnQDdocgia.Size = new Size(215, 47);
            btnQDdocgia.TabIndex = 1;
            btnQDdocgia.Text = "Quy định về độc giả";
            btnQDdocgia.UseVisualStyleBackColor = true;
            btnQDdocgia.Click += btnQDdocgia_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(numHetHan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numMinTuoi);
            panel1.Controls.Add(numMaxTuoi);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 87);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // numHetHan
            // 
            numHetHan.Location = new Point(734, 37);
            numHetHan.Margin = new Padding(5);
            numHetHan.Name = "numHetHan";
            numHetHan.Size = new Size(68, 24);
            numHetHan.TabIndex = 5;
            numHetHan.ValueChanged += numHetHan_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 39);
            label4.Name = "label4";
            label4.Size = new Size(137, 18);
            label4.TabIndex = 4;
            label4.Text = "Thời gian hết hạn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 37);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 3;
            label3.Text = "Độ tuổi tối thiểu:";
            // 
            // numMinTuoi
            // 
            numMinTuoi.Location = new Point(445, 35);
            numMinTuoi.Margin = new Padding(4);
            numMinTuoi.Name = "numMinTuoi";
            numMinTuoi.Size = new Size(65, 24);
            numMinTuoi.TabIndex = 2;
            numMinTuoi.ValueChanged += numMinTuoi_ValueChanged;
            // 
            // numMaxTuoi
            // 
            numMaxTuoi.Location = new Point(195, 31);
            numMaxTuoi.Margin = new Padding(4);
            numMaxTuoi.Name = "numMaxTuoi";
            numMaxTuoi.Size = new Size(60, 24);
            numMaxTuoi.TabIndex = 1;
            numMaxTuoi.ValueChanged += numMaxTuoi_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 37);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 0;
            label2.Text = "Độ tuổi tối đa:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(numberTienPhat);
            panel2.Controls.Add(numberMaxSachNgay);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(numberNgayMax);
            panel2.Controls.Add(numberMaxSoSach);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(24, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 89);
            panel2.TabIndex = 6;
            panel2.Visible = false;
            // 
            // numberTienPhat
            // 
            numberTienPhat.Location = new Point(708, 15);
            numberTienPhat.Margin = new Padding(4);
            numberTienPhat.Name = "numberTienPhat";
            numberTienPhat.Size = new Size(123, 24);
            numberTienPhat.TabIndex = 8;
            numberTienPhat.ValueChanged += numberTienPhat_ValueChanged;
            // 
            // numberMaxSachNgay
            // 
            numberMaxSachNgay.Location = new Point(289, 50);
            numberMaxSachNgay.Margin = new Padding(4);
            numberMaxSachNgay.Name = "numberMaxSachNgay";
            numberMaxSachNgay.Size = new Size(64, 24);
            numberMaxSachNgay.TabIndex = 7;
            numberMaxSachNgay.ValueChanged += numberMaxSachNgay_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 52);
            label9.Name = "label9";
            label9.Size = new Size(152, 18);
            label9.TabIndex = 6;
            label9.Text = "Số ngày mượn sách:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 17);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 4;
            label6.Text = "Tiền phạt:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(394, 17);
            label7.Name = "label7";
            label7.Size = new Size(111, 18);
            label7.TabIndex = 3;
            label7.Text = "Số ngày tối đa:";
            // 
            // numberNgayMax
            // 
            numberNgayMax.Location = new Point(532, 9);
            numberNgayMax.Margin = new Padding(4);
            numberNgayMax.Name = "numberNgayMax";
            numberNgayMax.Size = new Size(42, 24);
            numberNgayMax.TabIndex = 2;
            numberNgayMax.ValueChanged += numberNgayMax_ValueChanged;
            // 
            // numberMaxSoSach
            // 
            numberMaxSoSach.Location = new Point(289, 9);
            numberMaxSoSach.Margin = new Padding(4);
            numberMaxSoSach.Name = "numberMaxSoSach";
            numberMaxSoSach.Size = new Size(42, 24);
            numberMaxSoSach.TabIndex = 1;
            numberMaxSoSach.ValueChanged += numberMaxSoSach_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 15);
            label8.Name = "label8";
            label8.Size = new Size(201, 18);
            label8.TabIndex = 0;
            label8.Text = "Số sách tối đa được mượn:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtTenMoi);
            panel3.Controls.Add(cmbTenTheLoai);
            panel3.Controls.Add(numberKhoangCachXB);
            panel3.Controls.Add(label5);
            panel3.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel3.Location = new Point(30, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(950, 72);
            panel3.TabIndex = 9;
            panel3.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(687, 23);
            label11.Name = "label11";
            label11.Size = new Size(63, 18);
            label11.TabIndex = 5;
            label11.Text = "Đổi tên:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(298, 23);
            label10.Name = "label10";
            label10.Size = new Size(199, 18);
            label10.TabIndex = 4;
            label10.Text = "chọn thể loại muốn đổi tên:";
            // 
            // txtTenMoi
            // 
            txtTenMoi.Location = new Point(757, 20);
            txtTenMoi.Name = "txtTenMoi";
            txtTenMoi.Size = new Size(182, 24);
            txtTenMoi.TabIndex = 3;
            // 
            // cmbTenTheLoai
            // 
            cmbTenTheLoai.FormattingEnabled = true;
            cmbTenTheLoai.Location = new Point(499, 18);
            cmbTenTheLoai.Name = "cmbTenTheLoai";
            cmbTenTheLoai.Size = new Size(182, 26);
            cmbTenTheLoai.TabIndex = 2;
            // 
            // numberKhoangCachXB
            // 
            numberKhoangCachXB.Location = new Point(199, 21);
            numberKhoangCachXB.Name = "numberKhoangCachXB";
            numberKhoangCachXB.Size = new Size(66, 24);
            numberKhoangCachXB.TabIndex = 1;
            numberKhoangCachXB.ValueChanged += numberKhoangCachXB_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 26);
            label5.Name = "label5";
            label5.Size = new Size(168, 18);
            label5.TabIndex = 0;
            label5.Text = "Khoảng cách xuất bản:";
            // 
            // btnThayDoiQuyDinh1
            // 
            btnThayDoiQuyDinh1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnThayDoiQuyDinh1.Location = new Point(408, 328);
            btnThayDoiQuyDinh1.Name = "btnThayDoiQuyDinh1";
            btnThayDoiQuyDinh1.Size = new Size(140, 44);
            btnThayDoiQuyDinh1.TabIndex = 11;
            btnThayDoiQuyDinh1.Text = "Thay đổi";
            btnThayDoiQuyDinh1.UseVisualStyleBackColor = false;
            btnThayDoiQuyDinh1.Visible = false;
            btnThayDoiQuyDinh1.Click += btnThayDoiQuyDinh1_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Location = new Point(628, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(66, 63);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(btnThayDoiQuyDinh1);
            panel5.Controls.Add(groupBox1);
            panel5.Controls.Add(label1);
            panel5.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point);
            panel5.Location = new Point(0, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 459);
            panel5.TabIndex = 13;
            panel5.Paint += panel5_Paint;
            // 
            // ThayDoiQuyDinh
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 452);
            Controls.Add(panel5);
            Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ThayDoiQuyDinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thay Đổi Quy Định";
            FormClosing += ThayDoiQuyDinh_FormClosing;
            Load += ThayDoiQuyDinh_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numHetHan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinTuoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxTuoi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberTienPhat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberMaxSachNgay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberNgayMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberMaxSoSach).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberKhoangCachXB).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnQDdocgia;
        private Button btnMuonTraSach;
        private Button btnQDnhapsach;
        private Panel panel1;
        private Label label2;
        private NumericUpDown numHetHan;
        private Label label4;
        private Label label3;
        private NumericUpDown numMinTuoi;
        private NumericUpDown numMaxTuoi;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private NumericUpDown numberNgayMax;
        private NumericUpDown numberMaxSoSach;
        private Label label8;
        private Panel panel3;
        private NumericUpDown numberKhoangCachXB;
        private Label label5;
        private Button btnThayDoiQuyDinh3;
        private Panel panel4;
        private NumericUpDown numberMaxSachNgay;
        private Label label9;
        private NumericUpDown numberTienPhat;
        private Panel panel5;
        private Label label11;
        private Label label10;
        private TextBox txtTenMoi;
        private ComboBox cmbTenTheLoai;
        private Button btnThayDoiQuyDinh1;
    }
}
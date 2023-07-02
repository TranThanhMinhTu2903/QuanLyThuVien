namespace QuanLyThuVien
{
    partial class ThemDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDocGia));
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnCanel = new Button();
            btnTaoDocGia = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txBEmail = new TextBox();
            dateNgaySinh = new DateTimePicker();
            cmbLoaiDocGia = new ComboBox();
            txBDiaChi = new TextBox();
            txBHovaTen = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(181, 17);
            label2.Name = "label2";
            label2.Size = new Size(406, 65);
            label2.TabIndex = 0;
            label2.Text = "Thêm Độc Giả";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.MenuHighlight;
            groupBox1.Controls.Add(btnCanel);
            groupBox1.Controls.Add(btnTaoDocGia);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txBEmail);
            groupBox1.Controls.Add(dateNgaySinh);
            groupBox1.Controls.Add(cmbLoaiDocGia);
            groupBox1.Controls.Add(txBDiaChi);
            groupBox1.Controls.Add(txBHovaTen);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(24, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 358);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin cần nhập:";
            // 
            // btnCanel
            // 
            btnCanel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCanel.Location = new Point(340, 277);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(94, 38);
            btnCanel.TabIndex = 7;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // btnTaoDocGia
            // 
            btnTaoDocGia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTaoDocGia.Location = new Point(204, 277);
            btnTaoDocGia.Name = "btnTaoDocGia";
            btnTaoDocGia.Size = new Size(94, 38);
            btnTaoDocGia.TabIndex = 6;
            btnTaoDocGia.Text = "Tạo thẻ";
            btnTaoDocGia.UseVisualStyleBackColor = true;
            btnTaoDocGia.Click += btnTaoDocGia_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(204, 214);
            label7.Name = "label7";
            label7.Size = new Size(84, 29);
            label7.TabIndex = 8;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(204, 161);
            label6.Name = "label6";
            label6.Size = new Size(99, 29);
            label6.TabIndex = 7;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(174, 117);
            label5.Name = "label5";
            label5.Size = new Size(135, 29);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(156, 65);
            label4.Name = "label4";
            label4.Size = new Size(162, 29);
            label4.TabIndex = 5;
            label4.Text = "Loại độc giả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(174, 25);
            label3.Name = "label3";
            label3.Size = new Size(135, 29);
            label3.TabIndex = 2;
            label3.Text = "Họ và Tên:";
            // 
            // txBEmail
            // 
            txBEmail.Location = new Point(340, 214);
            txBEmail.Name = "txBEmail";
            txBEmail.Size = new Size(184, 28);
            txBEmail.TabIndex = 5;
            // 
            // dateNgaySinh
            // 
            dateNgaySinh.Format = DateTimePickerFormat.Short;
            dateNgaySinh.Location = new Point(340, 118);
            dateNgaySinh.Name = "dateNgaySinh";
            dateNgaySinh.Size = new Size(184, 28);
            dateNgaySinh.TabIndex = 3;
            dateNgaySinh.Value = new DateTime(2003, 1, 1, 0, 0, 0, 0);
            // 
            // cmbLoaiDocGia
            // 
            cmbLoaiDocGia.FormattingEnabled = true;
            cmbLoaiDocGia.Location = new Point(340, 65);
            cmbLoaiDocGia.Name = "cmbLoaiDocGia";
            cmbLoaiDocGia.Size = new Size(184, 29);
            cmbLoaiDocGia.TabIndex = 2;
            // 
            // txBDiaChi
            // 
            txBDiaChi.Location = new Point(340, 164);
            txBDiaChi.Name = "txBDiaChi";
            txBDiaChi.Size = new Size(184, 28);
            txBDiaChi.TabIndex = 4;
            // 
            // txBHovaTen
            // 
            txBHovaTen.Location = new Point(340, 25);
            txBHovaTen.Name = "txBHovaTen";
            txBHovaTen.Size = new Size(184, 28);
            txBHovaTen.TabIndex = 1;
            txBHovaTen.TextChanged += txBHovaTen_TextChanged;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(464, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(77, 75);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(719, 453);
            panel2.TabIndex = 3;
            // 
            // ThemDocGia
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 454);
            Controls.Add(panel2);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "ThemDocGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Độc Giả";
            FormClosing += ThemDocGia_FormClosing;
            Load += ThemDocGia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txBEmail;
        private DateTimePicker dateNgaySinh;
        private ComboBox cmbLoaiDocGia;
        private TextBox txBDiaChi;
        private TextBox txBHovaTen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCanel;
        private Button btnTaoDocGia;
        private Panel panel1;
        private Panel panel2;
    }
}
namespace QuanLyThuVien
{
    partial class BaoCaoThangTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoThangTheLoai));
            panel1 = new Panel();
            btnExcelSave = new Button();
            label3 = new Label();
            dataBaoCaoThangTheLoai = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaoCaoThangTheLoai).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcelSave);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataBaoCaoThangTheLoai);
            panel1.Location = new Point(8, 76);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 260);
            panel1.TabIndex = 0;
            // 
            // btnExcelSave
            // 
            btnExcelSave.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcelSave.Location = new Point(447, 206);
            btnExcelSave.Margin = new Padding(2);
            btnExcelSave.Name = "btnExcelSave";
            btnExcelSave.Size = new Size(78, 26);
            btnExcelSave.TabIndex = 3;
            btnExcelSave.Text = "Lưu";
            btnExcelSave.UseVisualStyleBackColor = true;
            btnExcelSave.Click += btnExcelSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(254, 211);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(133, 16);
            label3.TabIndex = 1;
            label3.Text = "Tổng số lượt mượn:";
            // 
            // dataBaoCaoThangTheLoai
            // 
            dataBaoCaoThangTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBaoCaoThangTheLoai.Location = new Point(39, 11);
            dataBaoCaoThangTheLoai.Margin = new Padding(2);
            dataBaoCaoThangTheLoai.Name = "dataBaoCaoThangTheLoai";
            dataBaoCaoThangTheLoai.RowHeadersWidth = 62;
            dataBaoCaoThangTheLoai.RowTemplate.Height = 33;
            dataBaoCaoThangTheLoai.Size = new Size(524, 191);
            dataBaoCaoThangTheLoai.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(36, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(488, 22);
            label1.TabIndex = 1;
            label1.Text = "Báo cáo thống kế tình hình mượn sách theo thể loại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(103, 55);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 16);
            label2.TabIndex = 2;
            label2.Text = "Ngày lập báo cáo:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(556, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(46, 48);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(628, 354);
            panel3.TabIndex = 4;
            // 
            // BaoCaoThangTheLoai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 353);
            Controls.Add(panel3);
            Margin = new Padding(2);
            Name = "BaoCaoThangTheLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BaoCaoThangTheLoai";
            FormClosing += BaoCaoThangTheLoai_FormClosing;
            Load += BaoCaoThangTheLoai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBaoCaoThangTheLoai).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private DataGridView dataBaoCaoThangTheLoai;
        private Label label1;
        private Label label2;
        private Button btnExcelSave;
        private Panel panel2;
        private Panel panel3;
    }
}
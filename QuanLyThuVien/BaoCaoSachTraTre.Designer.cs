namespace QuanLyThuVien
{
    partial class BaoCaoSachTraTre
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
            label2 = new Label();
            dataSachTraTre = new DataGridView();
            btnSave = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataSachTraTre).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 24);
            label1.Name = "label1";
            label1.Size = new Size(465, 37);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo thống kê sách trả trễ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(168, 72);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 1;
            label2.Text = "Ngày báo cáo:\r\n";
            // 
            // dataSachTraTre
            // 
            dataSachTraTre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSachTraTre.Location = new Point(72, 107);
            dataSachTraTre.Name = "dataSachTraTre";
            dataSachTraTre.RowHeadersWidth = 62;
            dataSachTraTre.RowTemplate.Height = 25;
            dataSachTraTre.Size = new Size(560, 227);
            dataSachTraTre.TabIndex = 2;
            dataSachTraTre.CellContentClick += dataSachTraTre_CellContentClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(439, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(dataSachTraTre);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 390);
            panel1.TabIndex = 4;
            // 
            // BaoCaoSachTraTre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 388);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "BaoCaoSachTraTre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo sách trả trễ";
            FormClosing += BaoCaoSachTraTre_FormClosing;
            Load += BaoCaoSachTraTre_Load;
            ((System.ComponentModel.ISupportInitialize)dataSachTraTre).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataSachTraTre;
        private Button btnSave;
        private Panel panel1;
    }
}
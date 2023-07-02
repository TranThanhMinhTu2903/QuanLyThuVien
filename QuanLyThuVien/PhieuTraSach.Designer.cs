namespace QuanLyThuVien
{
    partial class PhieuTraSach
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
            btnCanel = new Button();
            btnMuonSach = new Button();
            txbMaCuonSach = new TextBox();
            txbMaDocGia = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCanel
            // 
            btnCanel.Location = new Point(280, 155);
            btnCanel.Name = "btnCanel";
            btnCanel.Size = new Size(106, 42);
            btnCanel.TabIndex = 4;
            btnCanel.Text = "Hủy";
            btnCanel.UseVisualStyleBackColor = true;
            btnCanel.Click += btnCanel_Click;
            // 
            // btnMuonSach
            // 
            btnMuonSach.Location = new Point(134, 154);
            btnMuonSach.Name = "btnMuonSach";
            btnMuonSach.Size = new Size(115, 43);
            btnMuonSach.TabIndex = 3;
            btnMuonSach.Text = "Trả sách";
            btnMuonSach.UseVisualStyleBackColor = true;
            btnMuonSach.Click += btnMuonSach_Click;
            // 
            // txbMaCuonSach
            // 
            txbMaCuonSach.Location = new Point(201, 103);
            txbMaCuonSach.Name = "txbMaCuonSach";
            txbMaCuonSach.Size = new Size(185, 21);
            txbMaCuonSach.TabIndex = 2;
            // 
            // txbMaDocGia
            // 
            txbMaDocGia.Location = new Point(201, 62);
            txbMaDocGia.Name = "txbMaDocGia";
            txbMaDocGia.Size = new Size(185, 21);
            txbMaDocGia.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 105);
            label3.Name = "label3";
            label3.Size = new Size(121, 19);
            label3.TabIndex = 9;
            label3.Text = "Mã cuốn sách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 64);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 7;
            label2.Text = "Mã độc giả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 14);
            label1.Name = "label1";
            label1.Size = new Size(202, 32);
            label1.TabIndex = 5;
            label1.Text = "Phiếu trả sách";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnCanel);
            panel2.Controls.Add(txbMaDocGia);
            panel2.Controls.Add(btnMuonSach);
            panel2.Controls.Add(txbMaCuonSach);
            panel2.Location = new Point(-4, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(554, 274);
            panel2.TabIndex = 13;
            // 
            // PhieuTraSach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 262);
            Controls.Add(panel2);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "PhieuTraSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phiếu Trả Sách";
            FormClosing += PhieuTraSach_FormClosing;
            Load += PhieuTraSach_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCanel;
        private Button btnMuonSach;
        private TextBox txbMaCuonSach;
        private TextBox txbMaDocGia;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}
namespace QuanLyThuVien
{
    partial class Login
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            txbPass = new TextBox();
            txbUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txbPass);
            panel1.Controls.Add(txbUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(47, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 160);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(246, 112);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(153, 112);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 3;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(153, 66);
            txbPass.Name = "txbPass";
            txbPass.Size = new Size(142, 21);
            txbPass.TabIndex = 2;
            txbPass.UseSystemPasswordChar = true;
            // 
            // txbUser
            // 
            txbUser.Location = new Point(153, 35);
            txbUser.Name = "txbUser";
            txbUser.Size = new Size(142, 21);
            txbUser.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 66);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 35);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 21);
            label1.Name = "label1";
            label1.Size = new Size(167, 24);
            label1.TabIndex = 1;
            label1.Text = "Quản lý thư viện";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(470, 228);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox txbPass;
        private TextBox txbUser;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
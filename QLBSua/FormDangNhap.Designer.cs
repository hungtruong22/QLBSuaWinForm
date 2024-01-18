namespace QLBSua
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnThoatCT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(227, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to HC-Milks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(324, 68);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 1;
            label2.Text = "Đăng Nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 136);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 195);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 374);
            label5.Name = "label5";
            label5.Size = new Size(211, 20);
            label5.TabIndex = 4;
            label5.Text = "Nếu bạn chưa có tài khoản thì ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 374);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "tại đây!";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(518, 374);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "đăng ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(481, 27);
            txtEmail.TabIndex = 7;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.ForeColor = SystemColors.WindowText;
            txtMatKhau.Location = new Point(162, 188);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(481, 27);
            txtMatKhau.TabIndex = 8;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Teal;
            btnDangNhap.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(338, 251);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(115, 53);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoatCT
            // 
            btnThoatCT.Location = new Point(33, 409);
            btnThoatCT.Name = "btnThoatCT";
            btnThoatCT.Size = new Size(94, 29);
            btnThoatCT.TabIndex = 10;
            btnThoatCT.Text = "Thoát CT";
            btnThoatCT.UseVisualStyleBackColor = true;
            btnThoatCT.Click += btnThoatCT_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoatCT);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private LinkLabel linkLabel1;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnThoatCT;
    }
}
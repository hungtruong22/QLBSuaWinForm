namespace QLBSua
{
    partial class FormDangKy
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            txtNhapLaiMatKhau = new TextBox();
            btnDangKy = new Button();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(211, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 46);
            label1.TabIndex = 1;
            label1.Text = "Welcome to HC-Milks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(325, 67);
            label2.Name = "label2";
            label2.Size = new Size(127, 38);
            label2.TabIndex = 2;
            label2.Text = "Đăng Ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 132);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 190);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "TênDN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 249);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 301);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 6;
            label6.Text = "Nhập lại mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(211, 125);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(477, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(211, 183);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(477, 27);
            txtTenDN.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(211, 242);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(477, 27);
            txtMatKhau.TabIndex = 9;
            // 
            // txtNhapLaiMatKhau
            // 
            txtNhapLaiMatKhau.Location = new Point(211, 294);
            txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            txtNhapLaiMatKhau.Size = new Size(477, 27);
            txtNhapLaiMatKhau.TabIndex = 10;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Teal;
            btnDangKy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.Transparent;
            btnDangKy.Location = new Point(355, 340);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(106, 46);
            btnDangKy.TabIndex = 11;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(539, 419);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 12;
            label7.Text = "Quay lại";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(608, 419);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "đăng nhập";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(btnDangKy);
            Controls.Add(txtNhapLaiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangKy";
            Load += FormDangKy_Load;
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
        private TextBox txtEmail;
        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private TextBox txtNhapLaiMatKhau;
        private Button btnDangKy;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}
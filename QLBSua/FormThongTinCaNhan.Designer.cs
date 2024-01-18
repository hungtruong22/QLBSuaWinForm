namespace QLBSua
{
    partial class FormThongTinCaNhan
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
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaTK = new TextBox();
            txtTenDN = new TextBox();
            txtEmail = new TextBox();
            txtChucVu = new TextBox();
            txtTrangThai = new TextBox();
            btnChinhSuaTT = new Button();
            btnDoiMK = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(360, 58);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 29;
            label1.Text = "HC-Milks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 150);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 30;
            label4.Text = "Mã TK :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 215);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 31;
            label2.Text = "Tên DN :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 272);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 32;
            label3.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(85, 335);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 33;
            label5.Text = "Chức Vụ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(85, 395);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 34;
            label6.Text = "Trạng Thái :";
            // 
            // txtMaTK
            // 
            txtMaTK.Location = new Point(233, 143);
            txtMaTK.Name = "txtMaTK";
            txtMaTK.Size = new Size(353, 27);
            txtMaTK.TabIndex = 35;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(233, 208);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(353, 27);
            txtTenDN.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(233, 265);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(353, 27);
            txtEmail.TabIndex = 37;
            // 
            // txtChucVu
            // 
            txtChucVu.Location = new Point(233, 328);
            txtChucVu.Name = "txtChucVu";
            txtChucVu.Size = new Size(353, 27);
            txtChucVu.TabIndex = 38;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(233, 388);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(353, 27);
            txtTrangThai.TabIndex = 39;
            // 
            // btnChinhSuaTT
            // 
            btnChinhSuaTT.Location = new Point(675, 143);
            btnChinhSuaTT.Name = "btnChinhSuaTT";
            btnChinhSuaTT.Size = new Size(116, 43);
            btnChinhSuaTT.TabIndex = 40;
            btnChinhSuaTT.Text = "Chỉnh sửa TT";
            btnChinhSuaTT.UseVisualStyleBackColor = true;
            btnChinhSuaTT.Click += btnChinhSuaTT_Click;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Location = new Point(675, 227);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(116, 43);
            btnDoiMK.TabIndex = 41;
            btnDoiMK.Text = "Đổi MK";
            btnDoiMK.UseVisualStyleBackColor = true;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(697, 493);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(116, 43);
            btnBoQua.TabIndex = 43;
            btnBoQua.Text = "Quay lại";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(856, 572);
            Controls.Add(btnBoQua);
            Controls.Add(btnDoiMK);
            Controls.Add(btnChinhSuaTT);
            Controls.Add(txtTrangThai);
            Controls.Add(txtChucVu);
            Controls.Add(txtEmail);
            Controls.Add(txtTenDN);
            Controls.Add(txtMaTK);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FormThongTinCaNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongTinCaNhan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtMaTK;
        private TextBox txtTenDN;
        private TextBox txtEmail;
        private TextBox txtChucVu;
        private TextBox txtTrangThai;
        private Button btnChinhSuaTT;
        private Button btnDoiMK;
        private Button btnBoQua;
    }
}
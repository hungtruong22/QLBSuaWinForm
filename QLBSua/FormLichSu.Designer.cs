namespace QLBSua
{
    partial class FormLichSu
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lbHoTen = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dgvLichSu = new DataGridView();
            matkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenspDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giamgiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongmuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mahdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhtienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaymuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoaDonThanhToanBindingSource = new BindingSource(components);
            btnQuayLai = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(462, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 30;
            label1.Text = "HC-Milks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(431, 73);
            label2.Name = "label2";
            label2.Size = new Size(228, 38);
            label2.TabIndex = 31;
            label2.Text = "Lịch sử đặt món";
            // 
            // lbHoTen
            // 
            lbHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbHoTen.ForeColor = Color.White;
            lbHoTen.Location = new Point(142, 141);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(89, 20);
            lbHoTen.TabIndex = 39;
            lbHoTen.Text = "HT :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 141);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 38;
            label3.Text = "Nhân Viên :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvLichSu);
            panel1.Location = new Point(38, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 291);
            panel1.TabIndex = 40;
            // 
            // dgvLichSu
            // 
            dgvLichSu.AllowUserToAddRows = false;
            dgvLichSu.AllowUserToDeleteRows = false;
            dgvLichSu.AutoGenerateColumns = false;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Columns.AddRange(new DataGridViewColumn[] { matkDataGridViewTextBoxColumn, tenspDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, giamgiaDataGridViewTextBoxColumn, soluongmuaDataGridViewTextBoxColumn, mahdDataGridViewTextBoxColumn, thanhtienDataGridViewTextBoxColumn, ngaymuaDataGridViewTextBoxColumn });
            dgvLichSu.DataSource = hoaDonThanhToanBindingSource;
            dgvLichSu.Dock = DockStyle.Fill;
            dgvLichSu.Location = new Point(0, 0);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.ReadOnly = true;
            dgvLichSu.RowHeadersWidth = 51;
            dgvLichSu.RowTemplate.Height = 29;
            dgvLichSu.Size = new Size(1018, 291);
            dgvLichSu.TabIndex = 0;
            // 
            // matkDataGridViewTextBoxColumn
            // 
            matkDataGridViewTextBoxColumn.DataPropertyName = "matk";
            matkDataGridViewTextBoxColumn.HeaderText = "matk";
            matkDataGridViewTextBoxColumn.MinimumWidth = 6;
            matkDataGridViewTextBoxColumn.Name = "matkDataGridViewTextBoxColumn";
            matkDataGridViewTextBoxColumn.ReadOnly = true;
            matkDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenspDataGridViewTextBoxColumn
            // 
            tenspDataGridViewTextBoxColumn.DataPropertyName = "tensp";
            tenspDataGridViewTextBoxColumn.HeaderText = "tensp";
            tenspDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenspDataGridViewTextBoxColumn.Name = "tenspDataGridViewTextBoxColumn";
            tenspDataGridViewTextBoxColumn.ReadOnly = true;
            tenspDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            giaDataGridViewTextBoxColumn.HeaderText = "gia";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.ReadOnly = true;
            giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // giamgiaDataGridViewTextBoxColumn
            // 
            giamgiaDataGridViewTextBoxColumn.DataPropertyName = "giamgia";
            giamgiaDataGridViewTextBoxColumn.HeaderText = "giamgia";
            giamgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giamgiaDataGridViewTextBoxColumn.Name = "giamgiaDataGridViewTextBoxColumn";
            giamgiaDataGridViewTextBoxColumn.ReadOnly = true;
            giamgiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongmuaDataGridViewTextBoxColumn
            // 
            soluongmuaDataGridViewTextBoxColumn.DataPropertyName = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.HeaderText = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongmuaDataGridViewTextBoxColumn.Name = "soluongmuaDataGridViewTextBoxColumn";
            soluongmuaDataGridViewTextBoxColumn.ReadOnly = true;
            soluongmuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mahdDataGridViewTextBoxColumn
            // 
            mahdDataGridViewTextBoxColumn.DataPropertyName = "mahd";
            mahdDataGridViewTextBoxColumn.HeaderText = "mahd";
            mahdDataGridViewTextBoxColumn.MinimumWidth = 6;
            mahdDataGridViewTextBoxColumn.Name = "mahdDataGridViewTextBoxColumn";
            mahdDataGridViewTextBoxColumn.ReadOnly = true;
            mahdDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            thanhtienDataGridViewTextBoxColumn.HeaderText = "thanhtien";
            thanhtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            thanhtienDataGridViewTextBoxColumn.ReadOnly = true;
            thanhtienDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaymuaDataGridViewTextBoxColumn
            // 
            ngaymuaDataGridViewTextBoxColumn.DataPropertyName = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn.HeaderText = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaymuaDataGridViewTextBoxColumn.Name = "ngaymuaDataGridViewTextBoxColumn";
            ngaymuaDataGridViewTextBoxColumn.ReadOnly = true;
            ngaymuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonThanhToanBindingSource
            // 
            hoaDonThanhToanBindingSource.DataSource = typeof(Model.HoaDonThanhToan);
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(946, 535);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(110, 48);
            btnQuayLai.TabIndex = 42;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormLichSu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1068, 595);
            Controls.Add(btnQuayLai);
            Controls.Add(panel1);
            Controls.Add(lbHoTen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLichSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLichSu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbHoTen;
        private Label label3;
        private Panel panel1;
        private DataGridView dgvLichSu;
        private DataGridViewTextBoxColumn matkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giamgiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongmuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaymuaDataGridViewTextBoxColumn;
        private BindingSource hoaDonThanhToanBindingSource;
        private Button btnQuayLai;
    }
}
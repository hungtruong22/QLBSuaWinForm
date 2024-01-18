namespace QLBSua
{
    partial class FormQuanLyHoaDon
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
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            lbTongHD = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            mahdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaymuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoaDonBindingSource = new BindingSource(components);
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            matkDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tenspDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongmuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mahdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            thanhtienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaymuaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            hoaDonThanhToanBindingSource = new BindingSource(components);
            btnQuayLai = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(522, 75);
            label2.Name = "label2";
            label2.Size = new Size(248, 38);
            label2.TabIndex = 35;
            label2.Text = "Quản Lý Hóa Đơn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(546, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 34;
            label1.Text = "HC-Milks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 117);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 44;
            label5.Text = "Tổng số HD :";
            // 
            // lbTongHD
            // 
            lbTongHD.AutoSize = true;
            lbTongHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongHD.ForeColor = Color.White;
            lbTongHD.Location = new Point(161, 117);
            lbTongHD.Name = "lbTongHD";
            lbTongHD.Size = new Size(18, 20);
            lbTongHD.TabIndex = 45;
            lbTongHD.Text = "0";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(32, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 216);
            panel1.TabIndex = 46;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mahdDataGridViewTextBoxColumn, matkDataGridViewTextBoxColumn, ngaymuaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hoaDonBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(435, 216);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // matkDataGridViewTextBoxColumn
            // 
            matkDataGridViewTextBoxColumn.DataPropertyName = "matk";
            matkDataGridViewTextBoxColumn.HeaderText = "matk";
            matkDataGridViewTextBoxColumn.MinimumWidth = 6;
            matkDataGridViewTextBoxColumn.Name = "matkDataGridViewTextBoxColumn";
            matkDataGridViewTextBoxColumn.ReadOnly = true;
            matkDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaymuaDataGridViewTextBoxColumn
            // 
            ngaymuaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngaymuaDataGridViewTextBoxColumn.DataPropertyName = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn.HeaderText = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaymuaDataGridViewTextBoxColumn.Name = "ngaymuaDataGridViewTextBoxColumn";
            ngaymuaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoaDonBindingSource
            // 
            hoaDonBindingSource.DataSource = typeof(Model.HoaDon);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 164);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 47;
            label3.Text = "Danh sách hóa đơn :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(586, 164);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 48;
            label4.Text = "Chi tiết hóa đơn :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(586, 206);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 216);
            panel2.TabIndex = 49;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { matkDataGridViewTextBoxColumn1, tenspDataGridViewTextBoxColumn, soluongmuaDataGridViewTextBoxColumn, mahdDataGridViewTextBoxColumn1, thanhtienDataGridViewTextBoxColumn, ngaymuaDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = hoaDonThanhToanBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(758, 216);
            dataGridView2.TabIndex = 0;
            // 
            // matkDataGridViewTextBoxColumn1
            // 
            matkDataGridViewTextBoxColumn1.DataPropertyName = "matk";
            matkDataGridViewTextBoxColumn1.HeaderText = "matk";
            matkDataGridViewTextBoxColumn1.MinimumWidth = 6;
            matkDataGridViewTextBoxColumn1.Name = "matkDataGridViewTextBoxColumn1";
            matkDataGridViewTextBoxColumn1.ReadOnly = true;
            matkDataGridViewTextBoxColumn1.Width = 125;
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
            // soluongmuaDataGridViewTextBoxColumn
            // 
            soluongmuaDataGridViewTextBoxColumn.DataPropertyName = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.HeaderText = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongmuaDataGridViewTextBoxColumn.Name = "soluongmuaDataGridViewTextBoxColumn";
            soluongmuaDataGridViewTextBoxColumn.ReadOnly = true;
            soluongmuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mahdDataGridViewTextBoxColumn1
            // 
            mahdDataGridViewTextBoxColumn1.DataPropertyName = "mahd";
            mahdDataGridViewTextBoxColumn1.HeaderText = "mahd";
            mahdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            mahdDataGridViewTextBoxColumn1.Name = "mahdDataGridViewTextBoxColumn1";
            mahdDataGridViewTextBoxColumn1.ReadOnly = true;
            mahdDataGridViewTextBoxColumn1.Width = 125;
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
            // ngaymuaDataGridViewTextBoxColumn1
            // 
            ngaymuaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngaymuaDataGridViewTextBoxColumn1.DataPropertyName = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn1.HeaderText = "ngaymua";
            ngaymuaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            ngaymuaDataGridViewTextBoxColumn1.Name = "ngaymuaDataGridViewTextBoxColumn1";
            ngaymuaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hoaDonThanhToanBindingSource
            // 
            hoaDonThanhToanBindingSource.DataSource = typeof(Model.HoaDonThanhToan);
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(1298, 505);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(104, 42);
            btnQuayLai.TabIndex = 50;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormQuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1429, 559);
            Controls.Add(btnQuayLai);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lbTongHD);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuanLyHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyHoaDon";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label5;
        private Label lbTongHD;
        private Panel panel1;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaymuaDataGridViewTextBoxColumn;
        private BindingSource hoaDonBindingSource;
        private Label label4;
        private Panel panel2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn matkDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongmuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaymuaDataGridViewTextBoxColumn1;
        private BindingSource hoaDonThanhToanBindingSource;
        private Button btnQuayLai;
    }
}
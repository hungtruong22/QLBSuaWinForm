namespace QLBSua
{
    partial class FormHoaDon
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
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbNgayMua = new Label();
            lbHoTen = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            tenspDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giamgiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongmuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhtienDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoaDonThanhToanBindingSource = new BindingSource(components);
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lbTSL = new Label();
            lbTTT = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(323, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 29;
            label1.Text = "HC-Milks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(275, 115);
            label2.Name = "label2";
            label2.Size = new Size(294, 38);
            label2.TabIndex = 30;
            label2.Text = "Hóa Đơn Thanh Toán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 188);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 32;
            label6.Text = "Ngày mua :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 229);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 33;
            label3.Text = "Nhân Viên :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(599, 54);
            label4.Name = "label4";
            label4.Size = new Size(151, 20);
            label4.TabIndex = 34;
            label4.Text = "28 Lương Y - TP.Huế";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(599, 86);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 35;
            label5.Text = "SĐT : 0796731759";
            // 
            // lbNgayMua
            // 
            lbNgayMua.AutoSize = true;
            lbNgayMua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbNgayMua.ForeColor = Color.White;
            lbNgayMua.Location = new Point(135, 188);
            lbNgayMua.Name = "lbNgayMua";
            lbNgayMua.Size = new Size(101, 20);
            lbNgayMua.TabIndex = 36;
            lbNgayMua.Text = "dd/MM/yyyy";
            // 
            // lbHoTen
            // 
            lbHoTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbHoTen.ForeColor = Color.White;
            lbHoTen.Location = new Point(135, 229);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(89, 20);
            lbHoTen.TabIndex = 37;
            lbHoTen.Text = "HT :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(60, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 212);
            panel1.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tenspDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, giamgiaDataGridViewTextBoxColumn, soluongmuaDataGridViewTextBoxColumn, thanhtienDataGridViewTextBoxColumn });
            dataGridView1.DataSource = hoaDonThanhToanBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 212);
            dataGridView1.TabIndex = 0;
            // 
            // tenspDataGridViewTextBoxColumn
            // 
            tenspDataGridViewTextBoxColumn.DataPropertyName = "tensp";
            tenspDataGridViewTextBoxColumn.HeaderText = "tensp";
            tenspDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenspDataGridViewTextBoxColumn.Name = "tenspDataGridViewTextBoxColumn";
            tenspDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            giaDataGridViewTextBoxColumn.HeaderText = "gia";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // giamgiaDataGridViewTextBoxColumn
            // 
            giamgiaDataGridViewTextBoxColumn.DataPropertyName = "giamgia";
            giamgiaDataGridViewTextBoxColumn.HeaderText = "giamgia";
            giamgiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giamgiaDataGridViewTextBoxColumn.Name = "giamgiaDataGridViewTextBoxColumn";
            giamgiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // soluongmuaDataGridViewTextBoxColumn
            // 
            soluongmuaDataGridViewTextBoxColumn.DataPropertyName = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.HeaderText = "soluongmua";
            soluongmuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongmuaDataGridViewTextBoxColumn.Name = "soluongmuaDataGridViewTextBoxColumn";
            soluongmuaDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            thanhtienDataGridViewTextBoxColumn.HeaderText = "thanhtien";
            thanhtienDataGridViewTextBoxColumn.MinimumWidth = 6;
            thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            thanhtienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonThanhToanBindingSource
            // 
            hoaDonThanhToanBindingSource.DataSource = typeof(Model.HoaDonThanhToan);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 283);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 39;
            label7.Text = "Danh sách SP :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(400, 658);
            label8.Name = "label8";
            label8.Size = new Size(375, 20);
            label8.TabIndex = 40;
            label8.Text = "HC-Milks xin cám ơn quý khách đã tin tưởng ủng hộ.";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(60, 563);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 41;
            label9.Text = "Tổng SL :";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(60, 602);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 42;
            label10.Text = "Tổng thanh toán :";
            // 
            // lbTSL
            // 
            lbTSL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTSL.ForeColor = Color.White;
            lbTSL.Location = new Point(205, 563);
            lbTSL.Name = "lbTSL";
            lbTSL.Size = new Size(89, 20);
            lbTSL.TabIndex = 43;
            lbTSL.Text = "0";
            lbTSL.Click += label11_Click;
            // 
            // lbTTT
            // 
            lbTTT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTTT.ForeColor = Color.White;
            lbTTT.Location = new Point(205, 602);
            lbTTT.Name = "lbTTT";
            lbTTT.Size = new Size(89, 20);
            lbTTT.TabIndex = 44;
            lbTTT.Text = "0";
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 710);
            Controls.Add(lbTTT);
            Controls.Add(lbTSL);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(lbHoTen);
            Controls.Add(lbNgayMua);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHoaDon";
            Load += FormHoaDon_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoaDonThanhToanBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lbNgayMua;
        private Label lbHoTen;
        private Panel panel1;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giamgiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongmuaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private BindingSource hoaDonThanhToanBindingSource;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbTSL;
        private Label lbTTT;
    }
}
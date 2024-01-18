namespace QLBSua
{
    partial class FormThongKe
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
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbSLNV = new Label();
            lbBanCham = new Label();
            lbTongSL = new Label();
            lbTongDT = new Label();
            btnQuayLai = new Button();
            label8 = new Label();
            panel1 = new Panel();
            dgvBanChay = new DataGridView();
            tenspDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tongslmuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thongKeBindingSource = new BindingSource(components);
            panel2 = new Panel();
            dgvBanCham = new DataGridView();
            tenspDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            tongslmuaDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            thongKeBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanChay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thongKeBindingSource).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBanCham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thongKeBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(442, 72);
            label2.Name = "label2";
            label2.Size = new Size(140, 38);
            label2.TabIndex = 33;
            label2.Text = "Thống kê";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(427, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 46);
            label1.TabIndex = 32;
            label1.Text = "HC-Milks";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 124);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 42;
            label4.Text = "SL Nhân Viên :";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 168);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 43;
            label3.Text = "SP bán chạy nhất :";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 432);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 44;
            label5.Text = "SP bán chậm nhất :";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 765);
            label6.Name = "label6";
            label6.Size = new Size(141, 20);
            label6.TabIndex = 45;
            label6.Text = "Tổng doanh thu :";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 699);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 46;
            label7.Text = "Tổng SL bán ra :";
            // 
            // lbSLNV
            // 
            lbSLNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbSLNV.ForeColor = Color.White;
            lbSLNV.Location = new Point(236, 124);
            lbSLNV.Name = "lbSLNV";
            lbSLNV.Size = new Size(141, 20);
            lbSLNV.TabIndex = 47;
            lbSLNV.Text = "0";
            // 
            // lbBanCham
            // 
            lbBanCham.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbBanCham.ForeColor = Color.White;
            lbBanCham.Location = new Point(196, 432);
            lbBanCham.Name = "lbBanCham";
            lbBanCham.Size = new Size(141, 20);
            lbBanCham.TabIndex = 49;
            lbBanCham.Text = "0";
            // 
            // lbTongSL
            // 
            lbTongSL.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongSL.ForeColor = Color.White;
            lbTongSL.Location = new Point(196, 699);
            lbTongSL.Name = "lbTongSL";
            lbTongSL.Size = new Size(141, 20);
            lbTongSL.TabIndex = 50;
            lbTongSL.Text = "0";
            // 
            // lbTongDT
            // 
            lbTongDT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongDT.ForeColor = Color.White;
            lbTongDT.Location = new Point(196, 765);
            lbTongDT.Name = "lbTongDT";
            lbTongDT.Size = new Size(95, 20);
            lbTongDT.TabIndex = 51;
            lbTongDT.Text = "0";
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(885, 783);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(119, 40);
            btnQuayLai.TabIndex = 52;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(337, 765);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 53;
            label8.Text = "vnd";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvBanChay);
            panel1.Location = new Point(29, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 199);
            panel1.TabIndex = 54;
            // 
            // dgvBanChay
            // 
            dgvBanChay.AutoGenerateColumns = false;
            dgvBanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanChay.Columns.AddRange(new DataGridViewColumn[] { tenspDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, tongslmuaDataGridViewTextBoxColumn });
            dgvBanChay.DataSource = thongKeBindingSource;
            dgvBanChay.Dock = DockStyle.Fill;
            dgvBanChay.Location = new Point(0, 0);
            dgvBanChay.Name = "dgvBanChay";
            dgvBanChay.RowHeadersWidth = 51;
            dgvBanChay.RowTemplate.Height = 29;
            dgvBanChay.Size = new Size(566, 199);
            dgvBanChay.TabIndex = 0;
            // 
            // tenspDataGridViewTextBoxColumn
            // 
            tenspDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenspDataGridViewTextBoxColumn.DataPropertyName = "tensp";
            tenspDataGridViewTextBoxColumn.HeaderText = "tensp";
            tenspDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenspDataGridViewTextBoxColumn.Name = "tenspDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            giaDataGridViewTextBoxColumn.HeaderText = "gia";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongslmuaDataGridViewTextBoxColumn
            // 
            tongslmuaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongslmuaDataGridViewTextBoxColumn.DataPropertyName = "tongslmua";
            tongslmuaDataGridViewTextBoxColumn.HeaderText = "tongslmua";
            tongslmuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            tongslmuaDataGridViewTextBoxColumn.Name = "tongslmuaDataGridViewTextBoxColumn";
            // 
            // thongKeBindingSource
            // 
            thongKeBindingSource.DataSource = typeof(Model.ThongKe);
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBanCham);
            panel2.Location = new Point(29, 485);
            panel2.Name = "panel2";
            panel2.Size = new Size(566, 178);
            panel2.TabIndex = 55;
            // 
            // dgvBanCham
            // 
            dgvBanCham.AutoGenerateColumns = false;
            dgvBanCham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBanCham.Columns.AddRange(new DataGridViewColumn[] { tenspDataGridViewTextBoxColumn1, giaDataGridViewTextBoxColumn1, tongslmuaDataGridViewTextBoxColumn1 });
            dgvBanCham.DataSource = thongKeBindingSource1;
            dgvBanCham.Dock = DockStyle.Fill;
            dgvBanCham.Location = new Point(0, 0);
            dgvBanCham.Name = "dgvBanCham";
            dgvBanCham.RowHeadersWidth = 51;
            dgvBanCham.RowTemplate.Height = 29;
            dgvBanCham.Size = new Size(566, 178);
            dgvBanCham.TabIndex = 0;
            // 
            // tenspDataGridViewTextBoxColumn1
            // 
            tenspDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenspDataGridViewTextBoxColumn1.DataPropertyName = "tensp";
            tenspDataGridViewTextBoxColumn1.HeaderText = "tensp";
            tenspDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tenspDataGridViewTextBoxColumn1.Name = "tenspDataGridViewTextBoxColumn1";
            // 
            // giaDataGridViewTextBoxColumn1
            // 
            giaDataGridViewTextBoxColumn1.DataPropertyName = "gia";
            giaDataGridViewTextBoxColumn1.HeaderText = "gia";
            giaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn1.Name = "giaDataGridViewTextBoxColumn1";
            giaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // tongslmuaDataGridViewTextBoxColumn1
            // 
            tongslmuaDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongslmuaDataGridViewTextBoxColumn1.DataPropertyName = "tongslmua";
            tongslmuaDataGridViewTextBoxColumn1.HeaderText = "tongslmua";
            tongslmuaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            tongslmuaDataGridViewTextBoxColumn1.Name = "tongslmuaDataGridViewTextBoxColumn1";
            // 
            // thongKeBindingSource1
            // 
            thongKeBindingSource1.DataSource = typeof(Model.ThongKe);
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1016, 835);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(btnQuayLai);
            Controls.Add(lbTongDT);
            Controls.Add(lbTongSL);
            Controls.Add(lbBanCham);
            Controls.Add(lbSLNV);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBanChay).EndInit();
            ((System.ComponentModel.ISupportInitialize)thongKeBindingSource).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBanCham).EndInit();
            ((System.ComponentModel.ISupportInitialize)thongKeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbSLNV;
        private Label lbBanCham;
        private Label lbTongSL;
        private Label lbTongDT;
        private Button btnQuayLai;
        private Label label8;
        private Panel panel1;
        private DataGridView dgvBanChay;
        private Panel panel2;
        private DataGridView dgvBanCham;
        private DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tongslmuaDataGridViewTextBoxColumn;
        private BindingSource thongKeBindingSource;
        private DataGridViewTextBoxColumn tenspDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn tongslmuaDataGridViewTextBoxColumn1;
        private BindingSource thongKeBindingSource1;
    }
}
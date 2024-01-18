namespace QLBSua
{
    partial class FormQuanLyLoai
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
            txtMaLoai = new TextBox();
            txtTenLoai = new TextBox();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            maloaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenloaiDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loaiBindingSource = new BindingSource(components);
            btnQuayLai = new Button();
            btnThemLoai = new Button();
            btnXoaLoai = new Button();
            btnSuaLoai = new Button();
            btnTimKiemLoai = new Button();
            btnHienThiLoai = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(371, 9);
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
            label2.Location = new Point(371, 67);
            label2.Name = "label2";
            label2.Size = new Size(185, 38);
            label2.TabIndex = 32;
            label2.Text = "Quản Lý Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 138);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 33;
            label6.Text = "Mã Loại :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 34;
            label3.Text = "Tên Loại :";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(126, 131);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.Size = new Size(184, 27);
            txtMaLoai.TabIndex = 35;
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(126, 177);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(184, 27);
            txtTenLoai.TabIndex = 36;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 182);
            panel1.TabIndex = 37;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maloaiDataGridViewTextBoxColumn, tenloaiDataGridViewTextBoxColumn });
            dataGridView1.DataSource = loaiBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(413, 182);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // maloaiDataGridViewTextBoxColumn
            // 
            maloaiDataGridViewTextBoxColumn.DataPropertyName = "maloai";
            maloaiDataGridViewTextBoxColumn.HeaderText = "maloai";
            maloaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            maloaiDataGridViewTextBoxColumn.Name = "maloaiDataGridViewTextBoxColumn";
            maloaiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenloaiDataGridViewTextBoxColumn
            // 
            tenloaiDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenloaiDataGridViewTextBoxColumn.DataPropertyName = "tenloai";
            tenloaiDataGridViewTextBoxColumn.HeaderText = "tenloai";
            tenloaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenloaiDataGridViewTextBoxColumn.Name = "tenloaiDataGridViewTextBoxColumn";
            // 
            // loaiBindingSource
            // 
            loaiBindingSource.DataSource = typeof(Model.Loai);
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(724, 481);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(103, 43);
            btnQuayLai.TabIndex = 38;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnThemLoai
            // 
            btnThemLoai.Location = new Point(542, 131);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(103, 41);
            btnThemLoai.TabIndex = 39;
            btnThemLoai.Text = "Thêm Loại";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // btnXoaLoai
            // 
            btnXoaLoai.Location = new Point(542, 200);
            btnXoaLoai.Name = "btnXoaLoai";
            btnXoaLoai.Size = new Size(103, 41);
            btnXoaLoai.TabIndex = 41;
            btnXoaLoai.Text = "Xóa Loại";
            btnXoaLoai.UseVisualStyleBackColor = true;
            btnXoaLoai.Click += btnXoaLoai_Click;
            // 
            // btnSuaLoai
            // 
            btnSuaLoai.Location = new Point(701, 131);
            btnSuaLoai.Name = "btnSuaLoai";
            btnSuaLoai.Size = new Size(103, 41);
            btnSuaLoai.TabIndex = 42;
            btnSuaLoai.Text = "Sửa Loại";
            btnSuaLoai.UseVisualStyleBackColor = true;
            btnSuaLoai.Click += btnSuaLoai_Click;
            // 
            // btnTimKiemLoai
            // 
            btnTimKiemLoai.Location = new Point(701, 200);
            btnTimKiemLoai.Name = "btnTimKiemLoai";
            btnTimKiemLoai.Size = new Size(103, 41);
            btnTimKiemLoai.TabIndex = 43;
            btnTimKiemLoai.Text = "Tìm KIếm";
            btnTimKiemLoai.UseVisualStyleBackColor = true;
            btnTimKiemLoai.Click += btnTimKiemLoai_Click;
            // 
            // btnHienThiLoai
            // 
            btnHienThiLoai.Location = new Point(542, 278);
            btnHienThiLoai.Name = "btnHienThiLoai";
            btnHienThiLoai.Size = new Size(118, 41);
            btnHienThiLoai.TabIndex = 44;
            btnHienThiLoai.Text = "Hiển Thị Loại";
            btnHienThiLoai.UseVisualStyleBackColor = true;
            btnHienThiLoai.Click += btnHienThiLoai_Click;
            // 
            // FormQuanLyLoai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(873, 536);
            Controls.Add(btnHienThiLoai);
            Controls.Add(btnTimKiemLoai);
            Controls.Add(btnSuaLoai);
            Controls.Add(btnXoaLoai);
            Controls.Add(btnThemLoai);
            Controls.Add(btnQuayLai);
            Controls.Add(panel1);
            Controls.Add(txtTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormQuanLyLoai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyLoai";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label6;
        private Label label3;
        private TextBox txtMaLoai;
        private TextBox txtTenLoai;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maloaiDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenloaiDataGridViewTextBoxColumn;
        private BindingSource loaiBindingSource;
        private Button btnQuayLai;
        private Button btnThemLoai;
        private Button btnXoaLoai;
        private Button btnSuaLoai;
        private Button btnTimKiemLoai;
        private Button btnHienThiLoai;
    }
}
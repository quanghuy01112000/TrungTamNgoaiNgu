namespace TTNN_Win.GUI
{
    partial class QuanLyThiSinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanLyDanhSachTS = new System.Windows.Forms.DataGridView();
            this.MaThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.textBoxTenThiSinh = new System.Windows.Forms.TextBox();
            this.lbMaThiSinh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaThiSinh = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDanhSachTS)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý danh sách thí sinh";
            // 
            // dgvQuanLyDanhSachTS
            // 
            this.dgvQuanLyDanhSachTS.AllowUserToResizeColumns = false;
            this.dgvQuanLyDanhSachTS.AllowUserToResizeRows = false;
            this.dgvQuanLyDanhSachTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDanhSachTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThiSinh,
            this.TenThiSinh,
            this.NgaySinh,
            this.GioiTinh,
            this.Cmnd,
            this.SoDienThoai});
            this.dgvQuanLyDanhSachTS.Location = new System.Drawing.Point(16, 70);
            this.dgvQuanLyDanhSachTS.MultiSelect = false;
            this.dgvQuanLyDanhSachTS.Name = "dgvQuanLyDanhSachTS";
            this.dgvQuanLyDanhSachTS.RowHeadersVisible = false;
            this.dgvQuanLyDanhSachTS.RowHeadersWidth = 51;
            this.dgvQuanLyDanhSachTS.RowTemplate.Height = 24;
            this.dgvQuanLyDanhSachTS.Size = new System.Drawing.Size(623, 414);
            this.dgvQuanLyDanhSachTS.TabIndex = 1;
            this.dgvQuanLyDanhSachTS.SelectionChanged += new System.EventHandler(this.dgvQuanLyDanhSachTS_SelectionChanged);
            // 
            // MaThiSinh
            // 
            this.MaThiSinh.HeaderText = "Mã Thí Sinh";
            this.MaThiSinh.MinimumWidth = 6;
            this.MaThiSinh.Name = "MaThiSinh";
            this.MaThiSinh.Width = 125;
            // 
            // TenThiSinh
            // 
            this.TenThiSinh.HeaderText = "Tên Thí Sinh";
            this.TenThiSinh.MinimumWidth = 6;
            this.TenThiSinh.Name = "TenThiSinh";
            this.TenThiSinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // Cmnd
            // 
            this.Cmnd.HeaderText = "CMND";
            this.Cmnd.MinimumWidth = 6;
            this.Cmnd.Name = "Cmnd";
            this.Cmnd.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.HeaderText = "Số Điện Thoại";
            this.SoDienThoai.MinimumWidth = 6;
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxSDT, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCMND, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGioiTinh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTenThiSinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbMaThiSinh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaThiSinh, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerNgaySinh, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(649, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 414);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT.Location = new System.Drawing.Point(96, 368);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(142, 22);
            this.textBoxSDT.TabIndex = 11;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.Location = new System.Drawing.Point(96, 299);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(142, 22);
            this.textBoxCMND.TabIndex = 10;
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGioiTinh.Location = new System.Drawing.Point(96, 230);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(145, 22);
            this.textBoxGioiTinh.TabIndex = 9;
            // 
            // textBoxTenThiSinh
            // 
            this.textBoxTenThiSinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTenThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenThiSinh.Location = new System.Drawing.Point(96, 92);
            this.textBoxTenThiSinh.Name = "textBoxTenThiSinh";
            this.textBoxTenThiSinh.Size = new System.Drawing.Size(142, 22);
            this.textBoxTenThiSinh.TabIndex = 7;
            // 
            // lbMaThiSinh
            // 
            this.lbMaThiSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaThiSinh.AutoSize = true;
            this.lbMaThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaThiSinh.Location = new System.Drawing.Point(3, 26);
            this.lbMaThiSinh.Name = "lbMaThiSinh";
            this.lbMaThiSinh.Size = new System.Drawing.Size(87, 16);
            this.lbMaThiSinh.TabIndex = 0;
            this.lbMaThiSinh.Text = "Mã thí sinh";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên thí sinh";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số điện thoại";
            // 
            // textBoxMaThiSinh
            // 
            this.textBoxMaThiSinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxMaThiSinh.Enabled = false;
            this.textBoxMaThiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaThiSinh.Location = new System.Drawing.Point(96, 23);
            this.textBoxMaThiSinh.Name = "textBoxMaThiSinh";
            this.textBoxMaThiSinh.ReadOnly = true;
            this.textBoxMaThiSinh.Size = new System.Drawing.Size(145, 22);
            this.textBoxMaThiSinh.TabIndex = 6;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(96, 161);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerNgaySinh.TabIndex = 12;
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(742, 35);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(823, 35);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(655, 35);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 5;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(127, 39);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(224, 22);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tìm kiếm thí sinh";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(564, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // QuanLyThiSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvQuanLyDanhSachTS);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyThiSinh";
            this.Text = "Quản lý danh sách thí sinh";
            this.Load += new System.EventHandler(this.QuanLyThiSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDanhSachTS)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanLyDanhSachTS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.TextBox textBoxTenThiSinh;
        private System.Windows.Forms.Label lbMaThiSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMaThiSinh;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGioiTinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Button button1;
    }
}
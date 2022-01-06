
namespace TTNN_Win.GUI
{
    partial class KhoaThiMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKTKhoaThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.txtTenKhoaThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSachKT = new System.Windows.Forms.DataGridView();
            this.MaKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongA2ToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongB1ToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSuaSoLuong = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSlA2 = new System.Windows.Forms.TextBox();
            this.txtSlB1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKT)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnKTKhoaThi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dtpNgayThi);
            this.panel1.Controls.Add(this.txtTenKhoaThi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 106);
            this.panel1.TabIndex = 2;
            // 
            // btnKTKhoaThi
            // 
            this.btnKTKhoaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKTKhoaThi.Location = new System.Drawing.Point(579, 63);
            this.btnKTKhoaThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKTKhoaThi.Name = "btnKTKhoaThi";
            this.btnKTKhoaThi.Size = new System.Drawing.Size(270, 34);
            this.btnKTKhoaThi.TabIndex = 10;
            this.btnKTKhoaThi.Text = "Kết thúc khóa thi";
            this.btnKTKhoaThi.UseVisualStyleBackColor = true;
            this.btnKTKhoaThi.Click += new System.EventHandler(this.btnKTKhoaThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(773, 15);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(678, 15);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 34);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(579, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThi.Location = new System.Drawing.Point(151, 69);
            this.dtpNgayThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(171, 30);
            this.dtpNgayThi.TabIndex = 6;
            this.dtpNgayThi.ValueChanged += new System.EventHandler(this.dtpNgayThi_ValueChanged);
            // 
            // txtTenKhoaThi
            // 
            this.txtTenKhoaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaThi.Location = new System.Drawing.Point(151, 21);
            this.txtTenKhoaThi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhoaThi.Name = "txtTenKhoaThi";
            this.txtTenKhoaThi.ReadOnly = true;
            this.txtTenKhoaThi.Size = new System.Drawing.Size(408, 30);
            this.txtTenKhoaThi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khóa thi";
            // 
            // dgvDanhSachKT
            // 
            this.dgvDanhSachKT.AllowUserToAddRows = false;
            this.dgvDanhSachKT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachKT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoaThi,
            this.TenKhoaThi,
            this.NgayThi,
            this.TrangThai,
            this.PhongA2ToiDa,
            this.PhongB1ToiDa});
            this.dgvDanhSachKT.Location = new System.Drawing.Point(25, 264);
            this.dgvDanhSachKT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSachKT.MultiSelect = false;
            this.dgvDanhSachKT.Name = "dgvDanhSachKT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKT.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachKT.RowHeadersVisible = false;
            this.dgvDanhSachKT.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachKT.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachKT.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachKT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachKT.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDanhSachKT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvDanhSachKT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDanhSachKT.RowTemplate.Height = 28;
            this.dgvDanhSachKT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachKT.Size = new System.Drawing.Size(863, 222);
            this.dgvDanhSachKT.TabIndex = 0;
            this.dgvDanhSachKT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachKT_CellClick);
            // 
            // MaKhoaThi
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhoaThi.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaKhoaThi.HeaderText = "Mã Khóa Thi";
            this.MaKhoaThi.MinimumWidth = 8;
            this.MaKhoaThi.Name = "MaKhoaThi";
            this.MaKhoaThi.ReadOnly = true;
            // 
            // TenKhoaThi
            // 
            this.TenKhoaThi.HeaderText = "Tên Khóa Thi";
            this.TenKhoaThi.MinimumWidth = 8;
            this.TenKhoaThi.Name = "TenKhoaThi";
            this.TenKhoaThi.ReadOnly = true;
            // 
            // NgayThi
            // 
            this.NgayThi.HeaderText = "Ngày Thi";
            this.NgayThi.MinimumWidth = 8;
            this.NgayThi.Name = "NgayThi";
            this.NgayThi.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // PhongA2ToiDa
            // 
            this.PhongA2ToiDa.HeaderText = "SL phòng A2";
            this.PhongA2ToiDa.MinimumWidth = 8;
            this.PhongA2ToiDa.Name = "PhongA2ToiDa";
            this.PhongA2ToiDa.ReadOnly = true;
            // 
            // PhongB1ToiDa
            // 
            this.PhongB1ToiDa.HeaderText = "Sl phòng B1";
            this.PhongB1ToiDa.MinimumWidth = 8;
            this.PhongB1ToiDa.Name = "PhongB1ToiDa";
            this.PhongB1ToiDa.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khóa thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách khóa thi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Trình độ A2";
            // 
            // btnSuaSoLuong
            // 
            this.btnSuaSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaSoLuong.Location = new System.Drawing.Point(595, 14);
            this.btnSuaSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSoLuong.Name = "btnSuaSoLuong";
            this.btnSuaSoLuong.Size = new System.Drawing.Size(235, 35);
            this.btnSuaSoLuong.TabIndex = 13;
            this.btnSuaSoLuong.Text = "Sửa số lượng";
            this.btnSuaSoLuong.UseVisualStyleBackColor = true;
            this.btnSuaSoLuong.Click += new System.EventHandler(this.btnSuaSoLuong_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(284, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Trình độ B1";
            // 
            // txtSlA2
            // 
            this.txtSlA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlA2.Location = new System.Drawing.Point(151, 18);
            this.txtSlA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlA2.Name = "txtSlA2";
            this.txtSlA2.Size = new System.Drawing.Size(40, 30);
            this.txtSlA2.TabIndex = 16;
            // 
            // txtSlB1
            // 
            this.txtSlB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlB1.Location = new System.Drawing.Point(412, 18);
            this.txtSlB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlB1.Name = "txtSlB1";
            this.txtSlB1.Size = new System.Drawing.Size(40, 30);
            this.txtSlB1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtSlB1);
            this.panel2.Controls.Add(this.txtSlA2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnSuaSoLuong);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(25, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 66);
            this.panel2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tạo số lượng phòng thi tối đa";
            // 
            // KhoaThiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachKT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoaThiMain";
            this.Text = "KhoaThiMain";
            this.Load += new System.EventHandler(this.KhoaThiMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKT)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.TextBox txtTenKhoaThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKTKhoaThi;
        private System.Windows.Forms.DataGridView dgvDanhSachKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSuaSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSlA2;
        private System.Windows.Forms.TextBox txtSlB1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongA2ToiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongB1ToiDa;
    }
}
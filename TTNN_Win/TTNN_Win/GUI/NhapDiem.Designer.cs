
using System;
using System.Windows.Forms;

namespace TTNN_Win.GUI
{
    partial class NhapDiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.dgvTS = new System.Windows.Forms.DataGridView();
            this.MaThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.cbPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbKhoa);
            this.groupBox1.Location = new System.Drawing.Point(39, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(840, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(695, 22);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cbPhong
            // 
            this.cbPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(377, 20);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(149, 24);
            this.cbPhong.TabIndex = 3;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(73, 20);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(195, 24);
            this.cbKhoa.TabIndex = 0;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // dgvTS
            // 
            this.dgvTS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThiSinh,
            this.MaPhongThi,
            this.SBD,
            this.TenThiSinh,
            this.DiemNghe,
            this.DiemNoi,
            this.DiemDoc,
            this.DiemViet});
            this.dgvTS.Location = new System.Drawing.Point(39, 132);
            this.dgvTS.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTS.MultiSelect = false;
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.RowHeadersWidth = 51;
            this.dgvTS.RowTemplate.Height = 24;
            this.dgvTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTS.Size = new System.Drawing.Size(840, 336);
            this.dgvTS.TabIndex = 5;
            this.dgvTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTS_CellClick);
            // 
            // MaThiSinh
            // 
            this.MaThiSinh.HeaderText = "Mã Thí Sinh";
            this.MaThiSinh.MinimumWidth = 6;
            this.MaThiSinh.Name = "MaThiSinh";
            this.MaThiSinh.Visible = false;
            // 
            // MaPhongThi
            // 
            this.MaPhongThi.HeaderText = "Mã Phòng Thi";
            this.MaPhongThi.MinimumWidth = 6;
            this.MaPhongThi.Name = "MaPhongThi";
            this.MaPhongThi.Visible = false;
            // 
            // SBD
            // 
            this.SBD.FillWeight = 70F;
            this.SBD.HeaderText = "Số báo danh";
            this.SBD.MinimumWidth = 6;
            this.SBD.Name = "SBD";
            // 
            // TenThiSinh
            // 
            this.TenThiSinh.HeaderText = "Tên thí sinh";
            this.TenThiSinh.MinimumWidth = 6;
            this.TenThiSinh.Name = "TenThiSinh";
            // 
            // DiemNghe
            // 
            this.DiemNghe.HeaderText = "Điểm nghe";
            this.DiemNghe.MinimumWidth = 6;
            this.DiemNghe.Name = "DiemNghe";
            // 
            // DiemNoi
            // 
            this.DiemNoi.HeaderText = "Điểm nói";
            this.DiemNoi.MinimumWidth = 6;
            this.DiemNoi.Name = "DiemNoi";
            // 
            // DiemDoc
            // 
            this.DiemDoc.HeaderText = "Điểm đọc";
            this.DiemDoc.MinimumWidth = 6;
            this.DiemDoc.Name = "DiemDoc";
            // 
            // DiemViet
            // 
            this.DiemViet.HeaderText = "Điểm Viết";
            this.DiemViet.MinimumWidth = 6;
            this.DiemViet.Name = "DiemViet";
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Location = new System.Drawing.Point(692, 96);
            this.btnLuuDiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(75, 23);
            this.btnLuuDiem.TabIndex = 6;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 496);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.dgvTS);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.DataGridView dgvTS;
        private System.Windows.Forms.Button btnLuuDiem;
        private DataGridViewTextBoxColumn MaThiSinh;
        private DataGridViewTextBoxColumn MaPhongThi;
        private DataGridViewTextBoxColumn SBD;
        private DataGridViewTextBoxColumn TenThiSinh;
        private DataGridViewTextBoxColumn DiemNghe;
        private DataGridViewTextBoxColumn DiemNoi;
        private DataGridViewTextBoxColumn DiemDoc;
        private DataGridViewTextBoxColumn DiemViet;
    }
}
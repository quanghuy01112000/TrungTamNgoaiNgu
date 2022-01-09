
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
            this.groupBox1.Location = new System.Drawing.Point(29, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(630, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(521, 18);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 19);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(283, 16);
            this.cbPhong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(113, 21);
            this.cbPhong.TabIndex = 3;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa :";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(55, 16);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(147, 21);
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
            this.dgvTS.Location = new System.Drawing.Point(29, 107);
            this.dgvTS.MultiSelect = false;
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.RowHeadersWidth = 51;
            this.dgvTS.RowTemplate.Height = 24;
            this.dgvTS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTS.Size = new System.Drawing.Size(630, 273);
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
            this.btnLuuDiem.Location = new System.Drawing.Point(519, 78);
            this.btnLuuDiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(56, 19);
            this.btnLuuDiem.TabIndex = 6;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 403);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.dgvTS);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemViet;
        private System.Windows.Forms.Button btnLuuDiem;
    }
}
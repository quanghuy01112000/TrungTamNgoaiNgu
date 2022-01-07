
namespace TTNN_Win.GUI
{
    partial class PhongThiMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoTT = new System.Windows.Forms.TextBox();
            this.txtTenKhoaThi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTrinhDo = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtTenPhongThi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachPT = new System.Windows.Forms.DataGridView();
            this.MaPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoaThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhongA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhongB1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSoTT);
            this.panel1.Controls.Add(this.txtTenKhoaThi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxTrinhDo);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.txtTenPhongThi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 192);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số TT";
            // 
            // txtSoTT
            // 
            this.txtSoTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTT.Location = new System.Drawing.Point(442, 20);
            this.txtSoTT.Name = "txtSoTT";
            this.txtSoTT.Size = new System.Drawing.Size(67, 35);
            this.txtSoTT.TabIndex = 16;
            this.txtSoTT.TextChanged += new System.EventHandler(this.txtSoTT_TextChanged);
            // 
            // txtTenKhoaThi
            // 
            this.txtTenKhoaThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhoaThi.Location = new System.Drawing.Point(170, 139);
            this.txtTenKhoaThi.Name = "txtTenKhoaThi";
            this.txtTenKhoaThi.ReadOnly = true;
            this.txtTenKhoaThi.Size = new System.Drawing.Size(644, 35);
            this.txtTenKhoaThi.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(866, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tên khóa thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số lượng thí sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trình độ";
            // 
            // cbxTrinhDo
            // 
            this.cbxTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrinhDo.FormattingEnabled = true;
            this.cbxTrinhDo.Items.AddRange(new object[] {
            "A2",
            "B1"});
            this.cbxTrinhDo.Location = new System.Drawing.Point(170, 20);
            this.cbxTrinhDo.Name = "cbxTrinhDo";
            this.cbxTrinhDo.Size = new System.Drawing.Size(121, 37);
            this.cbxTrinhDo.TabIndex = 11;
            this.cbxTrinhDo.SelectedValueChanged += new System.EventHandler(this.cbxTrinhDo_SelectedValueChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(747, 20);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(67, 35);
            this.txtSoLuong.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(866, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 42);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(866, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 42);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // txtTenPhongThi
            // 
            this.txtTenPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhongThi.Location = new System.Drawing.Point(170, 83);
            this.txtTenPhongThi.Name = "txtTenPhongThi";
            this.txtTenPhongThi.ReadOnly = true;
            this.txtTenPhongThi.Size = new System.Drawing.Size(160, 35);
            this.txtTenPhongThi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phòng thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách phòng thi";
            // 
            // dgvDanhSachPT
            // 
            this.dgvDanhSachPT.AllowUserToAddRows = false;
            this.dgvDanhSachPT.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPT.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhongThi,
            this.TenPhongThi,
            this.TrinhDo,
            this.SoLuongThiSinh,
            this.MaKhoaThi,
            this.SoLuongPhongA2,
            this.SoLuongPhongB1});
            this.dgvDanhSachPT.Location = new System.Drawing.Point(29, 250);
            this.dgvDanhSachPT.Name = "dgvDanhSachPT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachPT.RowHeadersVisible = false;
            this.dgvDanhSachPT.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachPT.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachPT.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvDanhSachPT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachPT.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDanhSachPT.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvDanhSachPT.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvDanhSachPT.RowTemplate.Height = 28;
            this.dgvDanhSachPT.Size = new System.Drawing.Size(971, 358);
            this.dgvDanhSachPT.TabIndex = 3;
            this.dgvDanhSachPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPT_CellClick);
            // 
            // MaPhongThi
            // 
            this.MaPhongThi.HeaderText = "Mã phòng thi";
            this.MaPhongThi.MinimumWidth = 8;
            this.MaPhongThi.Name = "MaPhongThi";
            this.MaPhongThi.ReadOnly = true;
            // 
            // TenPhongThi
            // 
            this.TenPhongThi.HeaderText = "Tên phòng thi";
            this.TenPhongThi.MinimumWidth = 8;
            this.TenPhongThi.Name = "TenPhongThi";
            this.TenPhongThi.ReadOnly = true;
            // 
            // TrinhDo
            // 
            this.TrinhDo.HeaderText = "Trình độ";
            this.TrinhDo.MinimumWidth = 8;
            this.TrinhDo.Name = "TrinhDo";
            this.TrinhDo.ReadOnly = true;
            // 
            // SoLuongThiSinh
            // 
            this.SoLuongThiSinh.HeaderText = "Số lượng thí sinh";
            this.SoLuongThiSinh.MinimumWidth = 8;
            this.SoLuongThiSinh.Name = "SoLuongThiSinh";
            this.SoLuongThiSinh.ReadOnly = true;
            // 
            // MaKhoaThi
            // 
            this.MaKhoaThi.HeaderText = "Mã khóa thi";
            this.MaKhoaThi.MinimumWidth = 8;
            this.MaKhoaThi.Name = "MaKhoaThi";
            this.MaKhoaThi.ReadOnly = true;
            // 
            // SoLuongPhongA2
            // 
            this.SoLuongPhongA2.HeaderText = "SL phòng A2";
            this.SoLuongPhongA2.MinimumWidth = 8;
            this.SoLuongPhongA2.Name = "SoLuongPhongA2";
            this.SoLuongPhongA2.ReadOnly = true;
            // 
            // SoLuongPhongB1
            // 
            this.SoLuongPhongB1.HeaderText = "SL phòng B1";
            this.SoLuongPhongB1.MinimumWidth = 8;
            this.SoLuongPhongB1.Name = "SoLuongPhongB1";
            this.SoLuongPhongB1.ReadOnly = true;
            // 
            // PhongThiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachPT);
            this.Name = "PhongThiMain";
            this.Text = "PhongThiMain";
            this.Load += new System.EventHandler(this.PhongThiMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenPhongThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachPT;
        private System.Windows.Forms.TextBox txtTenKhoaThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTrinhDo;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoaThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhongA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhongB1;
    }
}
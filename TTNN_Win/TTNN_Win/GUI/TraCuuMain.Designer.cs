
namespace TTNN_Win.GUI
{
    partial class TraCuuMain
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
            this.dgvThongTin = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.SBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemViet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTin
            // 
            this.dgvThongTin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SBD,
            this.TenPhongThi,
            this.DiemNghe,
            this.DiemNoi,
            this.DiemDoc,
            this.DiemViet});
            this.dgvThongTin.Location = new System.Drawing.Point(20, 132);
            this.dgvThongTin.Name = "dgvThongTin";
            this.dgvThongTin.RowHeadersVisible = false;
            this.dgvThongTin.RowHeadersWidth = 62;
            this.dgvThongTin.RowTemplate.Height = 28;
            this.dgvThongTin.Size = new System.Drawing.Size(973, 470);
            this.dgvThongTin.TabIndex = 0;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(215, 24);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(333, 35);
            this.txtTen.TabIndex = 4;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(215, 79);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(333, 35);
            this.txtSdt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên thí sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số điện thoại";
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(671, 42);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(162, 52);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // SBD
            // 
            this.SBD.HeaderText = "SBD";
            this.SBD.MinimumWidth = 8;
            this.SBD.Name = "SBD";
            this.SBD.ReadOnly = true;
            // 
            // TenPhongThi
            // 
            this.TenPhongThi.HeaderText = "Phòng thi";
            this.TenPhongThi.MinimumWidth = 8;
            this.TenPhongThi.Name = "TenPhongThi";
            this.TenPhongThi.ReadOnly = true;
            // 
            // DiemNghe
            // 
            this.DiemNghe.HeaderText = "Điểm nghe";
            this.DiemNghe.MinimumWidth = 8;
            this.DiemNghe.Name = "DiemNghe";
            this.DiemNghe.ReadOnly = true;
            // 
            // DiemNoi
            // 
            this.DiemNoi.HeaderText = "Điểm nói";
            this.DiemNoi.MinimumWidth = 8;
            this.DiemNoi.Name = "DiemNoi";
            this.DiemNoi.ReadOnly = true;
            // 
            // DiemDoc
            // 
            this.DiemDoc.HeaderText = "Điểm đọc";
            this.DiemDoc.MinimumWidth = 8;
            this.DiemDoc.Name = "DiemDoc";
            this.DiemDoc.ReadOnly = true;
            // 
            // DiemViet
            // 
            this.DiemViet.HeaderText = "Điểm viết";
            this.DiemViet.MinimumWidth = 8;
            this.DiemViet.Name = "DiemViet";
            this.DiemViet.ReadOnly = true;
            // 
            // TraCuuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 620);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.dgvThongTin);
            this.Name = "TraCuuMain";
            this.Text = "TraCuuMain";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTin;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn SBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhongThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemViet;
    }
}
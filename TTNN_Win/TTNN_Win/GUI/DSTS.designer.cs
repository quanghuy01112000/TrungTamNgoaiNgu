using System.Windows.Forms;

namespace TTNN_Win.GUI
{
    partial class DSTS
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
            this.dgvTS = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.cbxPhongThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKhoaThi = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTS
            // 
            this.dgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTS.Location = new System.Drawing.Point(5, 71);
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.RowHeadersWidth = 51;
            this.dgvTS.RowTemplate.Height = 25;
            this.dgvTS.Size = new System.Drawing.Size(755, 310);
            this.dgvTS.TabIndex = 0;
            this.dgvTS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTS_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(605, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(86, 20);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(528, 39);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 18);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(649, 387);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(111, 33);
            this.btnChiTiet.TabIndex = 8;
            this.btnChiTiet.Text = "Chi Tiết Thí Sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // cbxPhongThi
            // 
            this.cbxPhongThi.FormattingEnabled = true;
            this.cbxPhongThi.Location = new System.Drawing.Point(204, 38);
            this.cbxPhongThi.Name = "cbxPhongThi";
            this.cbxPhongThi.Size = new System.Drawing.Size(104, 21);
            this.cbxPhongThi.TabIndex = 14;
            this.cbxPhongThi.SelectedIndexChanged += new System.EventHandler(this.cbxPhongThi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phòng Thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khóa";
            // 
            // cbxKhoaThi
            // 
            this.cbxKhoaThi.FormattingEnabled = true;
            this.cbxKhoaThi.Location = new System.Drawing.Point(73, 38);
            this.cbxKhoaThi.Name = "cbxKhoaThi";
            this.cbxKhoaThi.Size = new System.Drawing.Size(44, 21);
            this.cbxKhoaThi.TabIndex = 18;
            this.cbxKhoaThi.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaThi_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(516, 387);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 33);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(697, 39);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(63, 20);
            this.btnTim.TabIndex = 20;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // DSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 432);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbxKhoaThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPhongThi);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvTS);
            this.Name = "DSTS";
            this.Text = "Danh Sách Thí Sinh";
            this.Load += new System.EventHandler(this.DSTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTS;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnChiTiet;
        private ComboBox cbxPhongThi;
        private Label label2;
        private Label label1;
        private ComboBox cbxKhoaThi;
        private Button btnRefresh;
        private Button btnTim;
    }
}
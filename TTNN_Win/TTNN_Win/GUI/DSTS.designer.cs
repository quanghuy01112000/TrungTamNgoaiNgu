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
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbxPhongThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKhoaThi = new System.Windows.Forms.ComboBox();
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
            this.dgvTS.Size = new System.Drawing.Size(665, 271);
            this.dgvTS.TabIndex = 0;
            this.dgvTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTS_CellContentClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(577, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(86, 20);
            this.txtTimKiem.TabIndex = 5;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(521, 45);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(50, 13);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(559, 357);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(111, 33);
            this.btnChiTiet.TabIndex = 8;
            this.btnChiTiet.Text = "Chi Tiết Thí Sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(434, 357);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 33);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // cbxPhongThi
            // 
            this.cbxPhongThi.FormattingEnabled = true;
            this.cbxPhongThi.Location = new System.Drawing.Point(204, 37);
            this.cbxPhongThi.Name = "cbxPhongThi";
            this.cbxPhongThi.Size = new System.Drawing.Size(104, 21);
            this.cbxPhongThi.TabIndex = 14;
            this.cbxPhongThi.SelectedIndexChanged += new System.EventHandler(this.cbxPhongThi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phòng Thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Khóa";
            // 
            // cbxKhoaThi
            // 
            this.cbxKhoaThi.FormattingEnabled = true;
            this.cbxKhoaThi.Location = new System.Drawing.Point(61, 34);
            this.cbxKhoaThi.Name = "cbxKhoaThi";
            this.cbxKhoaThi.Size = new System.Drawing.Size(44, 21);
            this.cbxKhoaThi.TabIndex = 18;
            this.cbxKhoaThi.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaThi_SelectedIndexChanged);
            // 
            // DSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 403);
            this.Controls.Add(this.cbxKhoaThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPhongThi);
            this.Controls.Add(this.btnThoat);
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
        private Button btnThoat;
        private ComboBox cbxPhongThi;
        private Label label2;
        private Label label1;
        private ComboBox cbxKhoaThi;
    }
}
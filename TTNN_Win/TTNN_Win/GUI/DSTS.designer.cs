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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbxPhongThi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(955, 81);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(113, 22);
            this.txtTimKiem.TabIndex = 5;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(873, 86);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(66, 17);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(860, 591);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(148, 41);
            this.btnChiTiet.TabIndex = 8;
            this.btnChiTiet.Text = "Chi Tiết Thí Sinh";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(693, 591);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 41);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(608, 81);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(753, 80);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(85, 25);
            this.btnSort.TabIndex = 12;
            this.btnSort.Text = "Sắp Xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            // 
            // cbxPhongThi
            // 
            this.cbxPhongThi.FormattingEnabled = true;
            this.cbxPhongThi.Location = new System.Drawing.Point(135, 80);
            this.cbxPhongThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPhongThi.Name = "cbxPhongThi";
            this.cbxPhongThi.Size = new System.Drawing.Size(137, 24);
            this.cbxPhongThi.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phòng Thi";
            // 
            // DSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxPhongThi);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DSTS";
            this.Text = "Danh Sách Thí Sinh";
            this.Load += new System.EventHandler(this.DSTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtTimKiem;
        private Label lblTimKiem;
        private Button btnChiTiet;
        private Button btnThoat;
        private ComboBox comboBox1;
        private Button btnSort;
        private ComboBox cbxPhongThi;
        private Label label2;
    }
}
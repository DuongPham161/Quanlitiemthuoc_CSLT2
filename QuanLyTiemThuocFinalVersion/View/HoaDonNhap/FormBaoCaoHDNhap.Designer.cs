namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap
{
    partial class FormBaoCaoHDNhap
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
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(528, 44);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(136, 35);
            this.btnXemBaoCao.TabIndex = 14;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
           
            // 
            // cbxThang
            // 
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbxThang.Location = new System.Drawing.Point(369, 51);
            this.cbxThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(126, 28);
            this.cbxThang.TabIndex = 13;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(259, 51);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(82, 29);
            this.lbThang.TabIndex = 15;
            this.lbThang.Text = "Tháng";
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(52, 143);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersWidth = 62;
            this.dgvHoaDonNhap.RowTemplate.Height = 28;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(831, 417);
            this.dgvHoaDonNhap.TabIndex = 16;
            // 
            // FormBaoCaoHDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 621);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.cbxThang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoHDNhap";
            this.Text = "Báo Cáo Hóa Đơn Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
    }
}
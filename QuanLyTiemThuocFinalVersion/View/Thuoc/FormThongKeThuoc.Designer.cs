namespace QuanLyTiemThuocFinalVersion.View.Thuoc
{
    partial class FormThongKeThuoc
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
            this.btnThuocHetHan = new System.Windows.Forms.Button();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.btnThongKeThuocConHan = new System.Windows.Forms.Button();
            this.lbTenThuoc = new System.Windows.Forms.Label();
            this.lbCongDungThuoc = new System.Windows.Forms.Label();
            this.lbThanhPhanThuoc = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tbTenThuoc = new System.Windows.Forms.TextBox();
            this.tbCongDung = new System.Windows.Forms.TextBox();
            this.tbThanhPhan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê thuốc";
            // 
            // btnThuocHetHan
            // 
            this.btnThuocHetHan.Location = new System.Drawing.Point(667, 176);
            this.btnThuocHetHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThuocHetHan.Name = "btnThuocHetHan";
            this.btnThuocHetHan.Size = new System.Drawing.Size(255, 55);
            this.btnThuocHetHan.TabIndex = 2;
            this.btnThuocHetHan.Text = "Thống Kê Thuốc Hết Hạn";
            this.btnThuocHetHan.UseVisualStyleBackColor = true;
            this.btnThuocHetHan.Click += new System.EventHandler(this.btnThuocHetHan_Click);
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(667, 47);
            this.btnHienTatCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(169, 53);
            this.btnHienTatCa.TabIndex = 5;
            this.btnHienTatCa.Text = "Hiện Tất Cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(23, 292);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersWidth = 62;
            this.dgvThuoc.Size = new System.Drawing.Size(1215, 425);
            this.dgvThuoc.TabIndex = 6;
            this.dgvThuoc.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvThuoc_CellBeginEdit);
            this.dgvThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellClick);
            this.dgvThuoc.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThuoc_CellEndEdit);
            // 
            // btnThongKeThuocConHan
            // 
            this.btnThongKeThuocConHan.Location = new System.Drawing.Point(667, 109);
            this.btnThongKeThuocConHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeThuocConHan.Name = "btnThongKeThuocConHan";
            this.btnThongKeThuocConHan.Size = new System.Drawing.Size(255, 57);
            this.btnThongKeThuocConHan.TabIndex = 7;
            this.btnThongKeThuocConHan.Text = "Thống Kê Thuốc Còn Hạn";
            this.btnThongKeThuocConHan.UseVisualStyleBackColor = true;
            this.btnThongKeThuocConHan.Click += new System.EventHandler(this.btnThongKeThuocConHan_Click);
            // 
            // lbTenThuoc
            // 
            this.lbTenThuoc.AutoSize = true;
            this.lbTenThuoc.Location = new System.Drawing.Point(88, 62);
            this.lbTenThuoc.Name = "lbTenThuoc";
            this.lbTenThuoc.Size = new System.Drawing.Size(84, 20);
            this.lbTenThuoc.TabIndex = 8;
            this.lbTenThuoc.Text = "Tên Thuốc";
            // 
            // lbCongDungThuoc
            // 
            this.lbCongDungThuoc.AutoSize = true;
            this.lbCongDungThuoc.Location = new System.Drawing.Point(88, 168);
            this.lbCongDungThuoc.Name = "lbCongDungThuoc";
            this.lbCongDungThuoc.Size = new System.Drawing.Size(90, 20);
            this.lbCongDungThuoc.TabIndex = 9;
            this.lbCongDungThuoc.Text = "Công Dụng";
            // 
            // lbThanhPhanThuoc
            // 
            this.lbThanhPhanThuoc.AutoSize = true;
            this.lbThanhPhanThuoc.Location = new System.Drawing.Point(88, 115);
            this.lbThanhPhanThuoc.Name = "lbThanhPhanThuoc";
            this.lbThanhPhanThuoc.Size = new System.Drawing.Size(94, 20);
            this.lbThanhPhanThuoc.TabIndex = 10;
            this.lbThanhPhanThuoc.Text = "Thành phần";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(92, 209);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 40);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tbTenThuoc
            // 
            this.tbTenThuoc.Location = new System.Drawing.Point(202, 62);
            this.tbTenThuoc.Name = "tbTenThuoc";
            this.tbTenThuoc.Size = new System.Drawing.Size(358, 26);
            this.tbTenThuoc.TabIndex = 12;
            // 
            // tbCongDung
            // 
            this.tbCongDung.Location = new System.Drawing.Point(202, 168);
            this.tbCongDung.Name = "tbCongDung";
            this.tbCongDung.Size = new System.Drawing.Size(358, 26);
            this.tbCongDung.TabIndex = 13;
            // 
            // tbThanhPhan
            // 
            this.tbThanhPhan.Location = new System.Drawing.Point(202, 115);
            this.tbThanhPhan.Name = "tbThanhPhan";
            this.tbThanhPhan.Size = new System.Drawing.Size(358, 26);
            this.tbThanhPhan.TabIndex = 14;
            // 
            // FormThongKeThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 709);
            this.Controls.Add(this.tbThanhPhan);
            this.Controls.Add(this.tbCongDung);
            this.Controls.Add(this.tbTenThuoc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lbThanhPhanThuoc);
            this.Controls.Add(this.lbCongDungThuoc);
            this.Controls.Add(this.lbTenThuoc);
            this.Controls.Add(this.btnThongKeThuocConHan);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.btnHienTatCa);
            this.Controls.Add(this.btnThuocHetHan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThongKeThuoc";
            this.Text = "FormThongKeThuoc";
            this.Load += new System.EventHandler(this.FormThongKeThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThuocHetHan;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Button btnThongKeThuocConHan;
        private System.Windows.Forms.Label lbTenThuoc;
        private System.Windows.Forms.Label lbCongDungThuoc;
        private System.Windows.Forms.Label lbThanhPhanThuoc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox tbTenThuoc;
        private System.Windows.Forms.TextBox tbCongDung;
        private System.Windows.Forms.TextBox tbThanhPhan;
    }
}
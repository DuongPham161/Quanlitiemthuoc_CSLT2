namespace QuanLyTiemThuocFinalVersion.View.TrangChu
{
    partial class FormTrangChu
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
            this.panelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.panelBanThuoc = new System.Windows.Forms.Panel();
            this.btnThongKeHoaDonBan = new System.Windows.Forms.Button();
            this.btnBanThuoc = new System.Windows.Forms.Button();
            this.lblBanThuoc = new System.Windows.Forms.Label();
            this.panelThuoc = new System.Windows.Forms.Panel();
            this.btnThongKeThuoc = new System.Windows.Forms.Button();
            this.lblQuanLyThuocTrongTiem = new System.Windows.Forms.Label();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.panelHoaDonNhap = new System.Windows.Forms.Panel();
            this.btnThongKeHoaDonNhap = new System.Windows.Forms.Button();
            this.lblHoaDonNhap = new System.Windows.Forms.Label();
            this.btnThemMoiHoaDonNhap = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            this.panelBanThuoc.SuspendLayout();
            this.panelThuoc.SuspendLayout();
            this.panelHoaDonNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.ColumnCount = 1;
            this.panelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelContainer.Controls.Add(this.panelBanThuoc, 0, 0);
            this.panelContainer.Controls.Add(this.panelThuoc, 0, 1);
            this.panelContainer.Controls.Add(this.panelHoaDonNhap, 0, 2);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.RowCount = 3;
            this.panelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelContainer.Size = new System.Drawing.Size(1206, 709);
            this.panelContainer.TabIndex = 0;
            // 
            // panelBanThuoc
            // 
            this.panelBanThuoc.Controls.Add(this.btnThongKeHoaDonBan);
            this.panelBanThuoc.Controls.Add(this.btnBanThuoc);
            this.panelBanThuoc.Controls.Add(this.lblBanThuoc);
            this.panelBanThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBanThuoc.Location = new System.Drawing.Point(4, 5);
            this.panelBanThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBanThuoc.Name = "panelBanThuoc";
            this.panelBanThuoc.Size = new System.Drawing.Size(1198, 226);
            this.panelBanThuoc.TabIndex = 0;
            // 
            // btnThongKeHoaDonBan
            // 
            this.btnThongKeHoaDonBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKeHoaDonBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeHoaDonBan.Location = new System.Drawing.Point(776, 77);
            this.btnThongKeHoaDonBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeHoaDonBan.Name = "btnThongKeHoaDonBan";
            this.btnThongKeHoaDonBan.Size = new System.Drawing.Size(219, 88);
            this.btnThongKeHoaDonBan.TabIndex = 2;
            this.btnThongKeHoaDonBan.Text = "Thống Kê Hóa Đơn Bán";
            this.btnThongKeHoaDonBan.UseVisualStyleBackColor = true;
            this.btnThongKeHoaDonBan.Click += new System.EventHandler(this.btnThongKeHoaDonBan_Click);
            // 
            // btnBanThuoc
            // 
            this.btnBanThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBanThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanThuoc.Location = new System.Drawing.Point(206, 77);
            this.btnBanThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBanThuoc.Name = "btnBanThuoc";
            this.btnBanThuoc.Size = new System.Drawing.Size(219, 88);
            this.btnBanThuoc.TabIndex = 1;
            this.btnBanThuoc.Text = "Bán Thuốc";
            this.btnBanThuoc.UseVisualStyleBackColor = true;
            this.btnBanThuoc.Click += new System.EventHandler(this.btnBanThuoc_Click);
            // 
            // lblBanThuoc
            // 
            this.lblBanThuoc.AutoSize = true;
            this.lblBanThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBanThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanThuoc.Location = new System.Drawing.Point(0, 0);
            this.lblBanThuoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBanThuoc.Name = "lblBanThuoc";
            this.lblBanThuoc.Size = new System.Drawing.Size(129, 29);
            this.lblBanThuoc.TabIndex = 0;
            this.lblBanThuoc.Text = "Bán Thuốc";
            // 
            // panelThuoc
            // 
            this.panelThuoc.Controls.Add(this.btnThongKeThuoc);
            this.panelThuoc.Controls.Add(this.lblQuanLyThuocTrongTiem);
            this.panelThuoc.Controls.Add(this.btnThemThuoc);
            this.panelThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThuoc.Location = new System.Drawing.Point(4, 241);
            this.panelThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelThuoc.Name = "panelThuoc";
            this.panelThuoc.Size = new System.Drawing.Size(1198, 226);
            this.panelThuoc.TabIndex = 1;
            // 
            // btnThongKeThuoc
            // 
            this.btnThongKeThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKeThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeThuoc.Location = new System.Drawing.Point(776, 92);
            this.btnThongKeThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeThuoc.Name = "btnThongKeThuoc";
            this.btnThongKeThuoc.Size = new System.Drawing.Size(219, 88);
            this.btnThongKeThuoc.TabIndex = 4;
            this.btnThongKeThuoc.Text = "Thống Kê";
            this.btnThongKeThuoc.UseVisualStyleBackColor = true;
            this.btnThongKeThuoc.Click += new System.EventHandler(this.btnThongKeThuoc_Click);
            // 
            // lblQuanLyThuocTrongTiem
            // 
            this.lblQuanLyThuocTrongTiem.AutoSize = true;
            this.lblQuanLyThuocTrongTiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuanLyThuocTrongTiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyThuocTrongTiem.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyThuocTrongTiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuanLyThuocTrongTiem.Name = "lblQuanLyThuocTrongTiem";
            this.lblQuanLyThuocTrongTiem.Size = new System.Drawing.Size(308, 29);
            this.lblQuanLyThuocTrongTiem.TabIndex = 1;
            this.lblQuanLyThuocTrongTiem.Text = "Quản Lý Thuốc Trong Tiệm";
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuoc.Location = new System.Drawing.Point(206, 92);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(219, 88);
            this.btnThemThuoc.TabIndex = 3;
            this.btnThemThuoc.Text = "Thêm Mới";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            // 
            // panelHoaDonNhap
            // 
            this.panelHoaDonNhap.Controls.Add(this.btnThongKeHoaDonNhap);
            this.panelHoaDonNhap.Controls.Add(this.lblHoaDonNhap);
            this.panelHoaDonNhap.Controls.Add(this.btnThemMoiHoaDonNhap);
            this.panelHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHoaDonNhap.Location = new System.Drawing.Point(4, 477);
            this.panelHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHoaDonNhap.Name = "panelHoaDonNhap";
            this.panelHoaDonNhap.Size = new System.Drawing.Size(1198, 227);
            this.panelHoaDonNhap.TabIndex = 2;
            // 
            // btnThongKeHoaDonNhap
            // 
            this.btnThongKeHoaDonNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThongKeHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeHoaDonNhap.Location = new System.Drawing.Point(776, 83);
            this.btnThongKeHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThongKeHoaDonNhap.Name = "btnThongKeHoaDonNhap";
            this.btnThongKeHoaDonNhap.Size = new System.Drawing.Size(219, 88);
            this.btnThongKeHoaDonNhap.TabIndex = 6;
            this.btnThongKeHoaDonNhap.Text = "Thống Kê";
            this.btnThongKeHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnThongKeHoaDonNhap.Click += new System.EventHandler(this.btnThongKeHoaDonNhap_Click);
            // 
            // lblHoaDonNhap
            // 
            this.lblHoaDonNhap.AutoSize = true;
            this.lblHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonNhap.Location = new System.Drawing.Point(0, 6);
            this.lblHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDonNhap.Name = "lblHoaDonNhap";
            this.lblHoaDonNhap.Size = new System.Drawing.Size(171, 29);
            this.lblHoaDonNhap.TabIndex = 0;
            this.lblHoaDonNhap.Text = "Hóa Đơn Nhập";
            // 
            // btnThemMoiHoaDonNhap
            // 
            this.btnThemMoiHoaDonNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThemMoiHoaDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoiHoaDonNhap.Location = new System.Drawing.Point(206, 83);
            this.btnThemMoiHoaDonNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMoiHoaDonNhap.Name = "btnThemMoiHoaDonNhap";
            this.btnThemMoiHoaDonNhap.Size = new System.Drawing.Size(219, 88);
            this.btnThemMoiHoaDonNhap.TabIndex = 5;
            this.btnThemMoiHoaDonNhap.Text = "Thêm Mới";
            this.btnThemMoiHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnThemMoiHoaDonNhap.Click += new System.EventHandler(this.btnThemMoiHoaDonNhap_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 709);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrangChu";
            this.Text = "formTrangChu";
            this.panelContainer.ResumeLayout(false);
            this.panelBanThuoc.ResumeLayout(false);
            this.panelBanThuoc.PerformLayout();
            this.panelThuoc.ResumeLayout(false);
            this.panelThuoc.PerformLayout();
            this.panelHoaDonNhap.ResumeLayout(false);
            this.panelHoaDonNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelContainer;
        private System.Windows.Forms.Panel panelBanThuoc;
        private System.Windows.Forms.Panel panelThuoc;
        private System.Windows.Forms.Panel panelHoaDonNhap;
        private System.Windows.Forms.Label lblBanThuoc;
        private System.Windows.Forms.Label lblQuanLyThuocTrongTiem;
        private System.Windows.Forms.Label lblHoaDonNhap;
        private System.Windows.Forms.Button btnBanThuoc;
        private System.Windows.Forms.Button btnThongKeHoaDonBan;
        private System.Windows.Forms.Button btnThongKeThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnThongKeHoaDonNhap;
        private System.Windows.Forms.Button btnThemMoiHoaDonNhap;
    }
}
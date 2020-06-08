namespace QuanLyTiemThuocFinalVersion
{
    partial class formMain
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
            this.menuContainer = new System.Windows.Forms.MenuStrip();
            this.menuBanThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBanThuocMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKeKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhapThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThemMoiHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTimKiemHoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoHĐNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThuocContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContainer
            // 
            this.menuContainer.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuContainer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanThuocContainer,
            this.menuNhapThuocContainer,
            this.menuThuocContainer});
            this.menuContainer.Location = new System.Drawing.Point(0, 0);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(1326, 33);
            this.menuContainer.TabIndex = 0;
            // 
            // menuBanThuocContainer
            // 
            this.menuBanThuocContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBanThuocMain,
            this.menuThongKeHoaDonBan,
            this.menuThongKeKhachHang});
            this.menuBanThuocContainer.Name = "menuBanThuocContainer";
            this.menuBanThuocContainer.Size = new System.Drawing.Size(110, 29);
            this.menuBanThuocContainer.Text = "Bán Thuốc";
            // 
            // menuBanThuocMain
            // 
            this.menuBanThuocMain.Name = "menuBanThuocMain";
            this.menuBanThuocMain.Size = new System.Drawing.Size(263, 34);
            this.menuBanThuocMain.Text = "Bán";
            this.menuBanThuocMain.Click += new System.EventHandler(this.menuBanThuocMain_Click);
            // 
            // menuThongKeHoaDonBan
            // 
            this.menuThongKeHoaDonBan.Name = "menuThongKeHoaDonBan";
            this.menuThongKeHoaDonBan.Size = new System.Drawing.Size(263, 34);
            this.menuThongKeHoaDonBan.Text = "Báo cáo HĐB";
            this.menuThongKeHoaDonBan.Click += new System.EventHandler(this.menuThongKeHoaDonBan_Click);
            // 
            // menuThongKeKhachHang
            // 
            this.menuThongKeKhachHang.Name = "menuThongKeKhachHang";
            this.menuThongKeKhachHang.Size = new System.Drawing.Size(263, 34);
            this.menuThongKeKhachHang.Text = "Báo cáo Nhân Viên";
            this.menuThongKeKhachHang.Click += new System.EventHandler(this.menuThongKeNhanVien_Click);
            // 
            // menuNhapThuocContainer
            // 
            this.menuNhapThuocContainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMoiHoaDonNhap,
            this.menuTimKiemHoaDonNhap,
            this.báoCáoHĐNhậpToolStripMenuItem});
            this.menuNhapThuocContainer.Name = "menuNhapThuocContainer";
            this.menuNhapThuocContainer.Size = new System.Drawing.Size(124, 29);
            this.menuNhapThuocContainer.Text = "Nhập Thuốc";
            // 
            // menuThemMoiHoaDonNhap
            // 
            this.menuThemMoiHoaDonNhap.Name = "menuThemMoiHoaDonNhap";
            this.menuThemMoiHoaDonNhap.Size = new System.Drawing.Size(270, 34);
            this.menuThemMoiHoaDonNhap.Text = "Nhập ";
            this.menuThemMoiHoaDonNhap.Click += new System.EventHandler(this.menuThemMoiHoaDonNhap_Click);
            // 
            // menuTimKiemHoaDonNhap
            // 
            this.menuTimKiemHoaDonNhap.Name = "menuTimKiemHoaDonNhap";
            this.menuTimKiemHoaDonNhap.Size = new System.Drawing.Size(270, 34);
            this.menuTimKiemHoaDonNhap.Text = "Tìm kiếm";
            this.menuTimKiemHoaDonNhap.Click += new System.EventHandler(this.menuTimKiemHoaDonNhap_Click);
            // 
            // báoCáoHĐNhậpToolStripMenuItem
            // 
            this.báoCáoHĐNhậpToolStripMenuItem.Name = "báoCáoHĐNhậpToolStripMenuItem";
            this.báoCáoHĐNhậpToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.báoCáoHĐNhậpToolStripMenuItem.Text = "Báo Cáo HĐ nhập";
            this.báoCáoHĐNhậpToolStripMenuItem.Click += new System.EventHandler(this.báoCáoHĐNhậpToolStripMenuItem_Click);
            // 
            // menuThuocContainer
            // 
            this.menuThuocContainer.Name = "menuThuocContainer";
            this.menuThuocContainer.Size = new System.Drawing.Size(76, 29);
            this.menuThuocContainer.Text = "Thuốc";
            this.menuThuocContainer.Click += new System.EventHandler(this.menuThuocContainer_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1326, 786);
            this.Controls.Add(this.menuContainer);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuContainer;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Cửa Hàng Bán Thuốc Tây";
            this.menuContainer.ResumeLayout(false);
            this.menuContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MenuStrip menuContainer;
        public System.Windows.Forms.ToolStripMenuItem menuBanThuocContainer;
        public System.Windows.Forms.ToolStripMenuItem menuBanThuocMain;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeHoaDonBan;
        public System.Windows.Forms.ToolStripMenuItem menuThongKeKhachHang;
        public System.Windows.Forms.ToolStripMenuItem menuNhapThuocContainer;
        public System.Windows.Forms.ToolStripMenuItem menuThemMoiHoaDonNhap;
        public System.Windows.Forms.ToolStripMenuItem menuTimKiemHoaDonNhap;
        public System.Windows.Forms.ToolStripMenuItem menuThuocContainer;
        private System.Windows.Forms.ToolStripMenuItem báoCáoHĐNhậpToolStripMenuItem;
    }
}


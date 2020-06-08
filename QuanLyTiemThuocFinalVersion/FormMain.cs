using QuanLyTiemThuocFinalVersion.View.HoaDonBan;
using QuanLyTiemThuocFinalVersion.View.HoaDonNhap;
using QuanLyTiemThuocFinalVersion.View.NhanVien;
using QuanLyTiemThuocFinalVersion.View.Thuoc;
using QuanLyTiemThuocFinalVersion.View.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void disposeAllMDIChildrenForms()
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Dispose();
            }
        }

        private void showFormInMDIContainer(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void menuBanThuocMain_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormBanThuoc"))
                {
                    disposeAllMDIChildrenForms();
                    FormBanThuoc formBanThuoc = new FormBanThuoc();
                    showFormInMDIContainer(formBanThuoc);
                }
            }
            else
            {
                FormBanThuoc formBanThuoc = new FormBanThuoc();
                showFormInMDIContainer(formBanThuoc);
            }
        }

        private void menuThongKeHoaDonBan_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThongKeHoaDonBan"))
                {
                    disposeAllMDIChildrenForms();
                    FormThongKeHoaDonBan formThongKeHoaDonBan = new FormThongKeHoaDonBan();
                    showFormInMDIContainer(formThongKeHoaDonBan);
                }
            }
            else
            {
                FormThongKeHoaDonBan formThongKeHoaDonBan = new FormThongKeHoaDonBan();
                showFormInMDIContainer(formThongKeHoaDonBan);
            }
        }

        private void menuThongKeKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void menuThemMoiHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThemMoiHoaDonNhap"))
                {
                    disposeAllMDIChildrenForms();
                    FormThemMoiHoaDonNhap formThemMoiHoaDonNhap = new FormThemMoiHoaDonNhap();
                    showFormInMDIContainer(formThemMoiHoaDonNhap);
                }
            }
            else
            {
                FormThemMoiHoaDonNhap formThemMoiHoaDonNhap = new FormThemMoiHoaDonNhap();
                showFormInMDIContainer(formThemMoiHoaDonNhap);
            }

        }

        private void menuThongKeHoaDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void menuThongKeThuoc_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThongKeThuoc"))
                {
                    disposeAllMDIChildrenForms();
                    FormThongKeThuoc formThongKeThuoc = new FormThongKeThuoc();
                    showFormInMDIContainer(formThongKeThuoc);
                }
            }
            else
            {
                FormThongKeThuoc formThongKeThuoc = new FormThongKeThuoc();
                showFormInMDIContainer(formThongKeThuoc);
            }
        }

        private void menuThemMoiNhanVien_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThemMoiNhanVien"))
                {
                    disposeAllMDIChildrenForms();
                    FormThemMoiNhanVien formThemMoiNhanVien = new FormThemMoiNhanVien();
                    showFormInMDIContainer(formThemMoiNhanVien);
                }
            }
            else
            {
                FormThemMoiNhanVien formThemMoiNhanVien = new FormThemMoiNhanVien();
                showFormInMDIContainer(formThemMoiNhanVien);
            }

        }

        private void menuThongKeNhanVien_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormBaoCaoNhanVien"))
                {
                    disposeAllMDIChildrenForms();
                    FormBaoCaoNhanVien formThongKeNhanVien = new FormBaoCaoNhanVien();
                    showFormInMDIContainer(formThongKeNhanVien);
                }
            }
            else
            {
                FormBaoCaoNhanVien formThongKeNhanVien = new FormBaoCaoNhanVien();
                showFormInMDIContainer(formThongKeNhanVien);
            }

        }

        private void menuTrangChu_Click(object sender, EventArgs e)
        {
            disposeAllMDIChildrenForms();
        }

        private void menuTimKiemHoaDonNhap_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThongKeHoaDonNhap"))
                {
                    disposeAllMDIChildrenForms();
                    FormThongKeHoaDonNhap formThongKeNhanVien = new FormThongKeHoaDonNhap();
                    showFormInMDIContainer(formThongKeNhanVien);
                }
            }
            else
            {
                FormThongKeHoaDonNhap formThongKeNhanVien = new FormThongKeHoaDonNhap();
                showFormInMDIContainer(formThongKeNhanVien);
            }
        }

        private void báoCáoHĐNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormBaoCaoHDNhap"))
                {
                    disposeAllMDIChildrenForms();
                    FormBaoCaoHDNhap formThongKeNhanVien = new FormBaoCaoHDNhap();
                    showFormInMDIContainer(formThongKeNhanVien);
                }
            }
            else
            {
                FormBaoCaoHDNhap formThongKeNhanVien = new FormBaoCaoHDNhap();
                showFormInMDIContainer(formThongKeNhanVien);
            }
        }

        private void menuThuocContainer_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                if (!this.MdiChildren[0].Name.Equals("FormThongKeThuoc"))
                {
                    disposeAllMDIChildrenForms();
                    FormThongKeThuoc formThongKeNhanVien = new FormThongKeThuoc();
                    showFormInMDIContainer(formThongKeNhanVien);
                }
            }
            else
            {
                FormThongKeThuoc formThongKeNhanVien = new FormThongKeThuoc();
                showFormInMDIContainer(formThongKeNhanVien);
            }
        }
    }
}

using QuanLyTiemThuocFinalVersion.View.HoaDonBan;
using QuanLyTiemThuocFinalVersion.View.HoaDonNhap;
using QuanLyTiemThuocFinalVersion.View.Thuoc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.View.TrangChu
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
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
            form.MdiParent = this.MdiParent;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnBanThuoc_Click(object sender, EventArgs e)
        {
            FormBanThuoc formBanThuoc = new FormBanThuoc();
            showFormInMDIContainer(formBanThuoc);
            this.FindForm().Dispose();
        }

        private void btnThongKeHoaDonBan_Click(object sender, EventArgs e)
        {
            FormThongKeHoaDonBan formThongKeHoaDonBan = new FormThongKeHoaDonBan();
            showFormInMDIContainer(formThongKeHoaDonBan);
            this.FindForm().Dispose();
        }

        private void btnThongKeThuoc_Click(object sender, EventArgs e)
        {
            FormThongKeThuoc formThongKeThuoc = new FormThongKeThuoc();
            showFormInMDIContainer(formThongKeThuoc);
            this.FindForm().Dispose();
        }

        private void btnThemMoiHoaDonNhap_Click(object sender, EventArgs e)
        {
            FormThemMoiHoaDonNhap formThemMoiHoaDonNhap = new FormThemMoiHoaDonNhap();
            showFormInMDIContainer(formThemMoiHoaDonNhap);
            this.FindForm().Dispose();
        }

        private void btnThongKeHoaDonNhap_Click(object sender, EventArgs e)
        {
            FormThongKeHoaDonNhap formThongKeHoaDonNhap = new FormThongKeHoaDonNhap();
            showFormInMDIContainer(formThongKeHoaDonNhap);
            this.FindForm().Dispose();
        }
    }
}

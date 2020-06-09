using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Utility;

namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap
{
    public partial class FormBaoCaoHDNhap : Form
    {
        public FormBaoCaoHDNhap()
        {
            InitializeComponent();
        }

        private void cbxThang_Leave(object sender, EventArgs e)
        {

        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            string thang = TienIch.XoaTatCaKhoangTrang(cbxThang.Text);
            if (string.IsNullOrEmpty(thang))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Không được để trống tháng");
                cbxThang.SelectedIndex = 1;
            }
            else
            {
                if (thang.All(char.IsDigit))
                {
                    string sqlCommand = "Select hdn.Id, nv.Ten, ncc.Ten, hdn.NgayNhap, hdn.TongTien "
                        + " from HoaDonNhap hdn, NhanVien nv, NhaCungCap ncc " +
                        " where hdn.IdNhanVien=nv.Id and hdn.IdNhaCungCap=ncc.Id " +
                        " and MONTH(hdn.NgayNhap)=" + thang;
                    DataTable tbl = DataBaseFunction.GetDataToTable(sqlCommand);
                    dgvHoaDonNhap.DataSource = null;

                    dgvHoaDonNhap.DataSource = tbl;
                    dgvHoaDonNhap.MultiSelect = false;

                    foreach (DataGridViewColumn col in dgvHoaDonNhap.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        col.ReadOnly = true;
                    }

                    dgvHoaDonNhap.Columns[0].HeaderText = "Mã Hóa Đơn";
                    dgvHoaDonNhap.Columns[1].HeaderText = "Nhân Viên";
                    dgvHoaDonNhap.Columns[2].HeaderText = "Nhà Cung Cấp";
                    dgvHoaDonNhap.Columns[3].HeaderText = "Ngày Nhập";
                    dgvHoaDonNhap.Columns[4].HeaderText = "Tổng Tiền";

                    foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                    {
                        if (row.Cells[3].Value != null)
                        {
                            row.Cells[3].Value = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("dd - MM - yyyy");
                        }
                    }

                }
                else
                {
                    cbxThang.SelectedIndex = 1;
                    TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng chọn tháng từ 1 tới 12.");
                }
            }
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.View.NhanVien
{
    public partial class FormThongKeNhanVien : Form
    {
        public FormThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void cbxMonthFrom_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxMonthFrom.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxMonthFrom.SelectedIndex = 1;
            }
            else
            {
                if (cbxMonthFrom.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn tháng từ 1 tới 12");
                }
            }
        }

        private void cbxMonthTo_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxMonthTo.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxMonthTo.SelectedIndex = 1;
            }
            else
            {
                if (cbxMonthTo.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn tháng từ 1 tới 12");
                }
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void ThongKeNhanVien(int monthFrom, int monthTo)
        {
            string sqlSelect = "select distinct top 2 h.IdNhanVien, (select nv.Ten from NhanVien nv where nv.Id=h.IdNhanVien) as 'Họ Và Tên', " +
                " (select sum(h2.TongTien) from HoaDonBan h2 where h2.IdNhanVien = h.IdNhanVien and MONTH(h2.NgayBan) >= " + monthFrom + " and MONTH(h2.NgayBan)<= " + monthTo + " ) as 'Tổng Tiền' " +
                " from HoaDonBan h " +
                " where MONTH(h.NgayBan) >= " + monthFrom + " and MONTH(h.NgayBan)<= " + monthTo + " " +
                " order by[Tổng Tiền]";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThongKeNhanVien.DataSource = tbl;
            dgvThongKeNhanVien.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvThongKeNhanVien.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvThongKeNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvThongKeNhanVien.Columns[1].HeaderText = "Họ Và Tên";
            dgvThongKeNhanVien.Columns[2].HeaderText = "Tổng Tiền";

        }

        private void FormThongKeNhanVien_Load(object sender, EventArgs e)
        {
            cbxMonthFrom.SelectedIndex = 0;
            cbxMonthTo.SelectedIndex = 4;
        }
    }
}

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

namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    public partial class FormBaoCaoNhanVien : Form
    {
        public FormBaoCaoNhanVien()
        {
            InitializeComponent();
            cbxQuy.SelectedIndex = 0;
        }

        private void btnThongKe_Click(object sender, EventArgs e) // khi ân vào nút thông kê s
        {
            int cbxQuyValue = Int32.Parse(cbxQuy.Text);
            int yearValue = Int32.Parse(dtpNam.Text);

            ThongKeNhanVien(cbxQuyValue, yearValue);
        }

        private void ThongKeNhanVien(int cbxQuyValue, int yearValue)
        {
            int monthFrom = 1;
            int monthTo = 4;

            if (cbxQuyValue == 2)
            {
                monthFrom = 5;
                monthTo = 8;
            }
            else if (cbxQuyValue == 3)
            {
                monthFrom = 9;
                monthTo = 12;
            }

            string sqlSelect = "select distinct top 2 h.IdNhanVien, (select nv.Ten from NhanVien nv where nv.Id=h.IdNhanVien) as 'Họ Và Tên', " +
                " (select sum(h2.TongTien) " +
                "from HoaDonBan h2 where h2.IdNhanVien = h.IdNhanVien " +
                "and MONTH(h2.NgayBan) >= " + monthFrom + " and MONTH(h2.NgayBan)<= " + monthTo + " and YEAR(h2.NgayBan)=" + yearValue + " ) as 'Tổng Tiền' " +
                " from HoaDonBan h " +
                " where MONTH(h.NgayBan) >= " + monthFrom + " and MONTH(h.NgayBan)<= " + monthTo + " and YEAR(h.NgayBan)=" + yearValue + " " +
                " order by[Tổng Tiền]";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvNhanVien.DataSource = tbl;
            dgvNhanVien.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Họ Và Tên";
            dgvNhanVien.Columns[2].HeaderText = "Tổng Tiền";

        }
    }
}

using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    public partial class FormThongKeHoaDonBan : Form
    {
        public FormThongKeHoaDonBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlSelect = "select top 5 h.Id, " +
                " (select nv.Ten from NhanVien nv where nv.Id = h.IdNhanVien), " +
                " (select k.Ten from KhachHang k where k.Id = h.IdKhach), " +
                " h.NgayBan, h.TongTien " +
                " from HoaDonBan h where Year(h.NgayBan) ='" + dateTimePicker1.Text + "' order by h.TongTien ";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvHoaDonBan.DataSource = null;
            dgvHoaDonBan.DataSource = tbl;
            dgvHoaDonBan.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvHoaDonBan.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }

            dgvHoaDonBan.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvHoaDonBan.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvHoaDonBan.Columns[2].HeaderText = "Tên Khách Hàng";
            dgvHoaDonBan.Columns[3].HeaderText = "Ngày Bán";
            dgvHoaDonBan.Columns[4].HeaderText = "Tổng Tiền";
        }

        private void dgvHoaDonBan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel
                = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dgvHoaDonBan.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = dgvHoaDonBan.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvHoaDonBan.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHoaDonBan.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dgvHoaDonBan.Rows[i].Cells[j].Value.ToString();
                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
            excel.DisplayFullScreen = true;

            dgvHoaDonBan.DataSource = null;
        }
    }
}

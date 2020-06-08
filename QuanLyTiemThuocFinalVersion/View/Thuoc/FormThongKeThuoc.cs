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

namespace QuanLyTiemThuocFinalVersion.View.Thuoc
{
    public partial class FormThongKeThuoc : Form
    {
        public FormThongKeThuoc()
        {
            InitializeComponent();
        }

        private void FormThongKeThuoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void cbxThuoc_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(tbTenThuoc.Text));
            tbTenThuoc.Text = cbxValue;
        }
        private void tbThanhPhan_Leave(object sender, EventArgs e)
        {
            string thanhPhan = TienIch.ToUpperFistCharacter(tbThanhPhan.Text);
            tbThanhPhan.Text = thanhPhan;
        }

        private void cbxCongDung_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(tbCongDung.Text)).ToLower();
            tbCongDung.Text = cbxValue;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tableName = " Thuoc t";
            string whereCongDung = "";
            string whereThuoc = "";
            string whereThanhPhan = "";

            string tenThuoc = TienIch.ToTitleCase(tbTenThuoc.Text);

            string thanhPhan = TienIch.XoaKhoangTrang(tbThanhPhan.Text).ToLower();

            //xem có tra theo tên thuốc hay không
            if (!string.IsNullOrEmpty(tenThuoc))
            {
                whereThuoc = " and t.Ten like N'%" +  tenThuoc + "%'";
            }

            //xem có tra theo công dụng hay không
            if (!string.IsNullOrEmpty(TienIch.XoaKhoangTrang(tbCongDung.Text)))
            {
                string sqlSelectId = "Select Id from CongDung where Ten=N'" + TienIch.XoaKhoangTrang(tbCongDung.Text) + "'";
                whereCongDung = "and t.id in( select IdThuoc from ThuocCongDung tvcd where " + " tvcd.IdCongDung=" + sqlSelectId + ")";
            }

            //xem có tra theo thành phần hay không
            if (!string.IsNullOrEmpty(thanhPhan))
            {
                char[] delimiterChars = { ',' };
                string[] thanhPhanItems = thanhPhan.Split(delimiterChars);

                whereThanhPhan = " and t.Id in( select Id from Thuoc where " + " ThanhPhan like N'%" + thanhPhanItems[0] + "%'";
                string whereThanhPhanItem = "";
                foreach (string item in thanhPhanItems.Skip(1))
                {
                    whereThanhPhanItem += (" and ThanhPhan like N'%" + item + "%' ");
                }
                whereThanhPhan = whereThanhPhan + whereThanhPhanItem + ")";
            }

            if (string.IsNullOrEmpty(whereCongDung) && string.IsNullOrEmpty(whereThanhPhan) && string.IsNullOrEmpty(whereThuoc))
            {
                dgvThuoc.DataSource = null;
            }
            else
            {
                string sqlSelect = "select t.Id, t.Ten, " +
                    " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                    " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                    " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                    " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                    " from " + tableName +
                    " where 1=1 " +
                    whereThuoc + " " + whereCongDung + " " + whereThanhPhan;

                DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
                dgvThuoc.DataSource = tbl;
                //Cho người dùng thêm dữ liệu trực tiếp
                dgvThuoc.AllowUserToAddRows = false;
                dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

                dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
                dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
                dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
                dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
                dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
                dgvThuoc.Columns[5].HeaderText = "Thành Phần";
                dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
                dgvThuoc.Columns[7].HeaderText = "Giá Bán";
                dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
                dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
                dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
                dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

                foreach (DataGridViewColumn col in dgvThuoc.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    col.ReadOnly = true;
                }
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            LoadDataToGridView();
        }

        private void dgvThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvThuoc.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvThuoc_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvThuoc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadDataToGridView()
        {
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t ";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //Khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }

        private void btnThuocHetHan_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t " +
                " where 1=1 and t.HanSuDung<GetDate()";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }

        private void btnThongKeThuocConHan_Click(object sender, EventArgs e)
        {
            dgvThuoc.DataSource = null;
            string sqlSelect = "select t.Id, t.Ten, " +
                " (select dvt.Ten from DonViTinh dvt where dvt.Id = t.IdDonViTinh) as 'Đơn Vị Tính', " +
                " (select ddc.Ten from DangDieuChe ddc where ddc.Id = t.IdDangDieuChe) as 'Dạng Điều Chế',  " +
                " (select nsx.Ten from NuocSanXuat nsx where nsx.Id = t.IdNuocSanXuat) as 'Nước Sản Xuất', " +
                " t.ThanhPhan, t.DonGiaNhap, t.GiaBan, t.SoLuongHienCo, t.NgaySanXuat, t.HanSuDung, t.ChongChiDinh " +
                " from Thuoc t " +
                " where 1=1 and t.HanSuDung>=GetDate()";

            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            dgvThuoc.DataSource = tbl;
            //khong Cho người dùng thêm dữ liệu trực tiếp
            dgvThuoc.AllowUserToAddRows = false;
            dgvThuoc.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvThuoc.Columns[0].HeaderText = "Mã Thuốc";
            dgvThuoc.Columns[1].HeaderText = "Tên Thuốc";
            dgvThuoc.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvThuoc.Columns[3].HeaderText = "Dạng Điều Chế";
            dgvThuoc.Columns[4].HeaderText = "Nước Sản Xuất";
            dgvThuoc.Columns[5].HeaderText = "Thành Phần";
            dgvThuoc.Columns[6].HeaderText = "Đơn Giá Nhập";
            dgvThuoc.Columns[7].HeaderText = "Giá Bán";
            dgvThuoc.Columns[8].HeaderText = "Số Lượng Hiện Có";
            dgvThuoc.Columns[9].HeaderText = "Ngày Sản Xuất";
            dgvThuoc.Columns[10].HeaderText = "Hạn Sử Dụng";
            dgvThuoc.Columns[11].HeaderText = "Chống Chỉ Định";

            foreach (DataGridViewColumn col in dgvThuoc.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }
    }
}

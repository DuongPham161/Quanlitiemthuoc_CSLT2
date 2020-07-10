using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Utility;

namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap
{
    public partial class FormThongKeHoaDonNhap : Form
    {
        public FormThongKeHoaDonNhap()
        {
            InitializeComponent();

            LoadDataToCbxHoaDonNhap(); //load data o combobox
            LoadDataToCbxNhaCungCap();
            LoadDataToCbxNhanVien();
        }

        private void btnXemTatCa_Click(object sender, EventArgs e)
        {
            dgvHoaDonNhap.DataSource = null;
            LoadDataToTable();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHoaDonNhap = TienIch.XoaTatCaKhoangTrang(cbxHoaDonNhap.Text);
            string maNhanVien = TienIch.ToTitleCase(cbxNhanVien.Text);
            string maNhaCungCap = TienIch.ToTitleCase(cbxNhaCungCap.Text);

            if (string.IsNullOrEmpty(maHoaDonNhap) && string.IsNullOrEmpty(maNhanVien) && string.IsNullOrEmpty(maNhaCungCap))
            {
                dgvHoaDonNhap.DataSource = null;
            }
            else
            {
                string whereMaHoaDonNhap = string.IsNullOrEmpty(maHoaDonNhap) == true ? "" : " and hdn.Id = " + 
                    cbxHoaDonNhap.SelectedValue.ToString() + " "; 
                string whereNhanVien = string.IsNullOrEmpty(maNhanVien) == true ? "" : " and hdn.IdNhanVien = " + 
                    cbxNhanVien.SelectedValue.ToString() + " ";
                string whereNhaCungCap = string.IsNullOrEmpty(maNhaCungCap) == true ? "" : " and hdn.IdNhaCungCap = " + 
                    cbxNhaCungCap.SelectedValue.ToString() + " ";

                string sqlSearch = "Select hdn.Id, " +
                    " (select nv.Ten From NhanVien nv where nv.Id = hdn.IdNhanVien) as 'Tên Nhân Viên', " +
                    " (select ncc.Ten From NhaCungCap ncc where ncc.Id = hdn.IdNhaCungCap) as 'Tên Nhà Cung Cấp',  " +
                    " hdn.NgayNhap, hdn.TongTien " +
                    " from HoaDonNhap hdn where 1 = 1  " + whereMaHoaDonNhap + whereNhaCungCap + whereNhanVien;

                DataTable tbl = DataBaseFunction.GetDataToTable(sqlSearch);
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
                    row.Cells[3].Value = DateTime.Parse(row.Cells[3].Value.ToString()).ToString("dd - MM - yyyy");
                }
            }
        }


        private void LoadDataToTable()
        {
            string sqlCommand = "Select hdn.Id, nv.Ten, ncc.Ten, hdn.NgayNhap, hdn.TongTien from HoaDonNhap hdn, NhanVien nv, NhaCungCap ncc where hdn.IdNhanVien=nv.Id and hdn.IdNhaCungCap=ncc.Id";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlCommand);

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
        }


        private void LoadDataToCbxHoaDonNhap()
        {
            cbxHoaDonNhap.DataSource = null;
            string sqlSelect = "Select Id from HoaDonNhap";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxHoaDonNhap.DataSource = tbl;
            cbxHoaDonNhap.DisplayMember = "Id"; //phan dât show ra ngoai
            cbxHoaDonNhap.ValueMember = "Id"; // phan gia tri của bản ghi đó
            cbxHoaDonNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxHoaDonNhap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNhanVien()
        {
            string sqlSelect = "Select Id, Ten from NhanVien";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxNhanVien.DataSource = tbl;
            cbxNhanVien.DisplayMember = "Ten"; //gia su nhu cai nay // phần data show ra ngoài là tên của nhân viên
            cbxNhanVien.ValueMember = "Id"; // user chọn 1 cái tên nào đó thì mình lấy được giá trị id tương ứng của nó 
            cbxNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNhaCungCap()
        {
            string sqlSelect = "Select Id, Ten from NhaCungCap";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxNhaCungCap.DataSource = tbl;
            cbxNhaCungCap.DisplayMember = "Ten";
            cbxNhaCungCap.ValueMember = "Id";
            cbxNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHoaDon = dgvHoaDonNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
            string sqlSelect = "Select h.Id as 'Mã Bản Ghi',  h.IdHoaDonNhap as 'Mã Hóa Đơn Nhập', " +
                " t.Ten as 'Tên Thuốc', " +
                " h.SoLuongNhap as 'Số Lượng Nhập', h.DonGia as 'Đơn Giá', h.KhuyenMai as 'Khuyến Mại', " +
                " h.ThanhTien as 'Thành Tiền' " +
                " from HoaDonNhapDetail h " +
                " join Thuoc t " +
                " on t.Id = h.IdThuoc " +
                " where IdHoaDonNhap = " + maHoaDon;
            DataTable tableChiTietHoaDonNhap = DataBaseFunction.GetDataToTable(sqlSelect);

            dgvHoaDonNhap.DataSource = tableChiTietHoaDonNhap;

            Microsoft.Office.Interop.Excel.Application excel
                = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(Type.Missing);

            for (int i = 1; i < dgvHoaDonNhap.Columns.Count + 1; i++)
            {
                excel.Cells[1, i] = dgvHoaDonNhap.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgvHoaDonNhap.Rows.Count; i++)
            {
                for (int j = 0; j < dgvHoaDonNhap.Columns.Count; j++)
                {
                    excel.Cells[i + 2, j + 1] = dgvHoaDonNhap.Rows[i].Cells[j].Value.ToString();
                }
            }
            excel.Columns.AutoFit();
            excel.Visible = true;
            excel.DisplayFullScreen = true;

            dgvHoaDonNhap.DataSource = null;
            LoadDataToTable();
        }
    }
}

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
        }

        
        private void LoadDataToCbxHoaDonNhap()
        {
            cbxHoaDonNhap.DataSource = null;
            string sqlSelect = "Select Id from HoaDonNhap";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxHoaDonNhap.DataSource = tbl;
            cbxHoaDonNhap.DisplayMember = "Id";
            cbxHoaDonNhap.ValueMember = "Id";
            cbxHoaDonNhap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxHoaDonNhap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxNhanVien()
        {
            string sqlSelect = "Select Id, Ten from NhanVien";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelect);
            cbxNhanVien.DataSource = tbl;
            cbxNhanVien.DisplayMember = "Ten";
            cbxNhanVien.ValueMember = "Id";
            cbxNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
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

        private DataTable MakeTableWithAutoIncrement()
        {
            // Make a table with one AutoIncrement column.
            DataTable table = new DataTable("tblHoaDonNhap");

            DataColumn col1 = new DataColumn("Mã Hóa Đơn",
                Type.GetType("System.Int32"));
            table.Columns.Add(col1);

            DataColumn col2 = new DataColumn("Nhân Viên",
                Type.GetType("System.string"));
            table.Columns.Add(col2);

            DataColumn col3 = new DataColumn("Nhà Cung Cấp",
                Type.GetType("System.string"));
            table.Columns.Add(col3);

            DataColumn col4 = new DataColumn("Ngày Nhập",
                Type.GetType("System.DateTime"));
            table.Columns.Add(col4);

            DataColumn col5 = new DataColumn("Tổng Tiền",
                Type.GetType("System.Single"));
            table.Columns.Add(col5);
            return table;
        }

           }
}

using QuanLyTiemThuocFinalVersion.Controller.DataAccess;
using QuanLyTiemThuocFinalVersion.Model.Entity;
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

namespace QuanLyTiemThuocFinalVersion.View.HoaDonNhap
{
    public partial class FormThemMoiHoaDonNhap : Form
    {
        public FormThemMoiHoaDonNhap()
        {
            InitializeComponent();
        }
        private void FormThemMoiHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadDataToCbxTenThuoc();
            LoadDataToCbxNhaCungCap();
            LoadDataToCbxNhanVien();

            InitDateTimePicker();
            InitDataGridView();
            tvDonGia.Text = "0";
            tbKhuyenMai.Text = "0";
            tvSoLuongNhap.Text = "0";
        }

        private void cbxTenThuoc_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxTenThuoc.Text);
            cbxTenThuoc.Text = cbxValue;
        }

        private void cbxNhaCungCap_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(cbxNhaCungCap.Text);
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo", "Không được để trống thông tin này!\nCó thể gõ mới nhà cung cấp nếu nhà cung cấp bạn cần không có ở đây");
                cbxNhaCungCap.SelectedIndex = 0;
            }
            else
            {
                if (cbxNhaCungCap.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Nhà Cung Cấp mới chưa có trong csdl\n Bạn Có muốn thêm mới Nhà Cung Cấp này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertTrinhDo = "Insert into NhaCungCap (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertTrinhDo);
                        LoadDataToCbxNhaCungCap();
                        cbxNhaCungCap.SelectedIndex = cbxNhaCungCap.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxNhaCungCap.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô nhà cung cấp đã bị xóa do bạn không muốn thêm mới Nhà Cung Cấp này vào hệ thống.");
                    }
                }
            }
        }

        private void tvSoLuongNhap_Leave(object sender, EventArgs e)
        {
            tvSoLuongNhap.Text = TienIch.XoaTatCaKhoangTrang(tvSoLuongNhap.Text);

            //validate luôn >=0
            string soLuongNhap = TienIch.XoaTatCaKhoangTrang(tvSoLuongNhap.Text);
            if (soLuongNhap.All(char.IsDigit))
            {
                int soLuong;
                if (Int32.TryParse(soLuongNhap, out soLuong))
                {
                    if (soLuong <= 0)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Nhập phải là số tự nhiên lớn hơn 0");
                        tvSoLuongNhap.Focus();
                        tvSoLuongNhap.SelectionLength = tvSoLuongNhap.Text.Length;
                    }
                    else
                    {
                        tvSoLuongNhap.Text = soLuong.ToString();
                    }
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Nhập phải là số tự nhiên lớn hơn 0");
                tvSoLuongNhap.Focus();
                tvSoLuongNhap.SelectionLength = tvSoLuongNhap.Text.Length;
            }
        }

        private void tvDonGia_Leave(object sender, EventArgs e)
        {
            string donGiaValue = TienIch.XoaTatCaKhoangTrang(tvDonGia.Text);
            if (donGiaValue.All(char.IsDigit))
            {
                int soLuong;
                if (Int32.TryParse(donGiaValue, out soLuong))
                {
                    if (soLuong < 0)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Đơn Giá Nhập phải là số tự nhiên lớn hơn hoặc bằng 0");
                        tvDonGia.Focus();
                        tvDonGia.SelectionLength = tvDonGia.Text.Length;
                    }
                    else
                    {
                        tvDonGia.Text = soLuong.ToString();
                    }
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Đơn Giá Nhập phải là số tự nhiên lớn hơn hoặc bằng 0");
                tvDonGia.Focus();
                tvDonGia.SelectionLength = tvDonGia.Text.Length;
            }
        }

        private void tbKhuyenMai_Leave(object sender, EventArgs e)
        {
            string khuyenMai = TienIch.XoaTatCaKhoangTrang(tbKhuyenMai.Text);

            if (string.IsNullOrEmpty(khuyenMai))
            {
                tbKhuyenMai.Text = "0";
            }
            else
            {
                float khuyenMaiValue;
                if (float.TryParse(khuyenMai, out khuyenMaiValue))
                {
                    if (khuyenMaiValue <= 0 || khuyenMaiValue >= 100)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng nhập vào giá trị hợp lệ( nhỏ hơn 100 và lớn hoặc bằng 0)");
                    }
                    else
                    {
                        tbKhuyenMai.Text = khuyenMaiValue.ToString();
                    }
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng nhập vào giá trị hợp lệ( nhỏ hơn 100 và lớn hoặc bằng 0)");
                }
            }
        }

        private void dtpNgayNhap_Leave(object sender, EventArgs e)
        {
            DateTime ngaySanXuat = dtpNgaySanXuat.Value;
            DateTime ngayNhap = dtpNgaySanXuat.Value;

            if (ngaySanXuat > ngayNhap)
            {
                TienIch.ShowCanhBao("Cảnh báo", "Vui lòng kiểm tra lại ngày sản xuất của thuốc");
                dtpNgayNhap.Focus();
            }
            else
            {

            }
        }

        private void dtpNgaySanXuat_Leave(object sender, EventArgs e)
        {
            DateTime ngaySanXuat = dtpNgaySanXuat.Value;
            DateTime ngayNhap = dtpNgaySanXuat.Value;

            if (ngaySanXuat > ngayNhap)
            {
                TienIch.ShowCanhBao("Cảnh báo", "Vui lòng kiểm tra lại ngày sản xuất của thuốc");
                dtpNgaySanXuat.Focus();
            }
            else
            {

            }
        }

        private void dtpHanSuDung_Leave(object sender, EventArgs e)
        {
            DateTime hanSuDung = dtpHanSuDung.Value;
            DateTime ngaySanXuat = dtpNgaySanXuat.Value;
            if (hanSuDung <= ngaySanXuat)
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng kiểm tra lại hạn sử dụng của thuốc");
                dtpHanSuDung.Focus();
            }
            else
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cbxNhaCungCap.Enabled = false;
            dtpNgayNhap.Enabled = false;
            string tenThuoc = TienIch.ToTitleCase(cbxTenThuoc.Text);

            if (string.IsNullOrEmpty(tenThuoc))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Phải nhập tên thuốc.");
                cbxTenThuoc.Text = tenThuoc;
                cbxTenThuoc.Focus();
                cbxNhaCungCap.Enabled = true;
                dtpNgayNhap.Enabled = true;
            }
            else
            {
                int flagFoundIndex = -1;

                //kiem tra trong bang da co thuoc nay chua
                foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(tenThuoc))
                    {
                        flagFoundIndex = row.Index;
                        break;
                    }
                }

                //loai thuoc nay da co trong bang
                if (flagFoundIndex != -1)
                {
                    //hoi nguoi dung muon thay the thong tin cu trong bang hay cap nhat thong tin moi
                    DialogResult result = MessageBox.Show("Tên Thuốc " + tenThuoc + " đã tồn tại trong bảng!\n"
                        + "Chọn [Yes] để cập nhật thông tin cho bản ghi thuốc hiện có trong bảng(số lượng nhập, nhà cung cấp, ngày nhập sẽ được cập nhật).\n"
                        + "Chọn [No] để thay thế bản ghi hiện có trong bảng.\n"
                        + "Chọn [Cancel] để hủy.", "Cảnh Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    int soLuongNhap_moi = Int32.Parse(tvSoLuongNhap.Text);

                    if (result == DialogResult.Yes)
                    {
                        int soLuongNhap_cu = Int32.Parse(dgvHoaDonNhap.Rows[flagFoundIndex].Cells[1].Value.ToString());
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[1].Value = (soLuongNhap_cu + soLuongNhap_moi).ToString();
                        foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                        {
                            row.Cells[4].Value = cbxNhaCungCap.Text;
                            row.Cells[5].Value = dtpNgayNhap.Value.ToString("dd - MM - yyyy");
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[1].Value = soLuongNhap_moi;
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[2].Value = tvDonGia.Text;
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[3].Value = tbKhuyenMai.Text;
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[4].Value = cbxNhaCungCap.Text;
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[5].Value = dtpNgayNhap.Value.ToString("dd - MM - yyyy");
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[6].Value = dtpNgaySanXuat.Value.ToString("dd - MM - yyyy");
                        dgvHoaDonNhap.Rows[flagFoundIndex].Cells[7].Value = dtpHanSuDung.Value.ToString("dd - MM - yyyy");

                        foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                        {
                            row.Cells[4].Value = cbxNhaCungCap.Text;
                            row.Cells[5].Value = dtpNgayNhap.Value.ToString("dd - MM - yyyy");
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        if (dgvHoaDonNhap.Rows.Count > 0)
                        {
                            cbxNhaCungCap.Text = dgvHoaDonNhap.Rows[0].Cells[4].Value.ToString();
                        }
                    }
                }
                //loai thuoc nay chua co trong bang
                else if (flagFoundIndex == -1)
                {
                    DataTable tblThuoc = (DataTable)dgvHoaDonNhap.DataSource;
                    DataRow row = tblThuoc.NewRow();

                    row["Tên Thuốc"] = tenThuoc;
                    row["Số Lượng Nhập"] = tvSoLuongNhap.Text;
                    row["Đơn Giá"] = tvDonGia.Text;
                    row["Khuyến Mại"] = tbKhuyenMai.Text;
                    row["Nhà Cung Cấp"] = cbxNhaCungCap.Text;
                    row["Ngày Nhập"] = dtpNgayNhap.Value.ToString("dd - MM - yyyy");
                    row["Ngày Sản Xuất"] = dtpNgaySanXuat.Value.ToString("dd - MM - yyyy");
                    row["Hạn Sử Dụng"] = dtpHanSuDung.Value.ToString("dd - MM - yyyy");

                    tblThuoc.Rows.Add(row);
                    tblThuoc.AcceptChanges();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.Rows.Count > 0)
            {
                int idNhanVien = Int32.Parse(cbxNhanVien.Text);
                int idNhaCungCap = DataBaseFunction.GetItemId("Select * From NhaCungCap where Ten=N'" + cbxNhaCungCap.Text + "'");
                DateTime ngayNhap = dtpNgayNhap.Value;
                float tongTien = 0;
                foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                {
                    float donGia = float.Parse(row.Cells[2].Value.ToString());
                    float giaBan = donGia * (float)1.1; // cau 3

                    //thuốc này chưa có trong db
                    if (cbxTenThuoc.FindString(row.Cells[0].Value.ToString()) == -1)
                    {
                        Model.Entity.Thuoc thuocMoi = new Model.Entity.Thuoc
                        {
                            Ten = cbxTenThuoc.Text,
                            SoLuongHienCo = Int32.Parse(row.Cells[1].Value.ToString()),
                            DonGiaNhap = donGia,
                            GiaBan = donGia * (float)1.1,
                            NgaySanXuat = dtpNgaySanXuat.Value,
                            HanSuDung = dtpHanSuDung.Value
                        };
                        string sqlThemThuocMoi = "Insert into Thuoc (Ten,SoLuongHienCo,DonGiaNhap,GiaBan,NgaySanXuat,HanSuDung) "
                            + "values (N'" + thuocMoi.Ten + "'," + thuocMoi.SoLuongHienCo + ","
                            + thuocMoi.DonGiaNhap + "," + thuocMoi.GiaBan + ",'"
                            + thuocMoi.NgaySanXuat.ToString("yyyy-MM-dd HH:mm:ss.fff") + "','"
                            + thuocMoi.HanSuDung.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
                        DataBaseFunction.ExcuteSQL(sqlThemThuocMoi);
                    }
                    //thuốc này đã có trong db
                    //cập nhật thông tin cho thuốc
                    else
                    {
                        
                        Model.Entity.Thuoc thuocCu = new Model.Entity.Thuoc
                        {
                            Id = DataBaseFunction.GetItemId("Select * from Thuoc where Ten=N'" + row.Cells[0].Value.ToString() + "'"),
                            SoLuongHienCo = Int32.Parse(row.Cells[1].Value.ToString()),
                            DonGiaNhap = donGia,
                            GiaBan = giaBan,
                            NgaySanXuat = DateTime.ParseExact(row.Cells[5].Value.ToString(),"dd - MM - yyyy", null),
                            HanSuDung = DateTime.ParseExact(row.Cells[6].Value.ToString(), "dd - MM - yyyy", null)
                        };

                        float soLuongCu = DataBaseFunction.GetItemId("Select SoLuongHienCo from Thuoc where Id=" + thuocCu.Id);
                        float soLuongMoi = thuocCu.SoLuongHienCo + soLuongCu;
                        string sqlUpdateThuocCu = "Update Thuoc set SoLuongHienCo=" + soLuongMoi
                            + " , DonGiaNhap=" + thuocCu.DonGiaNhap + " , GiaBan=" + thuocCu.GiaBan
                            + " , NgaySanXuat='" + thuocCu.NgaySanXuat.ToString("yyyy-MM-dd HH:mm:ss.fff")
                            + "' , HanSuDung='" + thuocCu.HanSuDung.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'"
                            + " where Id=" + thuocCu.Id;
                        DataBaseFunction.ExcuteSQL(sqlUpdateThuocCu);
                    }
                    tongTien += donGia * (1 - (float.Parse(row.Cells[3].Value.ToString()) / 100));
                }

                //.ToString("yyyy-MM-dd HH:mm:ss.fff")

                Model.Entity.HoanDonNhap hoanDonNhap = new Model.Entity.HoanDonNhap
                {
                    IdNhaCungCap = idNhaCungCap,
                    IdNhanVien = idNhanVien,
                    NgayNhap = ngayNhap,
                    TongTien = tongTien
                };

                string sqlInsert = "Insert into HoaDonNhap (IdNhanVien,IdNhaCungCap,NgayNhap,TongTien) "
                   + "values(" + hoanDonNhap.IdNhanVien + "," + hoanDonNhap.IdNhaCungCap + ",'" + hoanDonNhap.NgayNhap.ToString("yyyy-MM-dd HH:mm:ss.fff") + "'," + hoanDonNhap.TongTien + ")";
                DataBaseFunction.ExcuteSQL(sqlInsert);

                string sqlGetLast = "SELECT TOP 1 Id FROM HoaDonNhap ORDER BY ID DESC";
                int idHoaDonNhap = DataBaseFunction.GetItemId(sqlGetLast);

                foreach (DataGridViewRow row in dgvHoaDonNhap.Rows)
                {
                    int idThuoc = DataBaseFunction.GetItemId("Select Id from Thuoc where Ten=N'" + row.Cells[0].Value.ToString() + "'");
                    HoaDonNhapDetail hoaDonNhapDetail = new HoaDonNhapDetail
                    {
                        IdHoaDonNhap = idHoaDonNhap,
                        IdThuoc = idThuoc,
                        DonGia = float.Parse(row.Cells[2].Value.ToString()),
                        KhuyenMai = float.Parse(row.Cells[3].Value.ToString()),
                        ThanhTien = float.Parse(row.Cells[2].Value.ToString()) * (1 - (float.Parse(row.Cells[3].Value.ToString()) / 100))
                    };

                    string sqlInsertHoaDonNhapDetail = "Insert into HoaDonNhapDetail (IdHoaDonNhap, IdThuoc, SoLuongNhap, DonGia, KhuyenMai, ThanhTien)\n"
                        + " values (" + hoaDonNhapDetail.IdHoaDonNhap + "," + hoaDonNhapDetail.IdThuoc
                        + "," + hoaDonNhapDetail.SoLuongNhap + "," + hoaDonNhapDetail.DonGia + ","
                        + hoaDonNhapDetail.KhuyenMai + "," + hoaDonNhapDetail.ThanhTien + ")";
                    DataBaseFunction.ExcuteSQL(sqlInsertHoaDonNhapDetail);
                }

                //chuyen qua man hinh hoa don nhap?
                dgvHoaDonNhap.DataSource = MakeTableWithAutoIncrement();
                cbxNhaCungCap.Enabled = true;
                dtpNgayNhap.Enabled = true;
                cbxTenThuoc.Text = "";
                LoadDataToCbxTenThuoc();
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Hóa đơn nhập đang bị để trống!");
            }
        }

        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                string tenThuoc = TienIch.ToTitleCase(cbxTenThuoc.Text);

                if (string.IsNullOrEmpty(tenThuoc))
                {
                    //dem data trong o nay fill len cac o nhap du lieu ben tren
                    prepareDataToEdit(e);
                }
                else
                {
                    //Ô tên thuốc đang có dữ liệu
                    // hỏi xác thực người dùng muốn hủy việc thêm mới và edit bản ghi hiện tại hay không?
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo",
                        "Có vẻ như bạn đang trong quá trình nhập thuốc:'" + tenThuoc + "'\n" +
                        "Bạn có muốn hủy quá trình nhập này để edit thuốc:'" + dgvHoaDonNhap.Rows[e.RowIndex].Cells[0].Value.ToString() + "' hay không?");
                    if (result == DialogResult.Yes)
                    {
                        prepareDataToEdit(e);
                    }
                    else if (result == DialogResult.No)
                    {
                        //do nothing
                    }
                }
            }

        }

        private void prepareDataToEdit(DataGridViewCellEventArgs e)
        {
            cbxNhaCungCap.Enabled = true;
            dtpNgayNhap.Enabled = true;

            cbxTenThuoc.Text = dgvHoaDonNhap.Rows[e.RowIndex].Cells[0].Value.ToString();
            tvSoLuongNhap.Text = dgvHoaDonNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
            tvDonGia.Text = dgvHoaDonNhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbKhuyenMai.Text = dgvHoaDonNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxNhaCungCap.Text = dgvHoaDonNhap.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpNgayNhap.Value = DateTime.Parse(dgvHoaDonNhap.Rows[e.RowIndex].Cells[5].Value.ToString());
            dtpNgaySanXuat.Value = DateTime.Parse(dgvHoaDonNhap.Rows[e.RowIndex].Cells[6].Value.ToString());
            dtpHanSuDung.Value = DateTime.Parse(dgvHoaDonNhap.Rows[e.RowIndex].Cells[7].Value.ToString());
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvHoaDonNhap.Rows[e.RowIndex].Selected = true;
            }
        }

        #region common function

        private void LoadDataToCbxTenThuoc()
        {
            cbxTenThuoc.DataSource = null;
            string sqlSelectThuoc = "Select Id, Ten from Thuoc";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelectThuoc);
            cbxTenThuoc.DataSource = tbl;
            cbxTenThuoc.DisplayMember = "Ten";
            cbxTenThuoc.ValueMember = "Id";
            cbxTenThuoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxTenThuoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxTenThuoc.Text = "";
        }

        private void LoadDataToCbxNhaCungCap()
        {
            string sqlSelectNhaCungCap = "Select * from NhaCungCap";
            DataTable tblNhaCungCap = DataBaseFunction.GetDataToTable(sqlSelectNhaCungCap);
            cbxNhaCungCap.DataSource = tblNhaCungCap;
            cbxNhaCungCap.DisplayMember = "Ten";
            cbxNhaCungCap.ValueMember = "Id";
            cbxNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhaCungCap.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void InitDateTimePicker()
        {
            dtpHanSuDung.Format = DateTimePickerFormat.Custom;
            dtpHanSuDung.CustomFormat = "dd - MM - yyyy";

            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.CustomFormat = "dd - MM - yyyy";

            dtpNgaySanXuat.Format = DateTimePickerFormat.Custom;
            dtpNgaySanXuat.CustomFormat = "dd - MM - yyyy";
        }

        private void InitDataGridView()
        {
            DataTable tblThuoc = MakeTableWithAutoIncrement();
            dgvHoaDonNhap.DataSource = tblThuoc;
            dgvHoaDonNhap.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvHoaDonNhap.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                col.ReadOnly = true;
            }
        }

        private DataTable MakeTableWithAutoIncrement()
        {
            // Make a table with one AutoIncrement column.
            DataTable table = new DataTable("tblThuoc");

            DataColumn tenThuocCol = new DataColumn("Tên Thuốc",
                Type.GetType("System.String"));
            table.Columns.Add(tenThuocCol);

            DataColumn soLuongNhapCol = new DataColumn("Số Lượng Nhập",
                Type.GetType("System.Int32"));
            table.Columns.Add(soLuongNhapCol);

            DataColumn donGiaCol = new DataColumn("Đơn Giá",
                Type.GetType("System.Single"));
            table.Columns.Add(donGiaCol);

            DataColumn khuyenMaiCol = new DataColumn("Khuyến Mại",
                Type.GetType("System.Single"));
            table.Columns.Add(khuyenMaiCol);

            DataColumn nhaCungCapCol = new DataColumn("Nhà Cung Cấp",
                Type.GetType("System.String"));
            table.Columns.Add(nhaCungCapCol);

            DataColumn ngayNhanCol = new DataColumn("Ngày Nhập",
                Type.GetType("System.String"));
            table.Columns.Add(ngayNhanCol);

            DataColumn ngaySanXuatCol = new DataColumn("Ngày Sản Xuất",
                Type.GetType("System.String"));
            table.Columns.Add(ngaySanXuatCol);

            DataColumn hanSuDungCol = new DataColumn("Hạn Sử Dụng",
                Type.GetType("System.String"));
            table.Columns.Add(hanSuDungCol);

            return table;
        }

        #endregion

        private void cbxNhanVien_Leave(object sender, EventArgs e)
        {
            string maNhanVien = TienIch.XoaTatCaKhoangTrang(cbxNhanVien.Text);

            int idNhanVien;

            if (Int32.TryParse(maNhanVien, out idNhanVien))
            {
                cbxNhanVien.Text = idNhanVien.ToString();
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng chọn mã nhân viên có sẵn.");
                if (cbxNhanVien.Items.Count > 0)
                {
                    cbxNhanVien.SelectedIndex = 0;
                }
            }
        }

        private void LoadDataToCbxNhanVien()
        {
            cbxNhanVien.DataSource = null;
            string sqlSelectNhanVien = "Select Id, Ten from NhanVien";
            DataTable tbl = DataBaseFunction.GetDataToTable(sqlSelectNhanVien);
            cbxNhanVien.DataSource = tbl;
            cbxNhanVien.DisplayMember = "Id";
            cbxNhanVien.ValueMember = "Id";

            cbxNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNhanVien.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}

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

namespace QuanLyTiemThuocFinalVersion.View.HoaDonBan
{
    public partial class FormBanThuoc : Form
    {
        public FormBanThuoc()
        {
            InitializeComponent();
        }

        private void cbxTenThuoc_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxTenThuoc.Text));
            if (string.IsNullOrEmpty(cbxValue))
            {
                cbxTenThuoc.Text = "";
            }
            else
            {
                if (cbxTenThuoc.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Bạn đang chọn tên thuốc mới chưa có trong csdl");
                    cbxTenThuoc.SelectedIndex = 0;
                }
            }
        }

        private void tbSoLuong_Leave(object sender, EventArgs e)
        {
            //validate luôn >=0
            string soLuongBanRa = TienIch.XoaTatCaKhoangTrang(tbSoLuong.Text);
            if (soLuongBanRa.All(char.IsDigit))
            {
                int soLuong;
                if (Int32.TryParse(soLuongBanRa, out soLuong))
                {
                    if (soLuong < 1)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Bán ra phải là số tự nhiên lớn hơn 0");
                        tbSoLuong.Focus();
                        tbSoLuong.SelectionLength = tbSoLuong.Text.Length;
                    }
                    else
                    {
                        tbSoLuong.Text = soLuong.ToString();
                        if (!string.IsNullOrEmpty(cbxTenThuoc.Text))
                        {
                            int soLuongThuocTrongKho =
                                DataBaseFunction.GetItemId("Select SoLuongHienCo From Thuoc where Ten=N'" + cbxTenThuoc.Text + "'");
                            int SoLuongBanRa = soLuong;
                            if ((soLuongThuocTrongKho - SoLuongBanRa) < 0)
                            {
                                TienIch.ShowCanhBao("Cảnh Báo", "Số lượng bán ra vượt quá số lượng thuốc trong kho.\nTrong kho hiện còn: " + soLuongThuocTrongKho);
                                tbSoLuong.Focus();
                                tbSoLuong.SelectionLength = tbSoLuong.Text.Length;
                            }
                            else
                            {
                                // khong lam gi ca
                            }
                        }
                        else
                        {// khong lam gi ca

                        }
                    }
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Số Lượng Hiện Có phải là số tự nhiên lớn hơn hoặc bằng 0");
                tbSoLuong.Focus();
                tbSoLuong.SelectionLength = tbSoLuong.Text.Length;
            }
        }

        private void tbGiamGia_Leave(object sender, EventArgs e)
        {
            string khuyenMai = TienIch.XoaTatCaKhoangTrang(tbGiamGia.Text);

            if (string.IsNullOrEmpty(khuyenMai))
            {
                tbGiamGia.Text = "0";
            }
            else
            {
                float giamGiaValue;
                if (float.TryParse(khuyenMai, out giamGiaValue))
                {
                    if (giamGiaValue < 0 || giamGiaValue >= 100)
                    {
                        TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng nhập vào giá trị hợp lệ( nhỏ hơn 100 và lớn hoặc bằng 0)");
                    }
                    else
                    {
                        tbGiamGia.Text = giamGiaValue.ToString();
                    }
                }
                else
                {
                    TienIch.ShowCanhBao("Cảnh Báo", "Vui lòng nhập vào giá trị hợp lệ( nhỏ hơn 100 và lớn hoặc bằng 0)");
                }
            }
        }

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

        private void cbxKhachHang_Leave(object sender, EventArgs e)
        {
            string cbxValue = TienIch.ToTitleCase(TienIch.XoaKhoangTrang(cbxKhachHang.Text)).ToLower();
            if (string.IsNullOrEmpty(cbxValue))
            {
                TienIch.ShowCanhBao("Cảnh báo",
                    "Không được để trống thông tin này!\nCó thể gõ mới Tên Khách Hàng nếu Khách Hàng cần tim không có ở đây");
                if (cbxKhachHang.Items.Count > 0)
                {
                    cbxKhachHang.SelectedIndex = 0;
                }
            }
            else
            {
                if (cbxKhachHang.FindString(cbxValue) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Khách Hàng mới chưa có trong csdl\nBạn Có muốn thêm mới Khách Hàng này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertDangDieuChe = "Insert into KhachHang (Ten) values (N'" + cbxValue + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertDangDieuChe);
                        LoadDataToCbxKhachHang();
                        cbxKhachHang.SelectedIndex = cbxKhachHang.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        cbxKhachHang.SelectedIndex = 0;
                        TienIch.ShowThanhCong("Rest data",
                            "Dữ liệu ô Khách Hàng đã bị xóa do bạn không muốn thêm mới Khách Hàng '" + cbxValue + "' vào hệ thống.");
                    }
                }
            }
        }

        private void dgvBanThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvBanThuoc.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvBanThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                cbxTenThuoc.Text = dgvBanThuoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbSoLuong.Text = dgvBanThuoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbGiamGia.Text = dgvBanThuoc.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBanThuoc.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBanThuoc.SelectedRows)
                {
                    lblTongTien.Text = (float.Parse(lblTongTien.Text) - float.Parse(dgvBanThuoc.Rows[row.Index].Cells[4].Value.ToString())).ToString();
                    dgvBanThuoc.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Hãy chọn bản ghi cần xóa!");
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvBanThuoc.Rows.Count > 0)
            {
                if (string.IsNullOrEmpty(cbxKhachHang.Text))
                {
                    DialogResult dialogResult = TienIch.ShowXacThuc("Yêu Cầu Xác Thực", "Ô tên khách hàng đang bị bỏ trống, bạn có chắn chắn muốn tiếp tục lưu đơn mà không có tên khách hàng chứ?");
                    if (dialogResult == DialogResult.Yes)
                    {
                        xuLyLuuDonKhongCoTenKhachHang();
                    }
                    else
                    {
                        cbxKhachHang.Focus();
                    }
                }
                else
                {
                    xuLyLuuDonCoTenKhachHang();
                }
            }
            else
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Không được để trống hóa đơn bán.");
            }
        }

        private void xuLyLuuDonKhongCoTenKhachHang()
        {
            //here
            int idNhanVien = Int32.Parse(cbxNhanVien.Text);
            //int idNhanVien = DataBaseFunction.GetItemId("Select Id From NhanVien where Id = 1");
            DateTime ngayNhap = DateTime.Now;

            float tongTien = float.Parse(lblTongTien.Text);

            string sqlInsertNewHoaDonBan = "Insert into HoaDonBan (IdNhanVien,TongTien,NgayBan) " +
                " values (" + idNhanVien + "," + tongTien + ",'" + ngayNhap.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            DataBaseFunction.ExcuteSQL(sqlInsertNewHoaDonBan);

            int idHoaDonBan = DataBaseFunction.GetItemId("Select Max(Id) from HoaDonBan");

            foreach (DataGridViewRow row in dgvBanThuoc.Rows)
            {
                HoaDonBanDetail hoaDonBanDetail = new HoaDonBanDetail
                {
                    IdHoaDonBan = idHoaDonBan,
                    IdThuoc = DataBaseFunction.GetItemId("Select Id from Thuoc where Ten=N'" + row.Cells[0].Value.ToString() + "'"),
                    SoLuong = Int32.Parse(row.Cells[1].Value.ToString()),
                    GiamGia = float.Parse(row.Cells[3].Value.ToString()),
                    ThanhTien = float.Parse(row.Cells[4].Value.ToString())
                };

                string sqlInsertHoaDonDetail = "Insert into HoaDonBanDetail (IdHoaDonBan, IdThuoc, SoLuong, GiamGia, ThanhTien) " +
                    " values ( " +
                     hoaDonBanDetail.IdHoaDonBan + " , " +
                     hoaDonBanDetail.IdThuoc + " , " +
                     hoaDonBanDetail.SoLuong + " , " +
                     hoaDonBanDetail.GiamGia + " , " +
                     hoaDonBanDetail.ThanhTien +
                    " )";
                DataBaseFunction.ExcuteSQL(sqlInsertHoaDonDetail);

                int SoLuongThuocCu = DataBaseFunction.GetItemId("Select SoLuongHienCo from Thuoc where Id=" + hoaDonBanDetail.IdThuoc + " ");
                int SoLuongConLai = SoLuongThuocCu - hoaDonBanDetail.SoLuong;
                string sqlUpdateThuoc = "Update Thuoc set SoLuongHienCo=" + SoLuongConLai + " where Id=" + hoaDonBanDetail.IdThuoc;
                DataBaseFunction.ExcuteSQL(sqlUpdateThuoc);
            }

            //chuyen qua man hinh hoa don nhap?
            dgvBanThuoc.DataSource = MakeTableWithAutoIncrement();
            cbxTenThuoc.Text = "";
            tbGiamGia.Text = "0";
            tbSoLuong.Text = "1";
            lblTongTien.Text = "0";
            LoadDataToCbxThuoc();
        }

        private void xuLyLuuDonCoTenKhachHang()
        {
            //here
            int idNhanVien = Int32.Parse(cbxNhanVien.Text);
            int idKhachHang = DataBaseFunction.GetItemId("Select * From KhachHang where Ten=N'" + cbxKhachHang.Text + "'");
            DateTime ngayNhap = DateTime.Now;

            float tongTien = float.Parse(lblTongTien.Text);

            string sqlInsertNewHoaDonBan = "Insert into HoaDonBan (IdNhanVien,IdKhach,TongTien,NgayBan) " +
                " values (" + idNhanVien + "," + idKhachHang + "," + tongTien + ",'" + ngayNhap.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
            DataBaseFunction.ExcuteSQL(sqlInsertNewHoaDonBan);

            int idHoaDonBan = DataBaseFunction.GetItemId("Select Max(Id) from HoaDonBan");

            foreach (DataGridViewRow row in dgvBanThuoc.Rows)
            {
                HoaDonBanDetail hoaDonBanDetail = new HoaDonBanDetail
                {
                    IdHoaDonBan = idHoaDonBan,
                    IdThuoc = DataBaseFunction.GetItemId("Select Id from Thuoc where Ten=N'" + row.Cells[0].Value.ToString() + "'"),
                    SoLuong = Int32.Parse(row.Cells[1].Value.ToString()),
                    GiamGia = float.Parse(row.Cells[3].Value.ToString()),
                    ThanhTien = float.Parse(row.Cells[4].Value.ToString())
                };

                string sqlInsertHoaDonDetail = "Insert into HoaDonBanDetail (IdHoaDonBan, IdThuoc, SoLuong, GiamGia, ThanhTien) " +
                    " values ( " +
                     hoaDonBanDetail.IdHoaDonBan + " , " +
                     hoaDonBanDetail.IdThuoc + " , " +
                     hoaDonBanDetail.SoLuong + " , " +
                     hoaDonBanDetail.GiamGia + " , " +
                     hoaDonBanDetail.ThanhTien +
                    " )";
                DataBaseFunction.ExcuteSQL(sqlInsertHoaDonDetail);

                int SoLuongThuocCu = DataBaseFunction.GetItemId("Select SoLuongHienCo from Thuoc where Id=" + hoaDonBanDetail.IdThuoc + " ");
                int SoLuongConLai = SoLuongThuocCu - hoaDonBanDetail.SoLuong;
                string sqlUpdateThuoc = "Update Thuoc set SoLuongHienCo=" + SoLuongConLai + " where Id=" + hoaDonBanDetail.IdThuoc;
                DataBaseFunction.ExcuteSQL(sqlUpdateThuoc);
            }

            //chuyen qua man hinh hoa don nhap?
            dgvBanThuoc.DataSource = MakeTableWithAutoIncrement();
            cbxTenThuoc.Text = "";
            tbGiamGia.Text = "0";
            tbSoLuong.Text = "1";
            lblTongTien.Text = "0";
            LoadDataToCbxThuoc();
        }
        //

        private void LoadDataToCbxThuoc()
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

        private void LoadDataToCbxKhachHang()
        {
            string sqlSelectCongDung = "Select * from KhachHang";
            DataTable tblCongDung = DataBaseFunction.GetDataToTable(sqlSelectCongDung);
            cbxKhachHang.DataSource = tblCongDung;
            cbxKhachHang.DisplayMember = "Ten";
            cbxKhachHang.ValueMember = "Id";
            cbxKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhachHang.Text = "";
        }

        private void FormBanThuoc_Load(object sender, EventArgs e)
        {
            LoadDataToCbxThuoc();
            LoadDataToCbxKhachHang();
            LoadDataToCbxNhanVien();
            InitDataGridView();
        }

        private void btnThemVaoDon_Click(object sender, EventArgs e)
        {
            string tenThuoc = TienIch.ToTitleCase(cbxTenThuoc.Text);
            if (string.IsNullOrEmpty(tenThuoc))
            {
                TienIch.ShowCanhBao("Cảnh Báo", "Hãy nhập tên thuốc!");
                cbxTenThuoc.Focus();
            }
            else
            {
                int flagFoundIndex = -1;


                //kiem tra trong bang da co thuoc nay chua
                foreach (DataGridViewRow row in dgvBanThuoc.Rows)
                {
                    //if (row.Cells[0].Value != null)
                    //{
                    if (row.Cells[0].Value.ToString().Equals(tenThuoc))
                    {
                        flagFoundIndex = row.Index;
                        break;
                    }
                    //}
                }

                //loai thuoc nay da co trong bang
                if (flagFoundIndex != -1)
                {
                    //hoi nguoi dung muon thay the thong tin cu trong bang hay cap nhat thong tin moi
                    DialogResult result = MessageBox.Show("Tên Thuốc " + tenThuoc + " đã tồn tại trong bảng!\n"
                        + "Chọn [Yes] để cập nhật thông tin cho bản ghi thuốc hiện có trong bảng(số lượng bán, Thành Tiền).\n"
                        + "Chọn [No] để thay thế bản ghi hiện có trong bảng.\n"
                        + "Chọn [Cancel] để hủy.", "Cảnh Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                    int soLuongBan = Int32.Parse(tbSoLuong.Text);

                    if (result == DialogResult.Yes)
                    {
                        int soLuongBan_cu = Int32.Parse(dgvBanThuoc.Rows[flagFoundIndex].Cells[1].Value.ToString());
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[1].Value = (soLuongBan_cu + soLuongBan).ToString();
                        //update lai tong gia cho loai thuoc nay
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[4].Value = (float.Parse(dgvBanThuoc.Rows[flagFoundIndex].Cells[4].Value.ToString()) / soLuongBan_cu * (soLuongBan + soLuongBan_cu));
                        lblTongTien.Text = (float.Parse(lblTongTien.Text) + float.Parse(dgvBanThuoc.Rows[flagFoundIndex].Cells[4].Value.ToString()) / soLuongBan_cu * (soLuongBan)).ToString();
                    }
                    else if (result == DialogResult.No)
                    {
                        float giamGia = float.Parse(tbGiamGia.Text);
                        float donGia = float.Parse(DataBaseFunction.GetItemValue("Select GiaBan from Thuoc where Ten=N'" + tenThuoc + "'"));

                        float tongGiaCu = float.Parse(dgvBanThuoc.Rows[flagFoundIndex].Cells[4].Value.ToString());
                        lblTongTien.Text = (float.Parse(lblTongTien.Text) - tongGiaCu + donGia * (1 - giamGia / 100) * soLuongBan).ToString();

                        dgvBanThuoc.Rows[flagFoundIndex].Cells[0].Value = tenThuoc;
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[1].Value = soLuongBan;
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[2].Value = donGia;
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[3].Value = giamGia;
                        dgvBanThuoc.Rows[flagFoundIndex].Cells[4].Value = donGia * (1 - giamGia / 100) * soLuongBan;


                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }
                //loai thuoc nay chua co trong bang
                else if (flagFoundIndex == -1)
                {
                    DataTable tblThuoc = (DataTable)dgvBanThuoc.DataSource;
                    DataRow row = tblThuoc.NewRow();

                    int soLuongBan = Int32.Parse(tbSoLuong.Text);
                    float giamGia = float.Parse(tbGiamGia.Text);
                    float donGia = float.Parse(DataBaseFunction.GetItemValue("Select GiaBan from Thuoc where Ten=N'" + tenThuoc + "'"));

                    row["Tên Thuốc"] = tenThuoc;
                    row["Số Lượng Bán"] = Int32.Parse(tbSoLuong.Text);
                    row["Đơn Giá"] = donGia;
                    row["Giảm Giá"] = giamGia;
                    row["Thành Tiền"] = donGia * (1 - giamGia / 100) * soLuongBan;

                    tblThuoc.Rows.Add(row);
                    tblThuoc.AcceptChanges();

                    lblTongTien.Text = (float.Parse(lblTongTien.Text) + donGia * (1 - giamGia / 100) * soLuongBan).ToString();
                }
            }
        }

        private void InitDataGridView()
        {
            DataTable tblThuoc = MakeTableWithAutoIncrement();
            dgvBanThuoc.DataSource = tblThuoc;
            dgvBanThuoc.MultiSelect = false;

            foreach (DataGridViewColumn col in dgvBanThuoc.Columns)
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

            DataColumn soLuongNhapCol = new DataColumn("Số Lượng Bán",
                Type.GetType("System.Int32"));
            table.Columns.Add(soLuongNhapCol);

            DataColumn donGiaCol = new DataColumn("Đơn Giá",
                Type.GetType("System.Single"));
            table.Columns.Add(donGiaCol);

            DataColumn khuyenMaiCol = new DataColumn("Giảm Giá",
                Type.GetType("System.Single"));
            table.Columns.Add(khuyenMaiCol);

            DataColumn nhaCungCapCol = new DataColumn("Thành Tiền",
                Type.GetType("System.String"));
            table.Columns.Add(nhaCungCapCol);

            return table;
        }

    }
}

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
    public partial class FormThemMoiNhanVien : Form
    {
        private string editTen;
        private string editDiaChi;
        private string editSoDienThoai;
        private string editChuyenMonTrinhDo;
        private string editGioiTinh;
        private string editNgaySinh;

        public FormThemMoiNhanVien()
        {
            InitializeComponent();
            editTen = "";
            editDiaChi = "";
            editSoDienThoai = "";
            editChuyenMonTrinhDo = "";
            editGioiTinh = "";
            editNgaySinh = "";
        }

        private void FormThemMoiNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataToCbxTrinhDo();
            LoadDataToCbxChuyenMon();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd - MM - yyyy";
            LoadDataToGridView();
        }

        private void tbTen_Leave(object sender, EventArgs e)
        {

        }

        private void tbSoDienThoai_Leave(object sender, EventArgs e)
        {

        }

        private void tbDiaChi_Leave(object sender, EventArgs e)
        {
            tbDiaChi.Text = TienIch.ToUpperFistCharacter(tbDiaChi.Text);
        }

        private void cbxTrinhDo_Leave(object sender, EventArgs e)
        {

        }

        private void cbxChuyenMon_Leave(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //loại trừ trường hợp user chọn title của bảng
            if (e.RowIndex > -1)
            {
                dgvNhanVien.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dgvNhanVien_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                editTen = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (e.ColumnIndex == 2)
            {
                editChuyenMonTrinhDo = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else if (e.ColumnIndex == 3)
            {
                editChuyenMonTrinhDo = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else if (e.ColumnIndex == 4)
            {
                editNgaySinh = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            else if (e.ColumnIndex == 5)
            {
                editGioiTinh = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            //Nếu user chỉnh sửa cột dia chi
            else if (e.ColumnIndex == 6)
            {
                editDiaChi = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            //Nếu user chỉnh sửa cột số điện thoại
            else if (e.ColumnIndex == 7)
            {
                editSoDienThoai = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        private void dgvNhanVien_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Nếu user chỉnh sửa cột tên
            if (e.ColumnIndex == 1)
            {
                editTenNhanVien(e);
            }
            //Nếu user chỉnh sửa cột Chuyen Mon
            else if (e.ColumnIndex == 2)
            {
                editChuyenMonNhanVien(e);
            }
            //Nếu user chỉnh sửa cột Trinh Do
            else if (e.ColumnIndex == 3)
            {
                editTrinhDoNhanVien(e);
            }
            //Nếu user chỉnh sửa cột Ngày sinh
            else if (e.ColumnIndex == 4)
            {
                editNgaySinhNhanVien(e);
            }
            //Nếu user chỉnh sửa cột giới tính
            else if (e.ColumnIndex == 5)
            {
                editGioiTinhNhanVien(e);
            }
            //Nếu user chỉnh sửa cột Địa Chỉ
            else if (e.ColumnIndex == 6)
            {
                editDiaChiNhanVien(e);
            }
            //Nếu user chỉnh sửa cột Số Điện Thoại
            else if (e.ColumnIndex == 7)
            {
                editSoDienThoaiNhanVien(e);
            }

        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadDataToCbxTrinhDo()
        {
            cbxTrinhDo.DataSource = null;
            string sqlSelectTrinhDo = "Select * from TrinhDo";
            DataTable tblTrinhDo = DataBaseFunction.GetDataToTable(sqlSelectTrinhDo);
            cbxTrinhDo.DataSource = tblTrinhDo;
            cbxTrinhDo.DisplayMember = "Ten";
            cbxTrinhDo.ValueMember = "Id";
            cbxTrinhDo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxTrinhDo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadDataToCbxChuyenMon()
        {
            string sqlSelectChuyenMon = "Select * from ChuyenMon";
            DataTable tblChuyenMon = DataBaseFunction.GetDataToTable(sqlSelectChuyenMon);
            cbxChuyenMon.DataSource = tblChuyenMon;
            cbxChuyenMon.DisplayMember = "Ten";
            cbxChuyenMon.ValueMember = "Id";
            cbxChuyenMon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxChuyenMon.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void dtpNgaySinh_Leave(object sender, EventArgs e)
        {
            DateTime ngaySinh = dtpNgaySinh.Value;
            if (ngaySinh.Date == DateTime.Now.Date && ngaySinh.Month == DateTime.Now.Month && ngaySinh.Year == DateTime.Now.Year)
            {
                TienIch.ShowCanhBao("Giá trị không hợp lệ", "Vui lòng kiểm tra lại ngày sinh");
            }
        }

        private void LoadDataToGridView()
        {
            string sqlCommand = "Select nv.Id, nv.Ten, cm.Ten, td.Ten, nv.NgaySinh, nv.GioiTinh, nv.DiaChi, nv.DienThoai from NhanVien nv, ChuyenMon cm, TrinhDo td where nv.IdChuyenMon = cm.Id and nv.IdTrinhDo = td.Id";
            DataTable tblNhanVien_raw = DataBaseFunction.GetDataToTable(sqlCommand);

            DataTable tblNhanVien_final = MakeTableWithAutoIncrement();

            foreach (DataRow dr in tblNhanVien_raw.Rows)
            {
                object[] rowArray = new object[8];
                rowArray[0] = dr.ItemArray[0];
                rowArray[1] = dr.ItemArray[1];
                rowArray[2] = dr.ItemArray[2];
                rowArray[3] = dr.ItemArray[3];
                if (string.IsNullOrEmpty(dr.ItemArray[4].ToString()))
                {
                    rowArray[4] = null;
                }
                else
                {
                    DateTime dob = DateTime.Parse(dr.ItemArray[4].ToString());
                    if (dob.Year == 1900 && dob.Month == 1 && dob.Day == 1)
                    {
                        rowArray[4] = null;
                    }
                    else
                    {
                        rowArray[4] = dob.ToString("dd - MM - yyyy");
                    }
                }

                if ((bool)dr.ItemArray[5] == true)
                {
                    rowArray[5] = "Nam";
                }
                else if ((bool)dr.ItemArray[5] == false)
                {
                    rowArray[5] = "Nữ";
                }
                rowArray[6] = dr.ItemArray[6];
                rowArray[7] = dr.ItemArray[7];
                tblNhanVien_final.Rows.Add(rowArray);
            }

            dgvNhanVien.DataSource = tblNhanVien_final;
            //Cho người dùng thêm dữ liệu trực tiếp
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvNhanVien.Columns[0].HeaderText = "Mã";
            dgvNhanVien.Columns[0].Width = 80;
            dgvNhanVien.Columns[0].ReadOnly = true;
            dgvNhanVien.Columns[0].Resizable = DataGridViewTriState.False;
            dgvNhanVien.Columns[0].ToolTipText = "Mã của nhân viên lưu trong cơ sở dữ liệu";

            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[1].Width = 300;
            dgvNhanVien.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNhanVien.Columns[1].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[2].HeaderText = "Chuyên Môn";
            dgvNhanVien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[2].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[3].HeaderText = "Trình Độ";
            dgvNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[3].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[4].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[4].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[5].HeaderText = "Giới Tính";
            dgvNhanVien.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[5].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[6].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[6].Resizable = DataGridViewTriState.False;

            dgvNhanVien.Columns[7].HeaderText = "Số Điện Thoại";
            dgvNhanVien.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNhanVien.Columns[7].Resizable = DataGridViewTriState.False;
        }

        private DataTable MakeTableWithAutoIncrement()
        {
            // Make a table with one AutoIncrement column.
            DataTable table = new DataTable("table");

            DataColumn idColumn = new DataColumn("id",
                Type.GetType("System.Int32"));
            table.Columns.Add(idColumn);

            DataColumn tenColumn = new DataColumn("Ten",
                Type.GetType("System.String"));
            table.Columns.Add(tenColumn);

            DataColumn chuyenMonColumn = new DataColumn("Chuyên Môn",
                Type.GetType("System.String"));
            table.Columns.Add(chuyenMonColumn);

            DataColumn trinhDoColumn = new DataColumn("Trình Độ",
                Type.GetType("System.String"));
            table.Columns.Add(trinhDoColumn);

            DataColumn ngaySinhColumn = new DataColumn("Ngày Sinh",
                Type.GetType("System.String"));
            table.Columns.Add(ngaySinhColumn);

            DataColumn gioiTinhColumn = new DataColumn("Giới Tính",
                Type.GetType("System.String"));
            table.Columns.Add(gioiTinhColumn);

            DataColumn diaChiCol = new DataColumn("Địa Chỉ",
                Type.GetType("System.String"));
            table.Columns.Add(diaChiCol);

            DataColumn sdtCol = new DataColumn("Điện Thoại",
                Type.GetType("System.String"));
            table.Columns.Add(sdtCol);

            return table;
        }

        private void updateEditedCellValueToDB(string tenCot, string giaTriMoi, int id)
        {
            string sqlUpdate = "Update NhanVien set " + tenCot + "=N'" + giaTriMoi + "' where Id=" + id;
            DataBaseFunction.ExcuteSQL(sqlUpdate);
        }

        private void updateEditedCellDateTimeValueToDB(string tenCot, string giaTriMoi, int id)
        {
            string sqlUpdate = "Update NhanVien set " + tenCot + "='" + giaTriMoi + "' where Id=" + id;
            DataBaseFunction.ExcuteSQL(sqlUpdate);
        }

        private void editTenNhanVien(DataGridViewCellEventArgs e)
        {
            string ten = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(ten)))
            {
                TienIch.ShowCanhBao("Dữ liệu không phù hợp", "Không được để trống tên Nhân Viên");
                dgvNhanVien.Rows[e.RowIndex].Cells[1].Value = editTen;
            }
            else
            {
                //update lại data trong db
                updateEditedCellValueToDB("Ten",
                    TienIch.ToTitleCase(dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                //update lại giá trị cho ô tên ở phía giao diện người dùng
                dgvNhanVien.Rows[e.RowIndex].Cells[1].Value = TienIch.ToTitleCase(dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            //set lại biến để dùng cho lần edit sau
            editTen = "";
        }

        private void editDiaChiNhanVien(DataGridViewCellEventArgs e)
        {
            string diaChi = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (string.IsNullOrEmpty(TienIch.XoaKhoangTrang(diaChi)))
            {
                if (string.IsNullOrEmpty(editDiaChi))
                {

                }
                else
                {
                    //trước đó bản ghi này có địa chỉ và hiện tại ô địa chỉ bị xóa trắng
                    DialogResult result = TienIch.ShowXacThuc("Yêu cầu xác thực",
                    "Bạn vừa xóa hoàn toàn địa chỉ của nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + ". Bạn có muốn lưu thay đổi này hay không?");
                    if (result == DialogResult.Yes)
                    {
                        //update lại data trong db
                        updateEditedCellValueToDB("DiaChi",
                            "",
                            Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        //update lại giá trị cho ô địa chỉ ở phía giao diện người dùng
                        dgvNhanVien.Rows[e.RowIndex].Cells[6].Value = "";
                        TienIch.ShowThanhCong("Cập nhật thành công", "Đã xóa hoàn toàn địa chỉ của nhân viên này!");
                    }
                    else
                    {
                        dgvNhanVien.Rows[e.RowIndex].Cells[6].Value = editDiaChi;
                        TienIch.ShowThanhCong("Khôi phục thành công",
                            "Đã khôi phục lại địa chỉ của nhân viên" + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + " về như cũ.");
                    }
                }
            }
            else
            {
                //update lại data trong db
                updateEditedCellValueToDB("DiaChi",
                    TienIch.ToUpperFistCharacter(dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString()),
                    Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                //update lại giá trị cho ô tên ở phía giao diện người dùng
                dgvNhanVien.Rows[e.RowIndex].Cells[6].Value = TienIch.ToUpperFistCharacter(dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString());
            }
            //set lại biến để dùng cho lần edit sau
            editDiaChi = "";
        }

        private void editSoDienThoaiNhanVien(DataGridViewCellEventArgs e)
        {
            string soDienThoai = TienIch.XoaTatCaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString());
            if (string.IsNullOrEmpty(soDienThoai))
            {
                if (string.IsNullOrEmpty(editSoDienThoai))
                {
                    //Bản ghi trước đó cũng trống rỗng

                }
                else
                {
                    //người dùng xóa số điện thoại 
                    //hỏi người dùng có muốn xóa hay không?
                    DialogResult result = TienIch.ShowXacThuc("Yêu Cầu Xác Thực", "Hiện ô điện thoại đang để trống, bạn có muốn xóa số điện thoại cũ đi không?");
                    if (result == DialogResult.Yes)
                    {
                        // xoa
                        //update lại data trong db
                        updateEditedCellValueToDB("DienThoai",
                            "",
                            Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        TienIch.ShowThanhCong("Thành Công", "Số điện thoại " + editSoDienThoai + " đã bị xóa khỏi hệ thống");
                        dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = soDienThoai;
                    }
                    else
                    {
                        // khÔi phục và thông báo
                        dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = editSoDienThoai;
                        TienIch.ShowThanhCong("Thành Công", "Số điện thoại " + editSoDienThoai + " đã được khôi phục về như cũ");
                    }
                }
            }
            else
            {
                if (soDienThoai.All(char.IsDigit))
                {
                    if (soDienThoai.Equals(editSoDienThoai))
                    {
                        //cập nhật lại số trên giao diện người dùng
                        dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = soDienThoai;
                    }
                    else
                    {
                        //nguoi dung nhập vào số điện thoại mới
                        //hỏi người dùng có muốn xóa hay không?
                        DialogResult result = TienIch.ShowXacThuc("Yêu Cầu Xác Thực",
                            "Số điện thoại mới nhập khác số điện thoại đang lưu trong hệ thống, bạn có muốn cập nhật số này không?");
                        if (result == DialogResult.Yes)
                        {
                            //update lại data trong db
                            updateEditedCellValueToDB("DienThoai",
                                TienIch.XoaTatCaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString()),
                                Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                            //update lại giá trị cho ô tên ở phía giao diện người dùng
                            dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = TienIch.XoaTatCaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString());
                            TienIch.ShowThanhCong("Cập nhật thành công",
                                "Đã cập nhật thành công số điện thoại " + soDienThoai + " cho nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString()
                                + " vào trong cơ sở dữ liệu.");
                        }
                        else
                        {
                            dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = editSoDienThoai;
                            TienIch.ShowThanhCong("Cập nhật thành công", "Số điện thoại cũ vẫn được giữ nguyên");
                        }

                    }
                }
                else
                {
                    TienIch.ShowLoi("Dữ Liệu không phù hợp", "Chỉ chấp nhận các ký tự là số từ 0~9");
                    dgvNhanVien.Rows[e.RowIndex].Cells[7].Value = editSoDienThoai;
                }
            }
            //set lại biến để dùng cho lần edit sau
            editSoDienThoai = "";
        }

        private void editChuyenMonNhanVien(DataGridViewCellEventArgs e)
        {
            string chuyenMon = TienIch.XoaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString()).ToLower();
            if (string.IsNullOrEmpty(chuyenMon))
            {
                TienIch.ShowCanhBao("Cảnh báo", "Không được để trống thông tin này!\nCó thể gõ mới chuyên môn nếu chuyên môn bạn cần không có ở đây");
                dgvNhanVien.Rows[e.RowIndex].Cells[2].Value = editChuyenMonTrinhDo;
            }
            else
            {
                if (cbxChuyenMon.FindString(chuyenMon) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                    dgvNhanVien.Rows[e.RowIndex].Cells[2].Value = chuyenMon;
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Chuyên Môn mới chưa có trong csdl\n Bạn Có muốn thêm mới Chuyên Môn này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertChuyenMon = "Insert into ChuyenMon (Ten) values (N'" + chuyenMon + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertChuyenMon);
                        LoadDataToCbxChuyenMon();
                        cbxChuyenMon.SelectedIndex = cbxChuyenMon.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                        //cap nhat o phia giao dien nguoi dung
                        dgvNhanVien.Rows[e.RowIndex].Cells[2].Value = chuyenMon;
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        dgvNhanVien.Rows[e.RowIndex].Cells[2].Value = editChuyenMonTrinhDo;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô chuyên môn đã bị xóa do bạn không muốn thêm mới chuyên môn này vào hệ thống.");
                    }
                }
            }
            editChuyenMonTrinhDo = "";
        }

        private void editTrinhDoNhanVien(DataGridViewCellEventArgs e)
        {
            string trinhDo = TienIch.XoaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString()).ToLower();
            if (string.IsNullOrEmpty(trinhDo))
            {
                TienIch.ShowCanhBao("Cảnh báo", "Không được để trống thông tin này!\nCó thể gõ mới trình độ nếu trình độ bạn cần không có ở đây");
                dgvNhanVien.Rows[e.RowIndex].Cells[3].Value = editChuyenMonTrinhDo;
            }
            else
            {
                if (cbxTrinhDo.FindString(trinhDo) >= 0)
                {
                    //User chọn bản ghi có trong csdl
                    dgvNhanVien.Rows[e.RowIndex].Cells[3].Value = trinhDo;
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Cảnh Báo", "Bạn đang chọn Trình Độ mới chưa có trong csdl\n Bạn Có muốn thêm mới Trình Độ này vào trong csdl?");
                    if (result == DialogResult.Yes)
                    {
                        //Thêm mới bản ghi vào trong db
                        string sqlInsertTrinhDo = "Insert into TrinhDo (Ten) values (N'" + trinhDo + "')";
                        DataBaseFunction.ExcuteSQL(sqlInsertTrinhDo);
                        LoadDataToCbxTrinhDo();
                        cbxTrinhDo.SelectedIndex = cbxTrinhDo.Items.Count - 1;
                        TienIch.ShowThanhCong("Thành Công", "Thêm mới thành công");
                        //cap nhat o phia giao dien nguoi dung
                        dgvNhanVien.Rows[e.RowIndex].Cells[3].Value = trinhDo;
                    }
                    else if (result == DialogResult.No)
                    {
                        //xóa text trên ô combobox
                        dgvNhanVien.Rows[e.RowIndex].Cells[3].Value = editChuyenMonTrinhDo;
                        TienIch.ShowThanhCong("Rest data", "Dữ liệu ô trình độ đã bị xóa do bạn không muốn thêm mới trình độ này vào hệ thống.");
                    }
                }
            }
            editChuyenMonTrinhDo = "";
        }

        private void editNgaySinhNhanVien(DataGridViewCellEventArgs e)
        {
            string ngaySinh = TienIch.XoaTatCaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString());
            if (string.IsNullOrEmpty(ngaySinh))
            {
                if (string.IsNullOrEmpty(editNgaySinh))
                {
                    //ô Ngày sinh trước đó cũng để trống
                    dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = "";
                }
                else
                {
                    DialogResult result = TienIch.ShowXacThuc("Xác thực",
                    "Bạn có chắc muốn xóa hoàn toàn ngày sinh của nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString());
                    if (result == DialogResult.Yes)
                    {
                        //cập nhật mới, xóa hoàn toàn
                        updateEditedCellDateTimeValueToDB("NgaySinh",
                            null,
                            Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = "";
                    }
                    else
                    {
                        //khôi phục lại như cũ
                        //chỉnh lại dữ liệu ở phía người dùng
                        dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = editNgaySinh;
                    }
                }
            }
            else
            {
                try
                {
                    DateTime ngaySinhMoi = DateTime.ParseExact(ngaySinh, "dd-MM-yyyy", null);
                    DialogResult result = TienIch.ShowXacThuc("Yêu cầu xác thực",
                        "Bạn có muốn cập nhật ngày sinh " + ngaySinhMoi.ToString("dd - MM - yyyy") + " cho nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + "?");
                    if (result == DialogResult.Yes)
                    {
                        string newDOB = ngaySinhMoi.ToString("yyyy-MM-dd HH:mm:ss");
                        updateEditedCellDateTimeValueToDB("NgaySinh", newDOB,
                            Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        TienIch.ShowThanhCong("Cập nhật thành công!", "Cập nhật thành công ngày sinh mới cho nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + ".");
                        dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = ngaySinhMoi.ToString("dd - MM - yyyy");
                    }
                    else
                    {
                        dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = editNgaySinh;
                        TienIch.ShowThanhCong("", "Ngày sinh của nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + " vẫn được giữ như cũ.");
                    }
                }
                catch (Exception ex)                {
                    TienIch.ShowLoi("Lỗi", "Hãy bảo đảm nhập đúng thứ tự và định dạng\nngày - tháng - năm(31-01-2020 hoặc 31 - 01 - 2020)\nTrong đó Ngày, tháng, năm phải là dữ liệu hợp lý!");
                    dgvNhanVien.Rows[e.RowIndex].Cells[4].Value = editNgaySinh;
                }
            }
            editNgaySinh = "";
        }

        private void editGioiTinhNhanVien(DataGridViewCellEventArgs e)
        {
            string gioiTinh = TienIch.ToUpperFistCharacter(TienIch.XoaTatCaKhoangTrang(dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString()));
            if (string.IsNullOrEmpty(gioiTinh))
            {
                //người dùng xóa sạch bản ghi giới tính
                // thông báo cho người dùng không được để trống ô này
                TienIch.ShowCanhBao("Cảnh Báo",
                    "Không được để trống ô giới tính của nhân viên. \nCó thể nhập vào 'Nam' - 'nam' hoặc 'Nữ' - 'nữ'\nĐể cập nhật giới tính cho nhân viên");
                //cập nhật lại giới tính cho nhân viên ở phía giao diện người dùng
                dgvNhanVien.Rows[e.RowIndex].Cells[5].Value = editGioiTinh;
                TienIch.ShowThanhCong("Khôi phục thành công",
                    "Đã khôi phục lại giới tính của nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            else
            {
                if (gioiTinh.Equals(editGioiTinh))
                {
                    //Không có gì khác cả
                    // set lại dữ liệu phía giao diện người dùng
                    dgvNhanVien.Rows[e.RowIndex].Cells[5].Value = gioiTinh;
                }
                else
                {
                    //dữ liệu người dùng mới nhập khác với dữ liệu ban đầu
                    // cập nhật lại vào trong database
                    bool gender = false;
                    if (gioiTinh.Equals("Nam"))
                    {
                        gender = true;
                    }

                    updateEditedCellValueToDB("GioiTinh",
                        gender == true ? "1" : "0",
                        Int32.Parse(dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    //update lại data ở phía giao diện người dùng
                    dgvNhanVien.Rows[e.RowIndex].Cells[5].Value = gioiTinh;
                    TienIch.ShowThanhCong("Cập nhật thành công",
                        "Đã cập nhật thành công giới tính cho nhân viên " + dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString() + " từ " + editGioiTinh + " sang " + gioiTinh);
                }
            }
            editGioiTinh = "";
        }

    }
}

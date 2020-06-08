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

       
    }
}

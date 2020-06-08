using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemThuocFinalVersion.Model.Entity
{
    public class HoaDonNhapDetail
    {
        public int Id { get; set; }
        public int IdHoaDonNhap { get; set; }
        public int IdThuoc { get; set; }
        public int SoLuongNhap { get; set; }
        public float DonGia { get; set; }
        public float KhuyenMai { get; set; }
        public float ThanhTien { get; set; }
    }
}

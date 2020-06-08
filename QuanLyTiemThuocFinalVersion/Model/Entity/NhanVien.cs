using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemThuocFinalVersion.Model.Entity
{
    public class NhanVien
    {
        public int Id { get; set; }
        public int IdChuyenMon { get; set; }
        public int IdTrinhDo { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemThuocFinalVersion.Model.Entity
{
    public class HoanDonNhap
    {
        public int Id { get; set; }
        public int IdNhanVien { get; set; }
        public int IdNhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public float TongTien { get; set; }
    }
}

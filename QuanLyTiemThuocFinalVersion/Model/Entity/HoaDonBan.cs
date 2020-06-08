using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemThuocFinalVersion.Model.Entity
{
    public class HoaDonBan
    {
        public int Id { get; set; }
        public DateTime NgayBan { get; set; }
        public int IdNhanVien { get; set; }
        public int IdKhach { get; set; }
        public float TongTien { get; set; }
    }
}

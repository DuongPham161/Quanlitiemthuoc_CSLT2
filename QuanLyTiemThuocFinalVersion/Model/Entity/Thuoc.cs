using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemThuocFinalVersion.Model.Entity
{
    public class Thuoc
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int IdDonVi { get; set; }
        public int IdDangDieuChe { get; set; }
        public int IdNuocSanXuat { get; set; }
        public string ThanhPhan { get; set; }
        public float DonGiaNhap { get; set; }
        public float GiaBan { get; set; }
        public int SoLuongHienCo { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string ChongChiDinh { get; set; }
    }
}

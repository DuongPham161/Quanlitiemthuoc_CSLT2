using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemThuocFinalVersion.Utility
{
    public static class TienIch
    {
               
        public static string XoaTatCaKhoangTrang(string text)
        {
            return Regex.Replace(text.Trim(), @"\s+", "");
        }
        public static string XoaKhoangTrang(string text)
        {
            return Regex.Replace(text.Trim(), @"\s+", " ");
        }

        public static string ToTitleCase(string title) // ham vua xoa khoang trang vua chuyen sang chu thuong
        {
                 
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(XoaKhoangTrang(title.ToLower()));
        }

        public static string ToUpperFistCharacter(string text) //ham viet hoa chu thuong thanh chu hoa
        {
            return Capitalize(XoaKhoangTrang(text).ToLower()); //xoa khoang trang va chu sau khoang trang in hoa thanh in thuong
        }

        private static string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}

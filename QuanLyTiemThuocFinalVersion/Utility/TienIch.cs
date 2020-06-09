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
        public static void ShowCanhBao(string tieuDe, string noiDung)
        {
            MessageBox.Show(noiDung, tieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowThanhCong(string tieuDe, string noiDung)
        {
            MessageBox.Show(noiDung, tieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowXacThuc(string tieuDe, string noiDung)
        {
            return MessageBox.Show(noiDung, tieuDe, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void ShowLoi(string tieuDe, string noiDung)
        {
            MessageBox.Show(noiDung, tieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string XoaTatCaKhoangTrang(string text)
        {
            return Regex.Replace(text.Trim(), @"\s+", "");
        }
        public static string XoaKhoangTrang(string text)
        {
            return Regex.Replace(text.Trim(), @"\s+", " ");
        }

        public static string ToTitleCase(string title)
        {

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(XoaKhoangTrang(title.ToLower()));
        }

        public static string ToUpperFistCharacter(string text)
        {
            return Capitalize(XoaKhoangTrang(text).ToLower());
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

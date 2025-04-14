using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_Try.BLL
{
    internal class DatLichBLL
    {
        private static DatLichBLL instance;
        public static DatLichBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatLichBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private DatLichBLL() { }
        public bool ThemDatLich(string bacSiID, int benhNhanID, string hoTen, bool gioiTinh, string sdt, string diaChi, string ghiChu, string ngayHen,string gioDangki)
        {
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu thông tin không hợp lệ
            }
            else if (sdt.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Trả về false nếu thông tin không hợp lệ
            }
            else
            {
                // Chuyển đổi các tham số từ string sang kiểu dữ liệu tương ứng
                int bacSiIDInt = int.Parse(bacSiID);
                DateTime ngayHenDatetime = ngayHen == "" ? DateTime.Now : DateTime.Parse(ngayHen);
                TimeSpan gioDangkiTimespan = TimeSpan.Parse(gioDangki);
                return DAL.DatLichDAL.Instance.ThemDatLich(bacSiIDInt, benhNhanID, hoTen, gioiTinh, sdt, diaChi, ghiChu, ngayHenDatetime, gioDangkiTimespan);
            }
        }
    }
}

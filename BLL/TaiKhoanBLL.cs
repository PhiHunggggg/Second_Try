using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Second_Try.Control;

namespace Second_Try.BLL
{
    internal class TaiKhoanBLL : DataProvider
    {
        private static TaiKhoanBLL instance;
        public static TaiKhoanBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanBLL() { }
        public bool KiemTraTonTaiTenDangNhap(string tenDangNhap)
        {
            string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        public bool ThemTaiKhoanBenhNhan(string username, string password, string loaiTaiKhoan, int benhNhanID)
        {
            if (username == "" || password == "" || loaiTaiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (benhNhanID < 0)
            {
                return false;
            }
            else if (KiemTraTonTaiTenDangNhap(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                TaiKhoanDAL.Instance.ThemTaiKhoan(username, password, loaiTaiKhoan, benhNhanID);
                return true;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;
using Microsoft.Data.SqlClient;

namespace Second_Try.BLL
{
    internal class BacSiBLL:DataProvider
    {
        private static BacSiBLL instance;
        public static BacSiBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BacSiBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BacSiBLL() { }
        public bool SuaBacSy(string bacSiID, string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, string tuoi, string chiPhiKham)
        {
            if (hoTen == "" || sdt == "" || email == "" || trinhDo == "" || chucVu == "" || chiPhiKham == ""||tuoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int tuoiint = Convert.ToInt32(tuoi);
                int bacSiIDint = Convert.ToInt32(bacSiID);
                BacSiDAL.Instance.SuaBacSy(bacSiIDint, hoTen, chuyenKhoaID, sdt, email, trinhDo, chucVu, tuoiint, chiPhiKham);
                return true;
            }
        }
        public bool ThemBacSy(string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, string tuoi, string chiPhiKham)
        {
            if (hoTen == "" ||chuyenKhoaID<0||tuoi ==""|| sdt == "" || email == "" || trinhDo == "" || chucVu == "" || chiPhiKham == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                int tuoiint = Convert.ToInt32(tuoi);
                BacSiDAL.Instance.ThemBacSy(hoTen, chuyenKhoaID, sdt, email, trinhDo, chucVu, tuoiint, chiPhiKham);
                return true;
            }
        }
        public int ThemBacSyReturnID(string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, string tuoi, string chiPhiKham)
        {
            if (hoTen == "" || chuyenKhoaID < 0 || tuoi == "" || sdt == "" || email == "" || trinhDo == "" || chucVu == "" || chiPhiKham == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else
            {
                int tuoiint = Convert.ToInt32(tuoi);
                return BacSiDAL.Instance.ThemBacSyReturnID(hoTen, chuyenKhoaID, sdt, email, trinhDo, chucVu, tuoiint, chiPhiKham);
            }
        }
        public bool KiemTraTonTaiSDT(string sdt)
        {
            string query = "SELECT COUNT(*) FROM BenhNhan WHERE SDT = @SDT";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@SDT", sdt);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
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

    }
}

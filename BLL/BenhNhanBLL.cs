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
    internal class BenhNhanBLL:DataProvider
    {
        private static BenhNhanBLL instance;
        public static BenhNhanBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BenhNhanBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BenhNhanBLL() { }

        public bool SuaBenhNhan(int id, string ten, string diachi, string sdt, DateTime ngaysinh, bool gioitinh)
        {
            if (id == 0 || ten == "" || diachi == "" || sdt == "" || ngaysinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {

                BenhNhanDAL.Instance.SuaThongTinBenhNhan(id,ten,ngaysinh,gioitinh,sdt,diachi);
                return true;
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

        public int ThemBenhNhan(string ten, string diachi, string sdt, DateTime ngaysinh, bool gioitinh)
        {
            if (ten == "" || diachi == "" || sdt == "" || ngaysinh == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else if (KiemTraTonTaiSDT(sdt))
            {
                MessageBox.Show("Số điện thoại đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }else
            {
                int benhnhanID = BenhNhanDAL.Instance.ThemBenhNhan(ten,ngaysinh,gioitinh ,sdt ,diachi);
                return benhnhanID;
            }
        }
    }
}

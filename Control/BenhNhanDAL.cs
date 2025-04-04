using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Second_Try.Model;

namespace Second_Try.Control
{
    internal class BenhNhanDAL:DataProvider
    {
        private static BenhNhanDAL instance;
        public static BenhNhanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BenhNhanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BenhNhanDAL() { }
        #region Suathongtin
        public bool SuaThongTinBenhNhan(int benhNhanID, string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi)
        {
            try
            {
                string query = @"UPDATE BenhNhan 
                         SET HoTen = @HoTen, 
                             NgaySinh = @NgaySinh, 
                             GioiTinh = @GioiTinh, 
                             SDT = @SDT, 
                             DiaChi = @DiaChi 
                         WHERE BenhNhanID = @BenhNhanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu cập nhật thành công, ngược lại false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin bệnh nhân: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion 
        public List<BenhNhan> GetAllBenhNhan()
        {
            List<BenhNhan> danhSachBenhNhan = new List<BenhNhan>();

            try
            {
                string query = "SELECT BenhNhanID, HoTen, NgaySinh, GioiTinh, SDT, DiaChi FROM BenhNhan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BenhNhan benhNhan = new BenhNhan
                            {
                                BenhNhanID = reader.GetInt32(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetBoolean(3),
                                Sdt = reader.GetString(4),
                                Diachi = reader.GetString(5)
                            };
                            danhSachBenhNhan.Add(benhNhan);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách bệnh nhân: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return danhSachBenhNhan;
        }
    }
}

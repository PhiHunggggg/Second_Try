using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Second_Try.Entity;

namespace Second_Try.Control
{
    internal class BenhNhanDAL : DataProvider
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
        #region DanhSachBenhNhan
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
        public List<BenhNhan> GetDanhSachBenhNhanFull()
        {
            List<BenhNhan> danhSachBenhNhan = new List<BenhNhan>();

            try
            {
                string query = @"
        SELECT 
     bn.BenhNhanID,
    bn.HoTen,
    bn.NgaySinh,
    bn.GioiTinh,
    bn.SDT,
    bn.DiaChi,
    tk.TenDangNhap,
    tk.MatKhau,
    tk.TaiKhoanID
FROM 
    BenhNhan bn
LEFT JOIN 
    TaiKhoan tk ON bn.BenhNhanID = tk.BenhNhanID";

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
                                Diachi = reader.GetString(5),
                                TenDangNhap = reader.IsDBNull(6) ? null : reader.GetString(6),
                                MatKhau = reader.IsDBNull(7) ? null : reader.GetString(7),
                                taikhoanID = reader.IsDBNull(8) ? 0 : reader.GetInt32(8)
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
        #endregion
        #region XoaBenhNhan
        public bool XoaBenhNhan(int benhNhanID)
        {
            try
            {
                string query = "DELETE FROM BenhNhan WHERE BenhNhanID = @BenhNhanID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu xóa thành công, ngược lại false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa bệnh nhân: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        #region ThemBenhNhan
        public int ThemBenhNhan(string hoTen, DateTime ngaySinh, bool gioiTinh, string sdt, string diaChi)
        {
            try
            {
                string query = @"INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SDT, DiaChi) VALUES (@HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                    
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bệnh nhân: " + ex.Message);
                return -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion

    }
}

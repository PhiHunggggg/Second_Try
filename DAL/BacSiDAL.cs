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
    internal class BacSiDAL : DataProvider
    {
        private static BacSiDAL instance;
        public static BacSiDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BacSiDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BacSiDAL() { }
        #region LayGiaTriBacSy
        public List<BacSi> GetBacSiByChuyenKhoa(int chuyenKhoaID)
        {
            List<BacSi> danhSachBacSi = new List<BacSi>();

            try
            {
                string query = "SELECT BacSiID, HoTen FROM BacSi WHERE ChuyenKhoaID = @ChuyenKhoaID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", chuyenKhoaID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BacSi bacSi = new BacSi
                            {
                                BacSiID = reader.GetInt32(0),
                                HoTen = reader.GetString(1)
                            };
                            danhSachBacSi.Add(bacSi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách bác sĩ: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return danhSachBacSi;
        }
        public List<BacSi> GetAllBacSi()
        {
            List<BacSi> danhSachBacSi = new List<BacSi>();
            try
            {
                string query = "SELECT BacSiID, HoTen, ChuyenKhoaID,SDT,Email,TrinhDo,ChucVu,Tuoi,ChiPhiKham FROM BacSi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BacSi bacSi = new BacSi
                            {
                                BacSiID = reader.GetInt32(0),
                                HoTen = reader.GetString(1),
                                ChuyenKhoaID = reader.GetInt32(2),
                                SDT = reader.GetString(3),
                                Email = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                ChucVu = reader.GetString(6),
                                Tuoi = reader.GetInt32(7),
                                ChiPhiKham = reader.GetString(8),
                            };
                            danhSachBacSi.Add(bacSi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách bác sĩ : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return danhSachBacSi;
        }
        #endregion
        public bool SuaBacSy(int bacSiID, string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, int tuoi, string chiPhiKham)
        {
            try
            {
                string query = @"UPDATE BacSi 
                                 SET HoTen = @HoTen,
                                     ChuyenKhoaID = @ChuyenKhoaID,
                                     SDT = @SDT,
                                     Email = @Email,
                                     TrinhDo = @TrinhDo,
                                     ChucVu = @ChucVu,
                                     Tuoi = @Tuoi,
                                     ChiPhiKham = @ChiPhiKham
                                 WHERE BacSiID = @BacSiID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", chuyenKhoaID);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TrinhDo", trinhDo);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@Tuoi", tuoi);
                    cmd.Parameters.AddWithValue("@ChiPhiKham", chiPhiKham);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu cập nhật thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật bác sĩ: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public bool ThemBacSy(string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, int tuoi, string chiPhiKham)
        {
            try
            {
                string query = @"INSERT INTO BacSi (HoTen, ChuyenKhoaID, SDT, Email, TrinhDo, ChucVu, Tuoi, ChiPhiKham)
                                 VALUES (@HoTen, @ChuyenKhoaID, @SDT, @Email, @TrinhDo, @ChucVu, @Tuoi, @ChiPhiKham)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", chuyenKhoaID);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TrinhDo", trinhDo);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@Tuoi", tuoi);
                    cmd.Parameters.AddWithValue("@ChiPhiKham", chiPhiKham);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu thêm thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bác sĩ: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //Thêm bác sỹ trả về BacSyID
        public int ThemBacSyReturnID(string hoTen, int chuyenKhoaID, string sdt, string email, string trinhDo, string chucVu, int tuoi, string chiPhiKham)
        {
            try
            {
                string query = @"INSERT INTO BacSi (HoTen, ChuyenKhoaID, SDT, Email, TrinhDo, ChucVu, Tuoi, ChiPhiKham)
                                 VALUES (@HoTen, @ChuyenKhoaID, @SDT, @Email, @TrinhDo, @ChucVu, @Tuoi, @ChiPhiKham);
                                 SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HoTen", hoTen);
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", chuyenKhoaID);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@TrinhDo", trinhDo);
                    cmd.Parameters.AddWithValue("@ChucVu", chucVu);
                    cmd.Parameters.AddWithValue("@Tuoi", tuoi);
                    cmd.Parameters.AddWithValue("@ChiPhiKham", chiPhiKham);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result); // Trả về ID của bác sĩ vừa thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bác sĩ: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool XoaBacSy(int bacSiID)
        {
            try
            {
                string query = "DELETE FROM BacSi WHERE BacSiID = @BacSiID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu xóa thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa bác sĩ: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public List<BacSi> GetDanhSachBacSyFull()
        {
            List<BacSi> danhSachBacSi = new List<BacSi>();

            try
            {
                string query = @"
                 SELECT 
                bs.BacSiID,
                bs.HoTen,
                bs.ChuyenKhoaID,    
                bs.SDT,
                bs.Email,
                bs.TrinhDo,
                bs.ChucVu,
                bs.Tuoi,
                bs.ChiPhiKham,
                tk.TenDangNhap,
                tk.MatKhau,
                tk.TaiKhoanID
                FROM 
                 BacSi bs
                LEFT JOIN 
    TaiKhoan tk ON bs.BacSiID = tk.BacSiID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BacSi bacSi = new BacSi
                            {
                                BacSiID=reader.GetInt32(0),
                                HoTen = reader.GetString(1),
                                ChuyenKhoaID = reader.GetInt32(2),
                                SDT = reader.GetString(3),
                                Email = reader.GetString(4),
                                Trinhdo = reader.GetString(5),
                                ChucVu = reader.GetString(6),
                                Tuoi = reader.GetInt32(7),
                                ChiPhiKham = reader.GetString(8),
                                TenDangNhap = reader.IsDBNull(9) ? null : reader.GetString(9),
                                MatKhau = reader.IsDBNull(10) ? null : reader.GetString(10),
                                taikhoanID = reader.IsDBNull(11) ? 0 : reader.GetInt32(11)
                            };
                            danhSachBacSi.Add(bacSi);
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

            return danhSachBacSi;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using Second_Try.Entity;
using Microsoft.Identity.Client;

namespace Second_Try.Control
{
    internal class TaiKhoanDAL : DataProvider
    {
        private static TaiKhoanDAL instance;
        public static TaiKhoanDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TaiKhoanDAL() { }
        #region Dangnhap
        public string DangNhap(string username, string password)
        {
            try
            {
                OpenConnection();
                string sql = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // Cần mã hóa trong thực tế

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString(); // Trả về loại tài khoản (BacSi, BenhNhan, Admin)
                }
                else
                {
                    return null; // Sai thông tin đăng nhập
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        #endregion
        public void LoadData()
        {
            string sql = "TaiKhoan";
            LoadData(sql);
        }
        public DataTable GetDataTable()
        {
            string sql = "TaiKhoan";
            return LoadData(sql); // LoadData(sql) phải trả về DataTable
        }

        public void AddIntoLk(TaiKhoan LK)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO TaiKhoan(TaiKhoanID,TenDangNhap,MatKhau,LoaiTaiKhoan,BenhNhanID,BacSiID) VALUES (@TaiKhoanID,@TenDangNhap,@MatKhau,@LoaiTaiKhoan,@BenhNhanID,@BacSiID)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.Text;  // Thêm dòng này
                                                         //   command.Parameters.AddWithValue("@MaBS", LK.MaBS);
                command.Parameters.AddWithValue("@TenDangNhap", LK.TenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", LK.MatKhau);
                command.Parameters.AddWithValue("@LoaiTaiKhoan", LK.LoaiTaiKhoan);

                int rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm vào TaiKhoan: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }
        }
        public void DeleteLk(TaiKhoan LK)
        {
            try
            {
                OpenConnection();
                string sql = "DELETE FROM LichKham WHERE TenDangNhap = @TenDangNhap";
                SqlCommand command1 = new SqlCommand(sql, conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@TenDangNhap", LK.TenDangNhap);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa TaiKhoan: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { CloseConnection(); }
            }
        }
        public bool DoiThongTinTaiKhoan(int taiKhoanID, string tenDangNhapMoi, string matKhauMoi)
        {
            try
            {
                string query = @"UPDATE TaiKhoan 
                         SET TenDangNhap = @TenDangNhapMoi, MatKhau = @MatKhauMoi
                         WHERE TaiKhoanID = @TaiKhoanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhapMoi", tenDangNhapMoi);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);  // Nên mã hóa mật khẩu trước khi lưu
                    cmd.Parameters.AddWithValue("@TaiKhoanID", taiKhoanID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi thông tin tài khoản: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public bool DoiThongTinTaiKhoanbyIdBenhNhan(int benhnhanID, string tenDangNhapMoi, string matKhauMoi)
        {
            try
            {
                string query = @"UPDATE TaiKhoan 
                         SET TenDangNhap = @TenDangNhapMoi, MatKhau = @MatKhauMoi
                         WHERE BenhNhanID = @BenhNhanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhapMoi", tenDangNhapMoi);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);  // Nên mã hóa mật khẩu trước khi lưu
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhnhanID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Trả về true nếu có ít nhất 1 dòng bị ảnh hưởng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đổi thông tin tài khoản: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        public int GetTaiKhoanID(string tenDangNhap, string matKhau)
        {
            int taiKhoanID = -1; // Trả về -1 nếu không tìm thấy tài khoản

            try
            {
                string query = @"SELECT TaiKhoanID FROM TaiKhoan 
                         WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau); // Nếu mật khẩu mã hóa, cần xử lý trước

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        taiKhoanID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy ID tài khoản: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return taiKhoanID;
        }
        #region Dangkitaikhoan
        public bool KiemTraTonTaiTaiKhoan(string username)
        {
            try
            {
                OpenConnection();
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @Username";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Trả về true nếu tài khoản đã tồn tại
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra tài khoản: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Hàm đăng ký tài khoản
        public bool DangKy(string username, string password, string loaiTaiKhoan)
        {
            try
            {
                OpenConnection();
                int? benhNhanID = null;
                int? bacSiID = null;
                if (loaiTaiKhoan == "BenhNhan")
                {
                    // Tạo bệnh nhân và lấy ID
                    string sqlBenhNhan = "INSERT INTO BenhNhan (HoTen, NgaySinh, GioiTinh, SDT, DiaChi) OUTPUT INSERTED.BenhNhanID VALUES (@HoTen, @NgaySinh, @GioiTinh, @SDT, @DiaChi)";
                    using (SqlCommand cmd = new SqlCommand(sqlBenhNhan, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", "Bệnh nhân mới");
                        cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Now);
                        cmd.Parameters.AddWithValue("@GioiTinh", 1);
                        cmd.Parameters.AddWithValue("@SDT", new Random().Next(1000000000, 1999999999).ToString());
                        cmd.Parameters.AddWithValue("@DiaChi", "Chưa cập nhật");

                        benhNhanID = (int)cmd.ExecuteScalar();
                    }
                }
                else if (loaiTaiKhoan == "BacSi")
                {

                    // Tạo bác sĩ mới
                    string sqlBacSi = "INSERT INTO BacSi (HoTen, ChuyenKhoaID, SDT, Email) OUTPUT INSERTED.BacSiID VALUES (@HoTen, @ChuyenKhoaID, @SDT, @Email)";
                    using (SqlCommand cmd = new SqlCommand(sqlBacSi, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", "Bác sĩ mới");
                        cmd.Parameters.AddWithValue("@ChuyenKhoaID", 6);
                        cmd.Parameters.AddWithValue("@SDT", new Random().Next(1000000000, 1999999999).ToString());
                        cmd.Parameters.AddWithValue("@Email", username + "@email.com");

                        bacSiID = (int)cmd.ExecuteScalar();
                    }
                }
                // Thêm tài khoản vào bảng TaiKhoan
                string sqlTaiKhoan = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, BenhNhanID, BacSiID) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @BenhNhanID, @BacSiID)";
                using (SqlCommand cmd = new SqlCommand(sqlTaiKhoan, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", username);
                    cmd.Parameters.AddWithValue("@MatKhau", password);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@BenhNhanID", (object)benhNhanID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@BacSiID", (object)bacSiID ?? DBNull.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool DangKiTaiKhoanBacSy(string username, string password, int bacSyID)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, BacSiID) VALUES (@TenDangNhap, @MatKhau, 'BacSi', @BacSiID)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.Parameters.AddWithValue("@BacSiID", bacSyID);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Trả về true nếu thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký tài khoản bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool ThemTaiKhoan(string username, string password, string loaiTaiKhoan, int id)
        {

            try
            {
                string query = "";
                if (loaiTaiKhoan == "BenhNhan")
                {
                    query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, BenhNhanID) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @ID)";
                }
                else
                {
                    query = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, LoaiTaiKhoan, BacSiID) VALUES (@TenDangNhap, @MatKhau, @LoaiTaiKhoan, @ID)";
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenDangNhap", username);
                    cmd.Parameters.AddWithValue("@MatKhau", password);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);
                    cmd.Parameters.AddWithValue("@ID", id);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu thêm thành công, ngược lại false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        #region benhnhanbacssitheoid
        public BenhNhan GetBenhNhanByID(int benhNhanID)
        {
            BenhNhan benhNhan = null;

            try
            {
                string query = @"SELECT BenhNhanID, HoTen, NgaySinh, GioiTinh, SDT, DiaChi 
                         FROM BenhNhan 
                         WHERE BenhNhanID = @BenhNhanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            benhNhan = new BenhNhan
                            {
                                BenhNhanID = reader.GetInt32(0),
                                Hoten = reader.GetString(1),
                                Ngaysinh = reader.GetDateTime(2),
                                Gioitinh = reader.GetBoolean(3), // Nếu lưu dạng BIT (0: Nữ, 1: Nam)
                                Sdt = reader.GetString(4),
                                Diachi = reader.GetString(5)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin bệnh nhân: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return benhNhan;
        }
        public BacSi GetBacSiByID(int bacSyID)
        {
            BacSi bacsi = null;

            try
            {
                string query = @"SELECT BacSiID, HoTen, ChuyenKhoaID, SDT, Email ,TrinhDo,ChucVu,Tuoi,ChiPhiKham
                         FROM BacSi 
                         WHERE BacSiID = @BacSiID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSyID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bacsi = new BacSi
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin bác sỹ : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return bacsi;
        }
        #endregion
        #region LayTaiKhoan
        public int GetBenhNhanID(string username, string password)
        {
            int benhNhanID = -1; // Trả về -1 nếu không tìm thấy

            try
            {
                string query = @"SELECT BenhNhanID 
                         FROM TaiKhoan 
                         WHERE TenDangNhap = @Username AND MatKhau = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password); // 🔴 Nếu cần mã hóa mật khẩu, sửa chỗ này!

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        benhNhanID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập bệnh nhân: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return benhNhanID;
        }
        public TaiKhoan GetTaiKhoanByID(int taiKhoanID)
        {
            TaiKhoan taiKhoan = null; // Nếu không tìm thấy, sẽ trả về null

            try
            {
                string query = @"SELECT TaiKhoanID, TenDangNhap, MatKhau, LoaiTaiKhoan 
                         FROM TaiKhoan 
                         WHERE TaiKhoanID = @TaiKhoanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoanID", taiKhoanID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu có dữ liệu
                        {
                            taiKhoan = new TaiKhoan
                            {
                                TaiKhoanID = reader.GetInt32(0),
                                TenDangNhap = reader.GetString(1),
                                MatKhau = reader.GetString(2),
                                LoaiTaiKhoan = reader.GetString(3) // Ví dụ: 0 - User, 1 - Admin
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin tài khoản: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return taiKhoan;
        }
        #endregion
        #region Xoa
        public bool XoaTaiKhoan(int taiKhoanID)
        {
            try
            {
                string query = "DELETE FROM TaiKhoan WHERE TaiKhoanID = @TaiKhoanID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoanID", taiKhoanID);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu xóa thành công, ngược lại false
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tài khoản: " + ex.Message);
                return false;
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


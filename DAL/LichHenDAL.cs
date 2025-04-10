using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using Second_Try.Entity;

namespace Second_Try.Control
{
    internal class LichHenDAL : DataProvider
    {
        private static LichHenDAL instance;
        public static LichHenDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichHenDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichHenDAL() { }

        #region ThemLichHen
        public int ThemLichHen(int benhNhanID, int bacSiID, DateTime ngayHen, TimeSpan gioHen,string ghiChu,string hotennguoikham,DateTime ngaySinh,string sdt,bool gioiTinh,string diachi)
        {
            int lichHenID = -1;
            try
            {
                string query = @"INSERT INTO LichHen (BenhNhanID, BacSiID, NgayHen, GioHen, TrangThai,GhiChu,HoTenNguoiKham,NgaySinh,SDT,GioiTinh,DiaChi) VALUES (@BenhNhanID, @BacSiID, @NgayHen, @GioHen, 0,@GhiChu,@HoTenNguoiKham,@NgaySinh,@SDT,@GioiTinh,@DiaChi);SELECT SCOPE_IDENTITY();";
            
        using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", ngayHen);
                    cmd.Parameters.AddWithValue("@GioHen", gioHen);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    cmd.Parameters.AddWithValue("@HoTenNguoiKham", hotennguoikham);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diachi);



                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); // Mở kết nối nếu chưa mở

                    object result = cmd.ExecuteScalar(); // Lấy ID vừa thêm

                    if (result != null)
                        lichHenID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đóng kết nối sau khi thực hiện xong
            }

            return lichHenID;
        }
        #endregion
        #region layLichHenBangID
        public List<LichHen> GetLichHenByBenhNhanID(int benhNhanID)
        {
            List<LichHen> danhSachLichHen = new List<LichHen>();

            try
            {
                string query = @"SELECT LichHenID ,BacSiID, NgayHen, GioHen, GioDenThucTe, TrangThai,GhiChu,HoTenNguoiKham,NgaySinh,SDT,GioiTinh,DiaChi
                         FROM LichHen
                         WHERE BenhNhanID = @BenhNhanID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LichHen lichHen = new LichHen
                            {
                                LichHenID = reader.GetInt32(0),
                                BenhNhanID = benhNhanID,
                                BacSiID = reader.GetInt32(1),
                                NgayHen = reader.GetDateTime(2),
                                GioHen = reader.GetTimeSpan(3),
                                GioDenThucTe = reader.IsDBNull(4) ? null : (TimeSpan?)reader.GetTimeSpan(4),
                                TrangThai = reader.GetBoolean(5), // Nếu kiểu bit thì dùng GetBoolean
                                GhiChu = reader.GetString(6),
                                HoTenNguoiKham = reader.GetString(7),
                                NgaySinh = reader.GetDateTime(8),
                                SDT = reader.GetString(9),
                                GioiTinh = reader.GetBoolean(10),
                                DiaChi = reader.GetString(11)
                            };
                            danhSachLichHen.Add(lichHen);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return danhSachLichHen;
        }
        #endregion
        #region SuaLichHen
        public bool SuaLichHen(int lichHenID,DateTime ngayHen, TimeSpan gioHen,
                         string ghiChu, string hotennguoikham, DateTime ngaySinh, string sdt, bool gioiTinh, string diachi)
        {
            try
            {
                string query = @"UPDATE LichHen 
                         SET HoTenNguoiKham = @HoTen, NgayHen = @NgayHen, GioHen = @GioHen, 
                             GhiChu = @GhiChu, NgaySinh = @NgaySinh, 
                             SDT = @SDT, GioiTinh = @GioiTinh, DiaChi = @DiaChi
                         WHERE LichHenID = @LichHenID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);
                    cmd.Parameters.AddWithValue("@HoTen", hotennguoikham);
                    cmd.Parameters.AddWithValue("@NgayHen", ngayHen);
                    cmd.Parameters.AddWithValue("@GioHen", gioHen);
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu);
                    cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", diachi);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu cập nhật thành công, false nếu thất bại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch hẹn: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        #region XoaLichHen
        public bool XoaLichHen(int lichHenID)
        {
            try
            {
                string query = "DELETE FROM LichHen WHERE LichHenID = @LichHenID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu xóa thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lịch hẹn: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        #region Xoa LichHenVaLichLamViec
        public bool XoaLichHenVaLichLamViec(int lichHenID)
        {
            try
            {
                // Xóa lịch làm việc trước để tránh lỗi khóa ngoại
                if (!LichLamViecDAL.Instance.XoaLichLamViec(lichHenID))
                {
                    return false;
                }
                else
                {
                    return XoaLichHen(lichHenID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lịch hẹn và lịch làm việc: " + ex.Message);
                return false;
            }
        }
        #endregion
        public LichHen GetLichHenByID(int lichHenID)
        {
            LichHen lichHen = null;

            try
            {
                string query = @"SELECT LichHenID, BacSiID, NgayHen, GioHen, GhiChu, HoTenNguoiKham 
                         FROM LichHen 
                         WHERE LichHenID = @LichHenID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lichHen = new LichHen
                            {
                                LichHenID = reader.GetInt32(0),
                                BacSiID = reader.GetInt32(1),
                                NgayHen = reader.GetDateTime(2),
                                GioHen = reader.GetTimeSpan(3),
                                GhiChu = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                HoTenNguoiKham = reader.GetString(5)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy lịch hẹn: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return lichHen;
        }
    }

}

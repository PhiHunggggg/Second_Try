using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Try.Control;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Second_Try.Entity;

namespace Second_Try.DAL
{
    internal class DatLichDAL:DataProvider
    {
        private static DatLichDAL instance;
        public static DatLichDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatLichDAL();
                return instance;
            }
        }
        private DatLichDAL() { }

        //Thêm lịch
        public bool ThemDatLich(int bacSiID, int benhNhanID, string hoTen, bool gioiTinh, string sdt, string diaChi, string ghiChu, DateTime ngayHen, TimeSpan gioDangki)
        {
            int lichHenID = -1;
            DateTime thoiGian = DateTime.Now; // Lấy thời gian hiện tại
            try
            {
                string query = @"
            INSERT INTO DatLich 
            (BacSiID, BenhNhanID, HoTen, GioiTinh, SDT, DiaChi, GhiChu, NgayHen, GioDangKi,ThoiGian)
            VALUES (@BacSiID, @BenhNhanID, @HoTen, @GioiTinh, @SDT, @DiaChi, @GhiChu, @NgayHen, @GioDangKi,@ThoiGian);
            SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thay đổi kiểu dữ liệu của các tham số
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID); // Thêm bác sĩ
                    cmd.Parameters.AddWithValue("@BenhNhanID", benhNhanID); // Thêm bệnh nhân
                    cmd.Parameters.AddWithValue("@HoTen", hoTen); // Thêm ngày hẹn
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh); // Thêm giờ đăng kí
                    cmd.Parameters.AddWithValue("@SDT", sdt); // Thêm ghi chú
                    cmd.Parameters.AddWithValue("@DiaChi", diaChi); // Thêm họ tên người khám
                    cmd.Parameters.AddWithValue("@GhiChu", ghiChu); // Thêm số điện thoại
                    cmd.Parameters.AddWithValue("@NgayHen", ngayHen); // Thêm giới tính
                    cmd.Parameters.AddWithValue("@GioDangKi", gioDangki); // Thêm địa chỉ
                    cmd.Parameters.AddWithValue("@ThoiGian", thoiGian); // Thêm thời gian hiện tại
                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); // Mở kết nối nếu chưa mở

                    object result = cmd.ExecuteScalar(); // Lấy ID vừa thêm

                    if (result != null)
                        lichHenID = Convert.ToInt32(result); // Chuyển kết quả thành ID vừa thêm
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

            return lichHenID > 0; // Nếu ID hợp lệ thì trả về true
        }
        //Lấy danh sách lịch hẹn theo bác sỹ
        public List<DatLich> GetLichHenByBacSiID(int bacSiID,DateTime ngayHen,TimeSpan gioDangKi)
        {
            List<DatLich> danhSachLichHen = new List<DatLich>();
            try
            {
                string query = "SELECT * FROM DatLich WHERE BacSiID = @BacSiID AND NgayHen=@NgayHen AND GioDangKi=@GioDangKi";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", ngayHen);
                    cmd.Parameters.AddWithValue("@GioDangKi", gioDangKi);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DatLich lichHen = new DatLich
                        {
                            DatLichID = reader.GetInt32(0),
                            BacSiID = reader.GetInt32(1),
                            BenhNhanID = reader.GetInt32(2),
                            HoTen = reader.GetString(3),
                            GioiTinh = reader.GetBoolean(4),
                            Sdt = reader.GetString(5),
                            DiaChi = reader.GetString(6),
                            GhiChu = reader.GetString(7),
                            NgayHen = reader.GetDateTime(8),
                            GioDangki = reader.GetTimeSpan(9),
                            ThoiGian = reader.GetDateTime(10),
                            KhanCap = reader.IsDBNull(11) ? false : reader.GetBoolean(11),
                            TrangThai = reader.IsDBNull(12) ? false : reader.GetBoolean(12)
                        };
                        danhSachLichHen.Add(lichHen);
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
        public bool CheckCaTrungDatLich(int bacSiID, DateTime ngayCheck, TimeSpan gioCheck)
        {
            bool isOverlap = false;

            try
            {
                string query = @"
                 SELECT COUNT(*) 
                 FROM DatLich 
                 WHERE BacSiID = @BacSiID 
                 AND CAST(NgayHen AS DATE) = @NgayCheck 
                AND GioDangKi = @GioDangKi
                 AND (TrangThai = 0 OR TrangThai IS NULL)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.Add("@NgayCheck", SqlDbType.Date).Value = ngayCheck.Date;
                    cmd.Parameters.AddWithValue("@GioDangKi", gioCheck);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); // Mở kết nối trước khi thực thi truy vấn

                    object result = cmd.ExecuteScalar(); // Lấy kết quả trả về từ SQL

                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        isOverlap = (count > 0); // Nếu count > 0 thì có ca trùng
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra trùng ca: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đóng kết nối SQL
            }

            return isOverlap;  // Trả về true nếu có ca trùng, false nếu không
        }
        public bool XacNhanLichHen(int datLichID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string getQuery = "SELECT * FROM DatLich WHERE DatLichID = @DatLichID";
                DatLich lich = null;

                using (SqlCommand cmd = new SqlCommand(getQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DatLichID", datLichID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lich = new DatLich
                            {
                                DatLichID = reader.GetInt32(0),
                                BacSiID = reader.GetInt32(1),
                                BenhNhanID = reader.GetInt32(2),
                                HoTen = reader.GetString(3),
                                GioiTinh = reader.GetBoolean(4),
                                Sdt = reader.GetString(5),
                                DiaChi = reader.GetString(6),
                                GhiChu = reader.GetString(7),
                                NgayHen = reader.GetDateTime(8),
                                GioDangki = reader.GetTimeSpan(9)
                            };
                        }
                    }
                }

                if (lich == null)
                {
                    MessageBox.Show("Không tìm thấy lịch hẹn!");
                    return false;
                }

                // 2. Cập nhật trạng thái lịch trong DatLich
                string updateQuery = "UPDATE DatLich SET TrangThai = 1 WHERE DatLichID = @DatLichID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@DatLichID", datLichID);
                    cmd.ExecuteNonQuery();
                }

                // 3. Thêm vào LichHen và lấy lại LichHenID
                string insertLichHen = @"
            INSERT INTO LichHen (BacSiID, BenhNhanID, NgayHen, GioHen, GhiChu, HoTenNguoiKham, SDT, GioiTinh, DatLichID)
            OUTPUT INSERTED.LichHenID
            VALUES (@BacSiID, @BenhNhanID, @NgayHen, @GioHen, @GhiChu, @HoTenNguoiKham, @SoDienThoai, @GioiTinh, @DatLichID)";

                int lichHenID = -1;
                using (SqlCommand cmd = new SqlCommand(insertLichHen, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                    cmd.Parameters.AddWithValue("@BenhNhanID", lich.BenhNhanID);
                    cmd.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                    cmd.Parameters.AddWithValue("@GioHen", lich.GioDangki);
                    cmd.Parameters.AddWithValue("@GhiChu", (object)lich.GhiChu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HoTenNguoiKham", lich.HoTen);
                    cmd.Parameters.AddWithValue("@SoDienThoai", lich.Sdt);
                    cmd.Parameters.AddWithValue("@GioiTinh", lich.GioiTinh);
                    cmd.Parameters.AddWithValue("@DatLichID", lich.DatLichID);

                    lichHenID = (int)cmd.ExecuteScalar();
                }

                // 4. Thêm vào LichLamViec nếu chưa có
                string checkLichLamViec = @"
        SELECT COUNT(*) FROM LichLamViec 
        WHERE BacSiID = @BacSiID AND Ngay = @NgayHen AND GioBatDau = @GioHen";

                using (SqlCommand cmd = new SqlCommand(checkLichLamViec, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                    cmd.Parameters.AddWithValue("@GioHen", lich.GioDangki);                    
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0 && lichHenID > 0)
                    {
                        string insertLichLamViec = @"
                INSERT INTO LichLamViec (BacSiID, Ngay, GioBatDau, LichHenID)
                VALUES (@BacSiID, @NgayHen, @GioHen, @LichHenID)";

                        using (SqlCommand cmdInsert = new SqlCommand(insertLichLamViec, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@BacSiID", lich.BacSiID);
                            cmdInsert.Parameters.AddWithValue("@NgayHen", lich.NgayHen.Date);
                            cmdInsert.Parameters.AddWithValue("@GioHen", lich.GioDangki);
                            cmdInsert.Parameters.AddWithValue("@LichHenID", lichHenID);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xác nhận lịch: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

    }
}

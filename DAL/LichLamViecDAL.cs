using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Second_Try.Control
{
    internal class LichLamViecDAL : DataProvider
    {
        private static LichLamViecDAL instance;
        public static LichLamViecDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichLamViecDAL();
                }
                return instance;
            }
            private set => instance = value;
        }

        private LichLamViecDAL() { }
        #region CheckLichLamViec
        public bool CheckTrangThai(int bacSiID, DateTime ngayCheck, bool caCheck)
        {
            bool trangThaiRanh = false;

            try
            {
                string query = @"SELECT COUNT(*) 
                         FROM LichLamViec 
                         WHERE BacSiID = @BacSiID 
                               AND Ngay = @NgayCheck 
                               AND CaLamViec = @CaCheck 
                               AND TrangThai = 0";  // Kiểm tra bác sĩ có rảnh hay không

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@NgayCheck", ngayCheck);
                    cmd.Parameters.AddWithValue("@CaCheck", caCheck ? 1 : 0); // Convert bool thành 1 hoặc 0

                    if (conn.State == ConnectionState.Closed)
                        conn.Open(); // Mở kết nối trước khi thực thi truy vấn

                    object result = cmd.ExecuteScalar(); // Lấy kết quả trả về từ SQL

                    if (result != null && int.TryParse(result.ToString(), out int count))
                    {
                        trangThaiRanh = (count == 0); // Nếu count = 0, tức là bác sĩ rảnh
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra trạng thái bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close(); // Đóng kết nối SQL
            }

            return trangThaiRanh;
        }
        #endregion
        #region ThemLichLamViec
        public bool ThemLichLamViec(int bacSiID, DateTime ngay, TimeSpan gioBatDau, TimeSpan gioKetThuc, bool trangThai, bool caLamViec, int lichHenID)
        {
            try
            {
                string query = @"INSERT INTO LichLamViec (BacSiID, Ngay, GioBatDau, GioKetThuc, TrangThai, CaLamViec, LichhenID)
                         VALUES (@BacSiID, @Ngay, @GioBatDau, @GioKetThuc, @TrangThai, @CaLamViec, @LichHenID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@Ngay", ngay);
                    cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@GioKetThuc", gioKetThuc);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@CaLamViec", caLamViec);
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0; // Trả về true nếu thêm thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lịch làm việc: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        #region SuaLichLamViec
        public bool SuaLichLamViec(int lichHenID, DateTime ngay, TimeSpan gioBatDau, bool caLamViec)
        {
            try
            {
                string query = @"UPDATE LichLamViec 
                         SET Ngay = @NgayHen, GioBatDau = @GioBatDau, CaLamViec = @CaLamViec
                         WHERE LichHenID = @LichHenID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);
                    cmd.Parameters.AddWithValue("@NgayHen", ngay);
                    cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@CaLamViec", caLamViec);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu cập nhật thành công, false nếu thất bại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch làm việc: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #endregion
        public bool SuaLichLamViecPlus(int lichHenID,int bacSiID, DateTime ngay, TimeSpan gioBatDau, TimeSpan? gioKetThuc, bool trangThai, bool caLamViec)
        {
            try
            {
                string query = @"UPDATE LichLamViec 
                         SET BacSiID=@BacSiID,Ngay = @NgayHen, GioBatDau = @GioBatDau, GioKetThuc = @GioKetThuc, TrangThai = @TrangThai, CaLamViec = @CaLamViec
                         WHERE LichHenID = @LichHenID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LichHenID", lichHenID);
                    cmd.Parameters.AddWithValue("@BacSiID", bacSiID);
                    cmd.Parameters.AddWithValue("@NgayHen", ngay);
                    cmd.Parameters.AddWithValue("@GioBatDau", gioBatDau);
                    cmd.Parameters.Add("@GioKetThuc", SqlDbType.Time).Value = gioKetThuc.HasValue ? (object)gioKetThuc.Value : DBNull.Value;
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai);
                    cmd.Parameters.AddWithValue("@CaLamViec", caLamViec);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0; // Trả về true nếu cập nhật thành công
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lịch làm việc: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        #region XoaLichLamViec
        public bool XoaLichLamViec(int lichHenID)
        {
            try
            {
                string query = "DELETE FROM LichLamViec WHERE LichHenID = @LichHenID";

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
                MessageBox.Show("Lỗi khi xóa lịch làm việc: " + ex.Message);
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

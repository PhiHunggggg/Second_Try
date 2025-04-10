using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Second_Try.Entity;

namespace Second_Try.Control
{
    internal class LichKhamDAL : DataProvider
    {
        private static LichKhamDAL instance;
        public static LichKhamDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichKhamDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichKhamDAL() { }

        public void LoadData()
        {
            string sql = "LichKham";
            LoadData(sql);
        }
        public DataTable GetDataTable()
        {
            string sql = "LichKham";
            return LoadData(sql); // LoadData(sql) phải trả về DataTable
        }
        public void AddIntoLk(LichKham LK)
        {
            try
            {
                OpenConnection();
                string sql = "INSERT INTO LichKham(NgayKham,GioBatDau,GioKetThuc,TrangThai) VALUES (@NgayKham,@GioBatDau,@GioKetThuc,@TrangThai)";
                SqlCommand command = new SqlCommand(sql, conn);
                command.CommandType = CommandType.Text;  // Thêm dòng này
             //   command.Parameters.AddWithValue("@MaBS", LK.MaBS);
                command.Parameters.AddWithValue("@NgayKham", LK.NgayKham);
                command.Parameters.AddWithValue("@GioBatDau", LK.GioBatDau);
                command.Parameters.AddWithValue("@GioKetThuc", LK.GioKetThuc);
                command.Parameters.AddWithValue("@TrangThai", LK.TrangThai);

                int rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm vào LichKham: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    CloseConnection();
                }
            }
        }
        public void DeleteLk(LichKham LK)
        {
            try
            {
                OpenConnection();
                string sql = "DELETE FROM LichKham WHERE MaLich = @MaLich";
                SqlCommand command1 = new SqlCommand(sql, conn);
                command1.CommandType = CommandType.Text;
                command1.Parameters.AddWithValue("@MaLich", LK.MaLich);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa LichKham: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                { CloseConnection(); }
            }
            }
        }
}

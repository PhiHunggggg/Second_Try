using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;
using Second_Try.Entity;
using Microsoft.Data.SqlClient;

namespace Second_Try.DAL
{
    internal class ChuyenKhoaDAL : DataProvider
    {
        private static ChuyenKhoaDAL instance;
        public static ChuyenKhoaDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenKhoaDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private ChuyenKhoaDAL() { }
        public ChuyenKhoa GetChuyenKhoaByID(int id)
        {
            ChuyenKhoa chuyenKhoa = null;
            try
            {
                string query = @"SELECT TenChuyenKhoa FROM ChuyenKhoa WHERE ChuyenKhoaID = @ChuyenKhoaID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", id);

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            chuyenKhoa = new ChuyenKhoa
                            {
                                ChuyenKhoaID = id,
                                TenChuyenKhoa = reader.GetString(0)
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin chuyên khoa: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

            return chuyenKhoa;

        }
        //Lấy danh sách chuyên khoa
        public List<ChuyenKhoa> GetDanhSachChuyenKhoa()
        {
            List<ChuyenKhoa> list = new List<ChuyenKhoa>();
            try
            {
                string query = "SELECT * FROM ChuyenKhoa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChuyenKhoa chuyenKhoa = new ChuyenKhoa
                            {
                                ChuyenKhoaID = reader.GetInt32(0),
                                TenChuyenKhoa = reader.GetString(1)
                            };
                            list.Add(chuyenKhoa);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách chuyên khoa: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return list;
        }
        //Thêm chuyên khoa
        public bool AddChuyenKhoa(ChuyenKhoa chuyenKhoa)
        {
            try
            {
                string query = @"INSERT INTO ChuyenKhoa (TenChuyenKhoa) VALUES (@TenChuyenKhoa)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenChuyenKhoa", chuyenKhoa.TenChuyenKhoa);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chuyên khoa: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        //Sửa chuyên khoa
        public bool SuaChuyenKhoa(int idChuyenkhoa,string tenChuyenkhoa)
        {
            try
            {
                string query = @"UPDATE ChuyenKhoa SET TenChuyenKhoa = @TenChuyenKhoa WHERE ChuyenKhoaID = @ChuyenKhoaID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", idChuyenkhoa);
                    cmd.Parameters.AddWithValue("@TenChuyenKhoa", tenChuyenkhoa);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa chuyên khoa: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
        //Xóa chuyên khoa
        public bool XoaChuyenKhoa(int idChuyenkhoa)
        {
            try
            {
                string query = @"DELETE FROM ChuyenKhoa WHERE ChuyenKhoaID = @ChuyenKhoaID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChuyenKhoaID", idChuyenkhoa);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chuyên khoa: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        //Kiểm tra chuyên khoa có đang được sử dụng không
        public bool CheckChuyenKhoaExist(string tenChuyenKhoa)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM ChuyenKhoa WHERE TenChuyenKhoa = @TenChuyenKhoa";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenChuyenKhoa", tenChuyenKhoa);
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra chuyên khoa: " + ex.Message);
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

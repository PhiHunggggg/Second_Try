using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Second_Try.Model;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace Second_Try.Control
{
    internal class BacSiDAL:DataProvider
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

    }
}

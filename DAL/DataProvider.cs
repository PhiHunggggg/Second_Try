using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Identity.Client;
using System.Windows.Forms;

namespace Second_Try.Control
{
    internal class DataProvider : SQLConnection
    {
        public DataTable LoadData(string tableName)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                string sql = "SELECT * FROM ["+ tableName +"]" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 555: " + ex.Message, "Thông báo", MessageBoxButtons.OKCancel);
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
    }
}

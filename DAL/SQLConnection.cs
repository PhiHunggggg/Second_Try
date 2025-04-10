﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System.Windows.Forms;


namespace Second_Try.Control
{
    internal class SQLConnection
    {
        #region Properties
        string StrCon = @"Data Source=PHIHUNG\SQLEXPRESS01;Initial Catalog=QuanLyLichKham;Integrated Security=True;Trust Server Certificate=True";
        public SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        #endregion
        #region Connection
        public SQLConnection()
        {
            try
               {
                conn = new SqlConnection(StrCon);
            }
            catch
                {
                MessageBox.Show("Mất kết nối đến cơ sở dữ liệu111!", "Thông báo", MessageBoxButtons.OKCancel);
                return;
                }
                
            }
        #endregion
        #region Open
        public void OpenConnection()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mất kết nối đến cơ sở dữ liệu222!", "Thông báo", MessageBoxButtons.OKCancel);
                throw ex;
            }
        }
        #endregion
        #region CLose
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.DAL;
using Second_Try.GUI.BenhNhan;

namespace Second_Try
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /**/
            while (true)
            {
                using (loginForm lg = new loginForm())
                {
                    DialogResult result = lg.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (LoaiTaiKhoanHienTai.loataikhoan == "BenhNhan")
                        {
                            using (mainForm mf = new mainForm())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else if (LoaiTaiKhoanHienTai.loataikhoan == "Admin")
                        {
                            using (mainForm2 mf = new mainForm2())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else if (LoaiTaiKhoanHienTai.loataikhoan == "BacSi")
                        {
                            using (mainForm3 mf = new mainForm3())
                            {
                                if (mf.ShowDialog() == DialogResult.Cancel)
                                {
                                    continue;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không hợp lệ.");
                            continue;
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                  
            }
              //  Application.Run(new frmLichplus());
        }
    }
}

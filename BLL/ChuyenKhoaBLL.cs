using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.DAL;
using Second_Try.Entity;

namespace Second_Try.BLL
{
    internal class ChuyenKhoaBLL
    {
        private static ChuyenKhoaBLL instance;
        public static ChuyenKhoaBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChuyenKhoaBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private ChuyenKhoaBLL() { }
        //check xem chuyen khoa có tồn tại hay không

        public bool ThemChuyenKhoa(string tenChuyenKhoa)
        {
            if (ChuyenKhoaDAL.Instance.CheckChuyenKhoaExist(tenChuyenKhoa))
            {
                MessageBox.Show("Chuyên khoa đã tồn tại");
                return false;
            }
            else
            {
                ChuyenKhoa chuyenKhoa = new ChuyenKhoa();
                chuyenKhoa.TenChuyenKhoa = tenChuyenKhoa;
                return ChuyenKhoaDAL.Instance.AddChuyenKhoa(chuyenKhoa);

            }
        }
    }
}

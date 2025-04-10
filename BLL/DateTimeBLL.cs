using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;

namespace Second_Try.BLL
{
    internal class DateTimeBLL
    {
        private static DateTimeBLL instance;

        public static DateTimeBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DateTimeBLL();
                return instance;
            }
            private set => instance = value;
        }
        private DateTimeBLL() { }
        public DateTime GetDate()
        {
            DateTime dt = DateTimeDAL.Instance.GetDate();
            return DateTime.Now;
        }
        public string ChuyenNgayThangThanhString()
        {
            DateTime dt = DateTimeDAL.Instance.GetDate();
            string s = dt.ToString("dd/MM/yyyy");
            return s;
        }
        public bool CheckDate(DateTime dt)
        {
            DateTime today = DateTimeDAL.Instance.GetDate();
            if (dt < today)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool CheckWeekend(DateTime dt)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday)
                return true;
            return false;
        }
    }
}

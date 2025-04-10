using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Try.Control
{
    internal class DateTimeDAL
    {
        public DateTime GetDate( )
        {
            return DateTime.Now;
        }
        private static DateTimeDAL instance;
        public static DateTimeDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DateTimeDAL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private    DateTimeDAL() { }
        public DateTime NextTime(DateTime today,int a)
        {
            return today.AddDays(a);
        }

    }
}

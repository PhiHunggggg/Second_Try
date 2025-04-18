using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Second_Try.Control;

namespace Second_Try.BLL
{
    internal class LichHenBLL
    {
        private static LichHenBLL instance;
        public static LichHenBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LichHenBLL();
                }
                return instance;
            }
            private set => instance = value;
        }
        private LichHenBLL() { }
        public bool SuaLichHen(string lichHenID, string bacSiID, DateTime ngayHen, TimeSpan gioHen, TimeSpan? gioDenThucTe, bool trangThai, string ghiChu,string diaChi, string hotennguoikham, string sdt, bool gioiTinh, string diachi,bool ca)
        {
            if (bacSiID == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (lichHenID == "")
            {
                MessageBox.Show("Vui lòng chọn lịch hẹn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
      
            else
            {
        
                int lichHenIDint = Convert.ToInt32(lichHenID);
                int bacSiIDint = Convert.ToInt32(bacSiID);
                if((gioHen>new TimeSpan(11,0,0)|| gioHen<new TimeSpan(7,0,0))&&ca==true)
                {
                    MessageBox.Show("Giờ hẹn không hợp lệ1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if((gioHen<new TimeSpan(13,0,0)||gioHen>new TimeSpan(15,0,0))&&ca==false)
                {
                    MessageBox.Show("Giờ hẹn không hợp lệ2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(gioDenThucTe != null && (gioDenThucTe.Value.Hours > 12 || gioDenThucTe.Value.Hours < 7) && ca == true)
                {
                    MessageBox.Show("Giờ đến thực tế không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (gioDenThucTe != null && (gioDenThucTe.Value.Hours < 14 || gioDenThucTe.Value.Hours > 17) && ca == false)
                {
                    MessageBox.Show("Giờ đến thực tế không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                /*if(gioHen<DateTime.Now.TimeOfDay && ngayHen.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Giờ hẹn không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if(ngayHen.Date < DateTime.Now.Date)
                {
                    MessageBox.Show("Ngày hẹn không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }*/
                LichHenDAL.Instance.SuaLichHen2(lichHenIDint,bacSiIDint, ngayHen, gioHen, gioDenThucTe,trangThai,ghiChu,hotennguoikham,sdt,gioiTinh,diaChi);
                return true;
            }
        }
    }
}

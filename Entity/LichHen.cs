using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Try.Entity
{
    internal class LichHen
    {
        public LichHen() { }
        public LichHen(int lichhenid, int benhnhanid, int bacsiid, DateTime ngayhen, TimeSpan giohen,TimeSpan? giodenthucte, bool trangthai, string ghiChu, string hotennguoikham, DateTime ngaySinh, string sdt, bool gioiTinh, string diachi)
        {
            this.LichHenID = lichhenid;
            this.BenhNhanID = benhnhanid;
            this.BacSiID = bacsiid;
            this.NgayHen = ngayhen;
            this.GioHen = giohen;
            this.GioDenThucTe = giodenthucte; // CÓ THỂ NHẬN NULL
            this.TrangThai = trangthai;
            this.GhiChu = ghiChu;
            this.HoTenNguoiKham = hotennguoikham;
            this.NgaySinh = ngaySinh;
            this.SDT = sdt;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diachi;
        }
        private int lichhenid;
        public int LichHenID { get => lichhenid; set => lichhenid = value; }
        public string BacSiHoTen { get; set; } // Thêm thuộc tính này
        public string HoTenNguoiKham { get => hotennguoikham; set => hotennguoikham = value; }
        public string GioiTinhString
        {
            get { return GioiTinh ? "Nam" : "Nữ"; }
        }
        private DateTime ngaysinh;
        public DateTime NgaySinh { get => ngaysinh; set => ngaysinh = value; }
        private string Sdt;
        public string SDT { get => Sdt; set => Sdt = value; }
        private bool gioitinh;
        public bool GioiTinh { get => gioitinh; set => gioitinh = value; }
        private string diachi;
        public string DiaChi { get => diachi; set => diachi = value; }
      
        
        private int benhnhanid;
        public int BenhNhanID { get => benhnhanid; set => benhnhanid = value; }
        private int bacsiid;
        public int BacSiID { get => bacsiid; set => bacsiid = value; }
        private DateTime ngayhen;
        public DateTime NgayHen { get => ngayhen; set => ngayhen = value; }
        private TimeSpan giohen;
        public TimeSpan GioHen { get => giohen; set => giohen = value; }
        private TimeSpan? giodenthucte;
        public TimeSpan? GioDenThucTe { get => giodenthucte; set => giodenthucte = value; }
        private bool trangthai;
        public bool TrangThai { get => trangthai; set => trangthai = value; }
        private string ghiChu;
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        private string hotennguoikham;
        



    }
}

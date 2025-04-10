using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Try.Entity
{
    internal class LichLamViec
    {
        public LichLamViec() { }
        public LichLamViec(int lichid, int bacsiid, DateTime ngay, DateTime giobatdau, DateTime gioketthuc ,string trangthai)
        {
            this.LichID = lichid;
            this.BacSiID = bacsiid;
            this.Ngay = ngay;
            this.GioBatDau = giobatdau;
            this.GioKetThuc = gioketthuc;
            this.TrangThai = trangthai;
        }
        private int lichid;
        public int LichID { get => lichid; set => lichid = value; }
        private int bacsiid;
        public int BacSiID { get => bacsiid; set => bacsiid = value; }
        private DateTime ngaylamviec;
        public DateTime Ngay { get => ngaylamviec; set => ngaylamviec = value; }
        private DateTime giobatdau;
        public DateTime GioBatDau { get => giobatdau; set => giobatdau = value; }
        private DateTime gioketthuc;
        public DateTime GioKetThuc { get => gioketthuc; set => gioketthuc = value; }
        private string trangthai;
        public string TrangThai { get => trangthai; set => trangthai = value; }
    }
}

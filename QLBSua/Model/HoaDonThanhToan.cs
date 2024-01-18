using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class HoaDonThanhToan
    {
        public int matk { get; set; }
        public string tensp { get; set; }
        public double gia { get; set; }
        public int giamgia { get; set; }
        public int soluongmua { get; set; }
        public int mahd { get; set; }
        public bool damua { get; set; } 
        public double thanhtien { get; set; }
        public DateTime ngaymua { get; set; }
        public HoaDonThanhToan() { }
        public HoaDonThanhToan(int matk, string tensp, double gia, int giamgia, int soluongmua, int mahd, bool damua, double thanhtien, DateTime ngaymua)
        {
            this.matk = matk;
            this.tensp = tensp;
            this.gia = gia;
            this.giamgia = giamgia;
            this.soluongmua = soluongmua;
            this.mahd = mahd;
            this.damua = damua;
            this.thanhtien = thanhtien;
            this.ngaymua = ngaymua;
        }

        public HoaDonThanhToan(DateTime ngaymua)
        {
            this.ngaymua = ngaymua;
        }

        public string toString()
        {
            return "hoadonthanhtoanbean [matk=" + matk + ", tensp=" + tensp + ", gia=" + gia + ", soluongmua="
                    + soluongmua + ", mahd=" + mahd + ", damua= " + damua + ", thanhtien=" + thanhtien + ", ngaymua=" + ngaymua + "]";
        }
    }
}

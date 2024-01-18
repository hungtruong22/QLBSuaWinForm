using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class SanPham
    {
        public string masp {  get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public double gia { get; set; }
        public int giamgia { get; set; }
        public string anh { get; set; }
        public string maloai { get; set; }
        public string tenloai { get; set; }

        public SanPham() { }
        public SanPham(string masp, string tensp, int soluong, double gia, int giamgia,
           string anh, string maloai, string tenloai)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.soluong = soluong;
            this.gia = gia;
            this.anh = anh;
            this.giamgia = giamgia;
            this.maloai = maloai;
            this.tenloai = tenloai;
        }
        public String toString()
        {
            return "sanphambean [masp=" + masp + ", tensp=" + tensp + ", soluong=" + soluong + ", gia=" + gia + "" +
                ", giamgia=" + giamgia +"anh = " + anh + ", maloai= " + maloai + ", tenloai=" + tenloai +"]";
        }
    }
}

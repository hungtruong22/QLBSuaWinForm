using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class ThongKe
    {
        public string tensp { get; set; }
        public double gia { get; set; }
        public int tongslmua { get; set; }
        public ThongKe() { }
        public ThongKe(string tensp, double gia, int tongslmua)
        {
            this.tensp = tensp;
            this.gia = gia;
            this.tongslmua = tongslmua;
        }
        public string toString()
        {
            return "thongke = [tensp= " + tensp + ",gia = " + gia + ",tongslmua= " + tongslmua +"]";
        }
    }
}

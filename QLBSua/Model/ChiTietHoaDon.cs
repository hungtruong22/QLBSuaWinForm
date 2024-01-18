using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class ChiTietHoaDon
    {
        public int macthd { get; set; }
        public string masp { get; set; }
        public string tensp { get; set;}
        public int soluongmua { get; set; }
        public int mahd { get; set; }
        public bool damua { get; set; }
        public ChiTietHoaDon() { }
        public ChiTietHoaDon(int macthd, string masp, string tensp, int soluongmua, int mahd, bool damua)
        {
            this.macthd = macthd;
            this.masp = masp;
            this.tensp = tensp;
            this.soluongmua = soluongmua;
            this.mahd = mahd;
            this.damua = damua;
        }

        public ChiTietHoaDon(int macthd, int mahd, bool damua)
        {
            this.macthd = macthd;
            this.mahd = mahd;
            this.damua = damua;
        }

        public string toString()
        {
            return "chitiethoadonbean [macthd=" + macthd + ", masp=" + masp + ", tensp=" + tensp
                    + ", soluongmua=" + soluongmua + ", mahd=" + mahd + ", damua=" + damua + "]";
        }
    }
}

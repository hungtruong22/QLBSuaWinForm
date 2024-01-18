using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class HoaDon
    {
        public int mahd { get; set; }
        public int matk { get; set; }
        public DateTime ngaymua { get; set; }   
        public bool damua { get; set; }
        public HoaDon() { }
        public HoaDon(int mahd, int matk, DateTime ngaymua, bool damua)
        {
            this.mahd = mahd;
            this.matk = matk;
            this.ngaymua = ngaymua;
            this.damua = damua;
        }
        public string toString()
        {
            return "hoadonbean [mahd=" + mahd + ", matk=" + matk + ", ngaymua=" + ngaymua + ", damua=" + damua + "]";
        }
    }
}

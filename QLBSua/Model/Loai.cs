using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class Loai
    {
        public string maloai { get; set; }
        public string tenloai { get; set; }

        public Loai() { }
        public Loai(string maloai, string tenloai)
        {
            this.maloai = maloai;
            this.tenloai = tenloai;
        }
        public String toString()
        {
            return "loaibean [maloai=" + maloai + ", tenloai=" + tenloai + "]";
        }
    }
}

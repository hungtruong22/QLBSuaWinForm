using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Model
{
    public class TaiKhoan
    {
        public int matk {  get; set; }
        public string email { get; set; }
        public string tendn { get; set; }
        public string matkhau { get; set; }
        public bool isAdmin { get; set; }
        public string trangthai { get; set; }

        public TaiKhoan() { }

        public TaiKhoan(int matk, string email, string tendn, string matkhau, bool isAdmin, string trangthai)
        {
            this.matk = matk;
            this.email = email;
            this.tendn = tendn;
            this.matkhau = matkhau;
            this.isAdmin = isAdmin;
            this.trangthai = trangthai;
        }
        public String toString()
        {
            return "taikhoanbean [matk=" + matk + ", tendn=" + tendn + ", matkhau=" + matkhau + ", isAdmin=" + isAdmin +", trangthai= " + trangthai+"]";
        }
    }
}

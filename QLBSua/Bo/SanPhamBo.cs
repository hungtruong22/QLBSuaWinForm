using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class SanPhamBo
    {
        SanPhamDao spdao = new SanPhamDao();
        public List<SanPham> getSP()
        {
            return spdao.getSP();
        }
        public List<SanPham> getSPByLoai(string tenloai)
        {
            return spdao.getSPByLoai(tenloai);
        }
        public void ThemSP(string spid, string spname, int sl, double giasp,
            int giamgiasp, string anhsp, string maloaisp, string tenloaisp)
        {
            spdao.ThemSP(spid, spname, sl, giasp, giamgiasp, anhsp, maloaisp, tenloaisp);
        }
        public void SuaSP(string spid, string spname, int sl, double giasp,
            int giamgiasp, string anhsp, string maloaisp, string tenloaisp)
        {
            spdao.SuaSP(spid, spname, sl, giasp, giamgiasp, anhsp, maloaisp, tenloaisp);
        }
        public void XoaSP(string spid)
        {
            spdao.XoaSP(spid);
        }
        public List<SanPham> TimKiemSP(string spname)
        {
            return spdao.TimKiemSP(spname);
        }
        public List<SanPham> getSPByMaSP(string msp)
        {
            return spdao.getSPByMaSP(msp);
        }
    }
}

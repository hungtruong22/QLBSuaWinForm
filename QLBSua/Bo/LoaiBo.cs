using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class LoaiBo
    {
        LoaiDao ldao = new LoaiDao();
        public List<Loai> getLoai()
        {
            return ldao.getLoai();
        }
        public void ThemLoai(string maloai, string tenloai)
        {
            ldao.ThemLoai(maloai, tenloai);
        }
        public void SuaLoai(string maloai, string tenloai)
        {
            ldao.SuaLoai(maloai, tenloai);
        }
        public void XoaLoai(string maloai)
        {
            ldao.XoaLoai(maloai);
        }
        public List<Loai> TimKiemLoai(string tenloai)
        {
            return ldao.TimKiemLoai(tenloai);
        }
        public List<Loai> getLoaiByMaLoai(string mloai)
        {
            return ldao.getLoaiByMaLoai(mloai);
        }
    }
}

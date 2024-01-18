using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class HoaDonThanhToanBo
    {
        HoaDonThanhToanDao hdttdao = new HoaDonThanhToanDao();
        public HoaDonThanhToan getNgayMua(int hdid)
        {
            return hdttdao.getNgayMua(hdid);
        }
        public List<HoaDonThanhToan> getSPbyMaHD(long hdid)
        {
            return hdttdao.getSPbyMaHD(hdid);
        }
        public List<HoaDonThanhToan> getSPbyMaTK(long tkid)
        {
            return hdttdao.getSPbyMaTK(tkid);
        }
        public double TongTienBanDuoc()
        {
            return hdttdao.TongTienBanDuoc();
        }
        public int TongSoLuongBanDuoc()
        {
            return hdttdao.TongSoLuongBanDuoc();
        }
    }
}

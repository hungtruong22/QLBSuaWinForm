using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class HoaDonBo
    {
        HoaDonDao hddao = new HoaDonDao();
        public long maxhd()
        {
            return hddao.maxhd();
        }
        public int ThemHD(int tkid)
        {
            return hddao.ThemHD(tkid);
        }
        public List<HoaDon> getHD()
        {
            return hddao.GetHD();
        }
        public int TongHD()
        {
            return hddao.TongHD();
        }
    }
}

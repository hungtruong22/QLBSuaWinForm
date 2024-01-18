using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class ChiTietHoaDonBo
    {
        ChiTietHoaDonDao ctdao = new ChiTietHoaDonDao();
        public int ThemCTHD(string spid, string spname, int slm, long maxmahd)
        {
            return ctdao.ThemCTHD(spid, spname, slm, maxmahd);
        }
        public ChiTietHoaDon getNewMaHd()
        {
            return ctdao.getNewMaHd();
        }
    }
}

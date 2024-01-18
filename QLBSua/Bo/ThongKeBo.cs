using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    public class ThongKeBo
    {
        ThongKeDao tkdao = new ThongKeDao();
        public List<ThongKe> danhsachbanchay()
        {
            return tkdao.danhsachbanchay();
        }
        public List<ThongKe> danhsachbancham()
        {
            return tkdao.danhsachbancham();
        }
    }
}

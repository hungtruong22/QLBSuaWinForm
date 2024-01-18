using QLBSua.Dao;
using QLBSua.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBSua.Bo
{
    internal class TaiKhoanBo
    {
        TaiKhoanDao tkdao = new TaiKhoanDao();
        public TaiKhoan Login(string emailtk, string matkhautk)
        {
            return tkdao.Login(emailtk, matkhautk);
        }

        public TaiKhoan Kiemtrataikhoantontai(string etk)
        {
            return tkdao.Kiemtrataikhoantontai(etk);
        }

        public void SignUp(string tendntk, string matkhautk, string emailtk)
        {
            tkdao.SignUp(tendntk, matkhautk, emailtk);
        }
        public void CapNhatTrangThai(int tkid, string trangthaitk)
        {
            tkdao.CapNhatTrangThai(tkid, trangthaitk);
        }
        public int TongSLNhanVien()
        {
            return tkdao.TongSLNhanVien();
        }
        public void DoiMK(int tkid, string matkhau)
        {
            tkdao.DoiMK(tkid, matkhau);
        }
        public void SuaTK(string tkid, string tendn, string mk, string email, bool isAdmin, string tthai)
        {
            tkdao.SuaTK(tkid, tendn, mk, email, isAdmin, tthai);
        }
    }
}

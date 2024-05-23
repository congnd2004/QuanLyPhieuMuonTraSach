using A_DAL.Context;
using A_DAL.DomainClass;
using A_DAL.irepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.repositories
{
    public class loanrepos:ireposloan
    {
        private DBContext db;
        public loanrepos()
        {
            db = new DBContext();
        }

        public bool add(PhieuBanGiaoSach phieuBan)
        {
            //var a = db.NhanViens.Where(s => s.MaNhanVien == s.MaNhanVien).ToList();
            db.Add(phieuBan);
            //db.AddRange(a);
            db.SaveChanges();
            return true;
        }

        public List<CtPbg> ctPbgs()
        {
            return db.CtPbgs.ToList();
        }

        public List<CtSach> ctSaches()
        {
            return db.CtSaches.ToList();
        }

        public bool delete(PhieuBanGiaoSach phieuBanGiaoSach)
        {
            var a = db.CtPbgs.Where(s => s.MaPhieuBanGiao == s.MaPhieuBanGiao).ToList();
            db.CtPbgs.RemoveRange(a);
            db.Remove(phieuBanGiaoSach);
            db.SaveChanges();
            return true;
        }

        public bool delete2(CtPbg ctPbg)
        {
            
            db.CtPbgs.Remove(ctPbg);
            db.SaveChanges();
            return true;
        }

        public List<PhieuBanGiaoSach> phieuBanGiaoSach()
        {
            return db.PhieuBanGiaoSaches.ToList();
        }

        public List<Sach> saches()
        {
           return db.Saches.ToList();
        }

        public List<TacGium> tacGiums()
        {
           return db.TacGia.ToList();
        }

   


        public bool update(Sach sach)
        {
            db.Update(sach);
            db.SaveChanges();
            return true;
        }
    }
}

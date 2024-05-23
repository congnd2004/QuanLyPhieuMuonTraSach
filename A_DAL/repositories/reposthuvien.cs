using A_DAL.Context;
using A_DAL.DomainClass;
using A_DAL.irepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.repositories
{
    public class reposthuvien : thuvienrepos
    {
        private DBContext dbContext;
        public reposthuvien()
        {
            dbContext = new DBContext();
        }
        public bool AddSach(CtSach sach)
        {
            dbContext.CtSaches.Add(sach);
            dbContext.SaveChanges();
            return true;
        }
        public bool masach(Sach sach)
        {
            dbContext.Add(sach);
            
            dbContext.SaveChanges();
            return true;
        }

        public bool DeleteSach(CtSach sach)
        {

            var a= dbContext.Saches.Where(s => s.MaSachCt == sach.MaSachCt).ToList();
           var b= dbContext.CtNhanLais.Where(n => n.MaSach==n.MaSach).ToList();
            var c= dbContext.CtPhieuPhats.Where(n => n.MaSach==n.MaSach).ToList() ;
            dbContext.CtPhieuPhats.RemoveRange(c);
            dbContext.CtNhanLais.RemoveRange(b);
            dbContext.Saches.RemoveRange(a);
            dbContext.CtSaches.Remove(sach);
            dbContext.SaveChanges();
            return true;
        }

        public List<CtSach> GetCtSaches()
        {
            return dbContext.CtSaches.ToList();
        }

        public List<Sach> GetSaches()
        {
            return dbContext.Saches.ToList();
        }

        public bool UpdateSach(CtSach sach)
        {
            dbContext.CtSaches.Update(sach);
            dbContext.SaveChanges(true);
            return true;
        }

        public bool UpdateGiaSach(Sach s)
        {
            dbContext.Update(s);
            dbContext.SaveChanges();
            return true;
        }
    }
}

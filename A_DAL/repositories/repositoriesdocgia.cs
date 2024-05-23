using A_DAL.Context;
using A_DAL.DomainClass;
using A_DAL.irepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.repositories
{
    public class repositoriesdocgia: irepositoriesdocgia
    {
        private DBContext dbContext;
        public repositoriesdocgia()
        {
            dbContext = new DBContext();
        }

        public bool add(DocGium c)
        {
            dbContext.Add(c);
            dbContext.SaveChanges();
            return true;
        }

        public bool add(CtPbg c)
        {
            dbContext.Add(c);
            dbContext.SaveChanges();
            return true;
        }

        public List<CtPbg> GetCtPbgs()
        {
            return dbContext.CtPbgs.ToList();
        }

        public List<DocGium> GetDocGia()
        {
            return dbContext.DocGia.ToList();
        }

        public List<PhieuBanGiaoSach> GetPhieuBanGiaoSaches()
        {
            return dbContext.PhieuBanGiaoSaches.ToList();
        }

        public bool remove(DocGium c)
        {
            var a = dbContext.PhieuBanGiaoSaches.Where(a => a.MaTheDocGia == c.MaTheDocGia).ToList();
            var b = dbContext.BbNhanLais.Where(a => a.MaTheDocGia == c.MaTheDocGia).ToList();
            var e = dbContext.PhieuPhats.Where(a => a.MaPhieuPhat == a.MaPhieuPhat).ToList();
            var i = dbContext.CtPhieuPhats.Where(a => a.MaPhieuPhat == a.MaPhieuPhat).ToList();
            var j = dbContext.CtNhanLais.Where(a => a.MaBbnhanLai == a.MaBbnhanLai).ToList();
            dbContext.CtNhanLais.RemoveRange(j);
            dbContext.CtPhieuPhats.RemoveRange(i);
            dbContext.PhieuPhats.RemoveRange(e);
            dbContext.BbNhanLais.RemoveRange(b);
            dbContext.PhieuBanGiaoSaches.RemoveRange(a);
           dbContext.DocGia.Remove(c);
            dbContext.SaveChanges();
                return true;
        }

       
        public bool update(DocGium c)
        {
            dbContext.Update(c);
            dbContext.SaveChanges();
            return true;
        }
    }
}

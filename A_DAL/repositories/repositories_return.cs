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
    public class repositories_return : irepositories_return
    {
        DBContext dbContext;
        public repositories_return()
        {
            dbContext = new DBContext();
        }
        public bool add(BbNhanLai a)
        {
            dbContext.Add(a);
            dbContext.SaveChanges();
            return true;
        }

        public bool add2(CtNhanLai a)
        {
           dbContext.Add(a);
            dbContext.SaveChanges();
            return true;
        }

        public bool add3(PhieuPhat a)
        {
            dbContext.Add(a);
            dbContext.SaveChanges();
            return true;
        }

        public bool add4(CtPhieuPhat a)
        {
            dbContext.Add(a);
            dbContext.SaveChanges();
            return true;
        }

        public List<BbNhanLai> bbNhanLais()
        {
            return dbContext.BbNhanLais.ToList();
        }

        public List<CtNhanLai> ctNhanLais()
        {
            return dbContext.CtNhanLais.ToList();
        }

        public List<CtPhieuPhat> ctphieuPhats()
        {
            return dbContext.CtPhieuPhats.ToList();
        }

        public List<DocGium> docGiums()
        {
           return dbContext.DocGia.ToList();
        }

        public List<NhanVien> nhanViens()
        {
            return dbContext.NhanViens.ToList();
        }

        public List<PhieuPhat> phieuPhats()
        {
            return dbContext.PhieuPhats.ToList();
        }
    }
}

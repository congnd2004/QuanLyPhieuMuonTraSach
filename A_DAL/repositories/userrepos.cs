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
    public class userrepos : Interface1
    {
        private DBContext db;
        public userrepos()
        {
            db = new DBContext();
        }
        public List<Acount> GetAcount()
        {
            return db.Acounts.ToList();
        }

        public List<NhanVien> GetNhanViens()
        {
            return db.NhanViens.ToList();
        }
    }
}

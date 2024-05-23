using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.irepositories
{
    internal interface thuvienrepos
    {
        public List<CtSach> GetCtSaches();
        public List<Sach> GetSaches();
        public bool masach(Sach sach);
        public bool AddSach(CtSach sach);
        public bool UpdateSach(CtSach sach);
        public bool DeleteSach(CtSach sach);
        public bool UpdateGiaSach(Sach s);
    }
}

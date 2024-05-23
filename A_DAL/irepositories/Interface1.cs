using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.irepositories
{
    internal interface Interface1
    {
        public List<NhanVien> GetNhanViens();
        public List<Acount> GetAcount();
    }
}

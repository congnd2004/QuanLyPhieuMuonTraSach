using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.iservice
{
    internal interface iserviceuser
    {
        public List<NhanVien> nhanViens();
        public List<Acount> acounts();
    }
}

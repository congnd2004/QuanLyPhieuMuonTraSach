using A_DAL.DomainClass;
using A_DAL.repositories;
using B_BUS.iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.service
{
    public class serviceuser : iserviceuser
    {
        private userrepos repos2;
        public serviceuser()
        {
            repos2 = new userrepos();
        }

        public List<Acount> acounts()
        {
            return repos2.GetAcount();
        }

        public List<NhanVien> nhanViens()
        {
           
                return repos2.GetNhanViens();
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.DomainClass;

namespace B_BUS.iservice
{
    internal interface iservicedocgia
    {
        public List<DocGium> GetDocGiums(string seach);
        public List<PhieuBanGiaoSach> phieuBanGiaoSaches(int id);
        public CtPbg ctPbgs(int id);
        public string them(DocGium docGium);
        public string sua(DocGium docGium);
        public string xoa(DocGium docGium);
        public string themp(CtPbg ctPbgs);
    }
}

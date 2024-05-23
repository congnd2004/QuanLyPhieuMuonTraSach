using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.irepositories
{
    internal interface irepositoriesdocgia
    {
        public List<DocGium> GetDocGia();
        public List<PhieuBanGiaoSach> GetPhieuBanGiaoSaches();
        public List<CtPbg> GetCtPbgs();
        public bool add(DocGium c);
        public bool remove(DocGium c);
        public bool update(DocGium c);
        public bool add(CtPbg c);

    }
}

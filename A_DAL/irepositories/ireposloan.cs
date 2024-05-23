using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.irepositories
{
    internal interface ireposloan
    {
        public List<Sach> saches();
        public List<CtSach> ctSaches();
        public List<CtPbg> ctPbgs();
        public List<PhieuBanGiaoSach> phieuBanGiaoSach();
        public bool add(PhieuBanGiaoSach phieuBan);
        public bool update(Sach sach);
        public bool delete(PhieuBanGiaoSach phieuBanGiaoSach);
        public bool delete2(CtPbg ctPbg);

    }
}

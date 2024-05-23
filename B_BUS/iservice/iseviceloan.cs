using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.iservice
{
    internal interface iseviceloan
    {
        public List<Sach> Saches(int id);
        public List<CtSach> CtSachs(int id);
        public List<TacGium> TacGiums(string id);
        public List<CtPbg> CtPbgs(int id);
        public List<PhieuBanGiaoSach> PhieuBanGiaoSach(int id);
        public string them(PhieuBanGiaoSach phieuBan);
        public string sua(Sach sach);
        public string xoa(PhieuBanGiaoSach PhieuBan);
        public string xoa2(CtPbg ctPbg);
    }
}

using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.irepositories
{
    internal interface irepositories_return
    {
        public List<BbNhanLai> bbNhanLais();
        public List<CtNhanLai> ctNhanLais();
        public List<PhieuPhat> phieuPhats();
        public List<CtPhieuPhat> ctphieuPhats();
        public List<NhanVien> nhanViens();
        public List<DocGium> docGiums();
        public bool add(BbNhanLai a);
        public bool add2(CtNhanLai a);
        public bool add3(PhieuPhat a);
        public bool add4(CtPhieuPhat a);
        
    }
}

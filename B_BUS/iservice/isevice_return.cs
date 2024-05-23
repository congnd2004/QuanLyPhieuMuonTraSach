using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.iservice
{
    internal interface isevice_return
    {
        public List<BbNhanLai> bbNhanLais(int id);
        public List<CtNhanLai> ctNhanLais(int id);
        public List<PhieuPhat> phieuPhats(int id);
        public List<CtPhieuPhat> ctphieuPhats(int id);
        public List<NhanVien> nhanViens(int id);
        public List<DocGium> docGiums(int id);
        public string thembbnhanlai(BbNhanLai a);
        public string themctnhanlai(CtNhanLai a);
        public string themphieuphat (PhieuPhat a);
        public string themctphieuphat(CtPhieuPhat a);

    }
}

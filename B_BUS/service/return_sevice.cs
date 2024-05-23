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
    public class return_sevice : isevice_return
    {
        repositories_return repository;
        public return_sevice()
        {
            repository = new repositories_return();
        }
        public List<BbNhanLai> bbNhanLais(int id)
        {
            return repository.bbNhanLais().Where(x => x.MaBbnhanLai == id).ToList();
        }

        public List<CtNhanLai> ctNhanLais(int id)
        {
            return repository.ctNhanLais().Where(x => x.MaBbnhanLai == id).ToList();
        }

        public List<CtPhieuPhat> ctphieuPhats(int id)
        {
            return repository.ctphieuPhats().Where(x => x.MaPhieuPhat == id).ToList();
        }

        public List<DocGium> docGiums(int id)
        {
            return repository.docGiums().Where(x => x.MaTheDocGia == id).ToList();
        }

        public List<NhanVien> nhanViens(int id)
        {
            return repository.nhanViens().Where(x => x.MaNhanVien == id).ToList();
        }

        public List<PhieuPhat> phieuPhats(int id)
        {
            return repository.phieuPhats().Where(x => x.MaPhieuPhat == id).ToList();
        }

        public string thembbnhanlai(BbNhanLai a)
        {
            repository.add(a);
            return "";
        }

        public string themctnhanlai(CtNhanLai a)
        {
            repository.add2(a);
            return "";
        }

        public string themctphieuphat(CtPhieuPhat a)
        {
            repository.add4(a);
            return "";
        }

        public string themphieuphat(PhieuPhat a)
        {
            repository.add3(a);
            return "";
        }
    }
}

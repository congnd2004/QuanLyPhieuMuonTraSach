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
    public class sevicedocgia:iservicedocgia
    {
        private repositoriesdocgia _repos;
        public sevicedocgia()
        {
            _repos= new repositoriesdocgia();
        }

        public CtPbg ctPbgs(int id)
        {
            return _repos.GetCtPbgs().FirstOrDefault(x => x.MaPhieuBanGiao == id);
        }

        public List<DocGium> GetDocGiums(string seach)
        {
           if(seach != null)
            {
                return _repos.GetDocGia().Where(x=>x.HoTen.Contains(seach) || x.Sdt.Equals(seach)).ToList();
            }
            else
            {
                return _repos.GetDocGia();
            }
        }

        public List<PhieuBanGiaoSach> phieuBanGiaoSaches(int id)
        {
            if(id != null)
            {
                return _repos.GetPhieuBanGiaoSaches().Where(x=>x.MaTheDocGia==id).ToList();
            }
            else
            {
                return _repos.GetPhieuBanGiaoSaches();
            }
        }

        public string sua(DocGium docGium)
        {
           var sua= _repos.GetDocGia().FirstOrDefault(x=>x.MaTheDocGia==docGium.MaTheDocGia);
            try
            {
                if (sua != null)
                {
                    sua.Sdt = docGium.Sdt;
                    sua.HoTen = docGium.HoTen;
                    sua.NgaySinh = docGium.NgaySinh;
                    sua.NgayLamThe = docGium.NgayLamThe;
                    sua.DiaChi = docGium.DiaChi;
                    sua.DoiTuongDocGia = docGium.DoiTuongDocGia;
                    _repos.update(sua);
                    return "Update thanh công";
                }
                else
                {
                    return "Update thất bại";
                }
            }
            catch (Exception)
            {
                return "Có lỗi";
            
            }
        
         }

        public string them(DocGium docGium)
        {
            _repos.add(docGium);
            return "thêm thành công";
        }

        public string themp(CtPbg ctPbgs)
        {
            _repos.add(ctPbgs);
            return "cho mượn thành công";
        }

        public string xoa(DocGium docGium)
        {
            var sua = _repos.GetDocGia().FirstOrDefault(x => x.MaTheDocGia == docGium.MaTheDocGia);
            try
            {
                if (sua != null)
                {
                    sua.Sdt = docGium.Sdt;
                    sua.HoTen = docGium.HoTen;
                    sua.NgaySinh = docGium.NgaySinh;
                    sua.NgayLamThe = docGium.NgayLamThe;
                    sua.DiaChi = docGium.DiaChi;
                    sua.DoiTuongDocGia = docGium.DoiTuongDocGia;
                    _repos.remove(sua);
                    return "xóa thanh công";
                }
                else
                {
                    return "xóa thất bại";
                }
            }
            catch (Exception)
            {
                return "Có lỗi";

            }
        }
    }
}

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
    public class loansevice : iseviceloan
    {
        private loanrepos _repos;
        public loansevice()
        {
            _repos = new loanrepos();
        }

        public List<CtPbg> CtPbgs(int id)
        {
            return _repos.ctPbgs().Where(x=>x.MaPhieuBanGiao==id).ToList(); 
        }

        public List<CtSach> CtSachs(int id)
        {
            if (id != null)
            {
                return _repos.ctSaches().Where(x => x.MaSachCt == id).ToList();
            }
            else
            {
                return _repos.ctSaches();
            }
        }

        public List<PhieuBanGiaoSach> PhieuBanGiaoSach(int id)
        {
            return _repos.phieuBanGiaoSach().Where(x => x.MaPhieuBanGiao == id).ToList();
        }

        public List<Sach> Saches(int id)
        {
            return _repos.saches().Where(x => x.MaSach == id).ToList();
        }

        public string sua(Sach sach)
        {
            var cl = _repos.saches().FirstOrDefault(x => x.MaSach == sach.MaSach);
            try
            {
                if (cl != null)
                {
                    
                    cl.TinhTrangSach = sach.TinhTrangSach;
                    _repos.update(cl);
                    return " sửa thành công";
                }
                else
                {
                    return "sửa thất bại"; ;
                }

            }
            catch (Exception)
            {
                return "Có lỗi";
            }
        }

        public List<TacGium> TacGiums(string id)
        {
            return _repos.tacGiums().Where(x => x.TenTacGia == id).ToList();
        }

        public string them(PhieuBanGiaoSach phieuBan)
        {
            _repos.add(phieuBan);
            return "cho mượn thành công";
        }

        public string xoa(PhieuBanGiaoSach PhieuBan)
        {
            var cl = _repos.phieuBanGiaoSach().FirstOrDefault(x => x.MaPhieuBanGiao == PhieuBan.MaPhieuBanGiao);
            try
            {
                if (cl != null)
                {

                    cl.MaNhanVien = PhieuBan.MaNhanVien;
                    cl.MaTheDocGia = PhieuBan.MaTheDocGia;
                    cl.NgayMuon = PhieuBan.NgayMuon;
                    cl.NgayDuKienTra = PhieuBan.NgayDuKienTra;
                    cl.TinhTrangKhiTrao = PhieuBan.TinhTrangKhiTrao;
                    _repos.delete(cl);
                    return "Xóa thành công";
                }
                else
                {
                    return "Xóa thất bại";
                }
            }

            catch (Exception)
            {
                return "Có lỗi";
            }
        }

        public string xoa2(CtPbg ctPbg)
        {
            var cl = _repos.ctPbgs().FirstOrDefault(x => x.MaSach == x.MaSach);
            try
            {
                if (cl != null)
                {
                    cl.MaPhieuBanGiao = ctPbg.MaPhieuBanGiao;
                    cl.MaSach = ctPbg.MaSach;
                    cl.ThongTin= ctPbg.ThongTin;
                    
                    _repos.delete2(cl);
                    return "Xóa thành công";
                }
                else
                {
                    return "Xóa thất bại";
                }
            }
            catch (Exception)
            {
                return "Có lỗi";
            }
        }
    }
}

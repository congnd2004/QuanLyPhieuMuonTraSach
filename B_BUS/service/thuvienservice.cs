using A_DAL.Context;
using A_DAL.DomainClass;
using A_DAL.repositories;
using B_BUS.iservice;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace B_BUS.service
{
    public class thuvienservice : ithuvienservice
    {
        private reposthuvien repos;
        public thuvienservice()
        {
            repos = new reposthuvien();
        }
        public List<CtSach> sach(string seach)
        {
            if (seach != null)
            {
                return repos.GetCtSaches().Where(x => x.TenDauSach.Contains(seach) || x.TenTacGia.Contains(seach)).ToList();
            }
            else
            {
                return repos.GetCtSaches();
            }
        }
        public string masach(Sach sach)
        {
            repos.masach(sach);
            return "";
        }

        public string SuaSach(CtSach sach)
        {
            var cl = repos.GetCtSaches().FirstOrDefault(x => x.MaSachCt == sach.MaSachCt);
            try
            {
                if (cl != null)
                {
                    cl.TenDauSach = sach.TenDauSach;
                    cl.SoLuong = sach.SoLuong;
                    cl.SoTrang = sach.SoTrang;
                    cl.TenTacGia = sach.TenTacGia;
                    repos.UpdateSach(cl);
                    return "Update thành công";
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

        public string ThemSach(CtSach sach)
        {
            try
            {
                repos.AddSach(sach);
                return "Thêm thành công";
            }
            catch (Exception)
            {
                return "Thêm thất bại";
            }
        }


        public List<Sach> TTSach(int i)
        {
            
            if (i != null)
            {
                return repos.GetSaches().Where(x => x.MaSachCt.Equals(i)).ToList();
            }
            else
            {
                return repos.GetSaches();
            }
        }


        public string XoaSach(CtSach sach)
        {
            var cl = repos.GetCtSaches().FirstOrDefault(x => x.MaSachCt == sach.MaSachCt);
            try
            {
                if (cl != null)
                {
                    cl.TenDauSach = sach.TenDauSach;
                    cl.SoLuong = sach.SoLuong;
                    cl.SoTrang = sach.SoTrang;
                    cl.TenTacGia = sach.TenTacGia;
                    repos.DeleteSach(cl);
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

       

        public Sach sach2(int id)
        {
            return repos.GetSaches().FirstOrDefault(x => x.MaSach == id);
        }
       
        public string suaGiaSach(Sach s)
        {
            var cl = repos.GetSaches().FirstOrDefault(x => x.MaSachCt == s.MaSachCt);
            try
            {
                if (cl != null)
                {
                    cl.GiaSach = s.GiaSach;
                    repos.UpdateGiaSach(cl);
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
    }
}

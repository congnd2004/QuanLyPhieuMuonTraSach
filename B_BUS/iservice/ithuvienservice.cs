using A_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.iservice
{
    internal interface ithuvienservice
    {
        public List<CtSach> sach(string seach);
        public List<Sach> TTSach(int id);
        public Sach sach2(int id);
        public string masach(Sach sach);
        public string ThemSach(CtSach sach);
        public string XoaSach(CtSach sach);
        public string SuaSach(CtSach sach);
        public string suaGiaSach(Sach s);

    }
}

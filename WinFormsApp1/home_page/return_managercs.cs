using A_DAL.Context;
using A_DAL.DomainClass;
using B_BUS.service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static C_PRL.login.form_log;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL.home_page
{
    public partial class return_managercs : UserControl
    {
        public LoggedUser LoggedUser { get; set; }
        private thuvienservice _thuvien;
        private loansevice _loan;
        private sevicedocgia _docgia;
        private return_sevice _return;
        public return_managercs()
        {
            _thuvien = new thuvienservice();
            _return = new return_sevice();
            _loan = new loansevice();
            _docgia = new sevicedocgia();
            InitializeComponent();
        }


        public List<int> LayMaSachDaMuon(int maDocGia)
        {
            using (var dbContext = new DBContext())
            {
                var maSachDaMuon = dbContext.PhieuBanGiaoSaches
                    .Where(pbg => pbg.MaTheDocGia == maDocGia)
                    .SelectMany(pbg => pbg.CtPbgs.Select(ct => ct.MaSach))
                    .ToList();

                return maSachDaMuon;
            }
        }
        private void txttimdg_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txttimdg.Text, out int maDocGia))
            {
                List<int> maSachDaMuon = LayMaSachDaMuon(maDocGia);
                cmbbookcode.DataSource = maSachDaMuon;

            }
            else
            {
                cmbbookcode.DataSource = null;
            }
        }



        private void cmbbookcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textnamefull()
        {
            int inputCode = int.Parse(txttimdg.Text);
            if (int.TryParse(txttimdg.Text, out int maTheDocGia))
            {
                var docGia = _return.docGiums(inputCode).FirstOrDefault(x => x.MaTheDocGia == maTheDocGia);
                if (docGia != null)
                {
                    ttxnamereader.Text = docGia.HoTen;
                    txtreadercode.Text = docGia.MaTheDocGia.ToString();
                    txtdatebird.Text = docGia.NgaySinh.ToString();
                    txtdatecard.Text = docGia.NgayLamThe.ToString();
                    txtobject.Text = docGia.Sdt.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy độc giả với mã này");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã độc giả hợp lệ");
            }

        }
        public void textbookfull()
        {
            
            int maSach = int.Parse(cmbbookcode.Text);

            using (DBContext dbContext = new DBContext())
            {
                var result = (from sach in dbContext.Saches
                              join ctSach in dbContext.CtSaches on sach.MaSachCt equals ctSach.MaSachCt
                              where sach.MaSach == maSach
                              select new
                              {
                                  sach.MaSach,
                                  ctSach.TenDauSach,
                                  ctSach.SoTrang,
                                  ctSach.TenTacGia
                              }).FirstOrDefault();
                if (result != null)
                {
                    txtboxcode.Text = result.MaSach.ToString();
                    txtnamebox.Text = result.TenDauSach;
                    txtnumberpage.Text = result.SoTrang.ToString();
                    txttg.Text = result.TenTacGia;
                    txttinhtrang.Text = "nguyên vẹn";
                }
                else
                {
                    Console.WriteLine("Không tìm thấy dữ liệu.");
                }
            }


        }
        DBContext _db = new DBContext();

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
                textnamefull();
                if (cmbbookcode.Text == "")
                {
                    MessageBox.Show("độc giả chưa mượn sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textbookfull();
                    int maSach = int.Parse(cmbbookcode.Text);
                    var cT_PBG = _db.CtPbgs.SingleOrDefault(p => p.MaSach == maSach);
                    int maPhieuBanGiao = cT_PBG.MaPhieuBanGiao;

                    var ngayMuon = _db.PhieuBanGiaoSaches
                    .Where(pbg => pbg.CtPbgs.Any(cp => cp.MaSach == maSach))
                    .Select(pbg => pbg.NgayMuon)
                    .FirstOrDefault();
                    var ngayDuKienTra = _db.PhieuBanGiaoSaches
                        .Where(pbg => pbg.CtPbgs.Any(cp => cp.MaSach == maSach))
                        .Select(pbg => pbg.NgayDuKienTra)
                        .FirstOrDefault();
                    var giaSach = _db.PhieuBanGiaoSaches
                    .Join(_db.CtPbgs, pbg => pbg.MaPhieuBanGiao, ctpbg => ctpbg.MaPhieuBanGiao, (pbg, ctpbg) => new { pbg, ctpbg })
                    .Join(_db.Saches, p => p.ctpbg.MaSach, cts => cts.MaSach, (p, cts) => new { p, cts })
                    .Where(x => x.p.pbg.MaPhieuBanGiao == maPhieuBanGiao)
                    .Select(x => x.cts.GiaSach)
                    .FirstOrDefault();
                    decimal giaSachValue = giaSach;
                    decimal tien = 0;
                    if (dateTimengaytra.Value <= ngayDuKienTra)
                    {
                        MessageBox.Show("trả sách đúng hạn", "thông báo", MessageBoxButtons.OK);
                        int SoNgayMuon = ((DateTime)dateTimengaytra.Value - (DateTime)ngayMuon).Days;
                        tien = Convert.ToDecimal(giaSachValue * 0.05m * SoNgayMuon);
                        txtngayquahan.Text = "0";
                        txmoney.Text = tien.ToString("N0");

                    }
                    else if (dateTimengaytra.Value > ngayDuKienTra)
                    {
                        int SoNgayMuon = ((DateTime)ngayDuKienTra - (DateTime)ngayMuon).Days;
                        int SoNgayTre = ((DateTime)dateTimengaytra.Value - (DateTime)ngayDuKienTra).Days;
                        tien = Convert.ToDecimal(giaSachValue * 0.05m * SoNgayMuon) + (giaSachValue * 0.1m * SoNgayTre);
                        txtngayquahan.Text = SoNgayTre.ToString();
                        txmoney.Text = tien.ToString("N0");
                        MessageBox.Show("sách trả quá hạn", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    txtngaytra.Text = dateTimengaytra.Text;
                    txtmanv.Text = LoggedUser.Id.ToString();
                }
            }catch(Exception ex) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnamebox.Text == ""||ttxnamereader.Text=="")
            {
                MessageBox.Show("trả sách không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var tb = MessageBox.Show("trả sách thành công???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    themNhanLai();
                    ThemCTNhanLai();
                    ThemPhieuPhat();
                    ThemCtPhieuPhat();
                    SuaTinhTrangSach();
                    XoaPBG();

                }
                else
                {
                    return;
                }
            }
            

        }


        public void themNhanLai()
        {
            var s = new BbNhanLai();
            s.MaTheDocGia = int.Parse(txtreadercode.Text);
            s.MaNhanVien = int.Parse(txtmanv.Text);
            s.NgayTra = dateTimengaytra.Value;
            _return.thembbnhanlai(s);
        }
        public void ThemCTNhanLai()
        {
            var b = new CtNhanLai();
            b.MaBbnhanLai = _db.BbNhanLais.Max(x => x.MaBbnhanLai);
            b.MaSach = int.Parse(txtboxcode.Text);
            b.TinhTrangNhanLai = txttinhtrang.Text;
            _return.themctnhanlai(b);
        }
        public void ThemPhieuPhat()
        {
            var c = new PhieuPhat();
            c.MaBbnhanLai = _db.BbNhanLais.Max(x => x.MaBbnhanLai);
            decimal tien;
            if (Decimal.TryParse(txmoney.Text, out tien))
            {
                c.TongTien = tien;
            }
            _return.themphieuphat(c);
        }
        public void ThemCtPhieuPhat()
        {
            var d = new CtPhieuPhat();
            d.MaPhieuPhat = _db.PhieuPhats.Max(x => x.MaPhieuPhat);
            d.MaSach = int.Parse(txtboxcode.Text);
            d.TinhTrangHong = txttinhtrang.Text;
            _return.themctphieuphat(d);
        }
        public void SuaTinhTrangSach()
        {
            var h = new Sach();
            h.MaSach = int.Parse(txtboxcode.Text);
            h.TinhTrangSach = "còn";
            _loan.sua(h);
        }
        public void XoaPBG()
        {
            int maSach = int.Parse(txtboxcode.Text);
            var cT_PBG = _db.CtPbgs.SingleOrDefault(p => p.MaSach == maSach);
            int maPhieuBanGiao = cT_PBG.MaPhieuBanGiao;
            var g = new PhieuBanGiaoSach();
            g.MaPhieuBanGiao = maPhieuBanGiao;
            _loan.xoa(g);
        }

        private void txttimdg_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex) { }
        }
    }
}

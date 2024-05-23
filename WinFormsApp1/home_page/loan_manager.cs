using A_DAL.Context;
using A_DAL.DomainClass;
using B_BUS.service;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static C_PRL.login.form_log;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL.home_page
{
    public partial class loan_manager : UserControl
    {
       public LoggedUser LoggedUser { get; set; }
        private thuvienservice _thuvienservice;
        private sevicedocgia _sevicedocgia;
        private loansevice _loansevice;
        private serviceuser _serviceuser;
        int id;
        int idb;

        public loan_manager()
        {
            _loansevice = new loansevice();
            _sevicedocgia = new sevicedocgia();
            _thuvienservice = new thuvienservice();
            _serviceuser = new serviceuser();
            InitializeComponent();
            shownname();
            showbook();
            khoa();
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void loan_manager_Load(object sender, EventArgs e)
        {

        }
        public void shownname()
        {
            dtgname.ColumnCount = 2;
            dtgname.Columns[0].Name = "Mã Độc Giả";
            dtgname.Columns[0].Width = 150;
            dtgname.Columns[1].Name = "Tên Độc giả";
            dtgname.Columns[1].Width = 200;
            dtgname.Rows.Clear();
            foreach (var x in _sevicedocgia.GetDocGiums(txttimten.Text))
            {
                dtgname.Rows.Add(x.MaTheDocGia, x.HoTen);
            }
        }
        public void showbook()
        {
            dtgbook.Columns.Clear();
            dtgbook.AutoGenerateColumns = false;
            dtgbook.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "MaSach",
                HeaderText = "Mã Sách",
                Width = 120
            });

            dtgbook.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TenDauSach",
                HeaderText = "Tên Đầu Sách",
                Width = 200

            });
            using (DBContext dbContext = new DBContext())
            {
                var query = from ct in dbContext.CtSaches
                            join s in dbContext.Saches on ct.MaSachCt equals s.MaSachCt
                            where ct.TenDauSach.Contains(txttimbook.Text.Trim()) && s.TinhTrangSach == "Còn"
                            select new
                            {
                                s.MaSach,
                                ct.TenDauSach,
                            };
                dtgbook.DataSource = query.ToList();
            }

        }


        private void dtgname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idrow = e.RowIndex;
            id = int.Parse(dtgname.Rows[idrow].Cells[0].Value.ToString());
            textname(id);
        }
        public void textname(int id)
        {
            var s = _sevicedocgia.GetDocGiums(txttimten.Text).FirstOrDefault(x => x.MaTheDocGia == id);
            txtname.Text = s.MaTheDocGia.ToString();
        }

        private void dtgbook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idrowe = e.RowIndex;
            idb = int.Parse(dtgbook.Rows[idrowe].Cells[0].Value.ToString());
            textbook(idb);
        }

        public void textbook(int d)
        {
            var sa = _loansevice.Saches(idb).FirstOrDefault(x => x.MaSach == d);
            txtbook.Text = sa.MaSach.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
      
            if (txtname.Text == "" || txttinhtrang.Text == "" || txtbook.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textnamefull(id);
                txtBookfull(idb);
                var S = new PhieuBanGiaoSach();
                S.MaNhanVien =int.Parse( LoggedUser.Id.ToString());
                S.MaTheDocGia = int.Parse(txtcode.Text);
                S.NgayMuon = datetime1.Value;
                S.NgayDuKienTra = dateTime2.Value;
                S.TinhTrangKhiTrao = txttrangthaigiao.Text;

                _loansevice.them(S);
            }

        }

        public void txtBookfull(int id)
        {
            var a = _loansevice.Saches(idb).FirstOrDefault(x => x.MaSach == id);
            foreach (var i in _thuvienservice.sach(txttimbook.Text))
            {
                if (a.MaSachCt == i.MaSachCt)
                {
                    txtbookname.Text = i.TenDauSach;
                    txtbookcode.Text = a.MaSach.ToString();
                    txtsotrangbook.Text = i.SoTrang.ToString();
                    txttentg.Text = i.TenTacGia;
                    txtvaitrotg.Text = "chủ biên";
                    txttrangthaigiao.Text = txttinhtrang.Text;
                    txtngaytra.Text = dateTime2.Value.ToString();

                }
            }
        }
        public void textnamefull(int id)
        {
            var s = _sevicedocgia.GetDocGiums(txttimten.Text).FirstOrDefault(x => x.MaTheDocGia == id);
            txtcode.Text = s.MaTheDocGia.ToString();
            txtten.Text = s.HoTen;
            txtngaysinh.Text = s.NgaySinh.Value.ToString();
            txtngngaythe.Text = s.NgayLamThe.Value.ToString();
            txtphone.Text = s.Sdt.ToString();
            txtngaybangiao.Text = datetime1.Value.ToString();
            txtdiachi.Text = s.DiaChi;
            labelnhanvien.Text = LoggedUser.TenNhanVien;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txttinhtrang.Text == "" || txtbook.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var a = new DBContext();
                var S = new PhieuBanGiaoSach();
                var b = new CtPbg();
                var c = new Sach();
                b.MaSach = int.Parse(txtbookcode.Text);
                b.MaPhieuBanGiao = a.PhieuBanGiaoSaches.Max(x => x.MaPhieuBanGiao);
                b.ThongTin = "chưa trả";
                c.MaSach = idb;
                c.TinhTrangSach = "đã mượn";
                var tb = MessageBox.Show("Bạn có chắc chắn muốn cho mượn???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(_sevicedocgia.themp(b));
                    _loansevice.sua(c);
                    showbook();
                }
                else
                {
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtbook.Text = "";
            txtbookcode.Text = "";
            txtbookname.Text = "";
            txtsotrangbook.Text = "";
            txttentg.Text = "";
            txttrangthaigiao.Text = "";
            txtvaitrotg.Text = "";
            txtngaytra.Text = "";
            txtcode.Text = "";
            txtname.Text = "";
            txtngaysinh.Text = "";
            txtngngaythe.Text = "";
            txtdiachi.Text = "";
            txtphone.Text = "";
            txtngaybangiao.Text = "";
            txtten.Text = "";
            txttinhtrang.Text = "";
            datetime1.Text = "";
            dateTime2.Text = "";
        }
        public void khoa()
        {
            txtbook.Enabled = false;
            txtbookcode.Enabled = false;
            txtbookname.Enabled = false;
            txtsotrangbook.Enabled = false;
            txttentg.Enabled = false;
            txttrangthaigiao.Enabled = false;
            txtvaitrotg.Enabled = false;
            txtngaytra.Enabled  = false;
            txtcode.Enabled = false;
            txtname.Enabled = false;
            txtngaysinh.Enabled = false;
            txtngngaythe.Enabled = false;
            txtdiachi.Enabled = false;
            txtphone.Enabled = false;
            txtngaybangiao.Enabled = false;
            txtten.Enabled = false;
           
        }

        private void txttimten_TextChanged(object sender, EventArgs e)
        {
            shownname();
        }

        private void txttimbook_TextChanged(object sender, EventArgs e)
        {
            showbook();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_home form = this.FindForm() as form_home;
            Control currentControl = this;
            form.SwitchToControl2(currentControl);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

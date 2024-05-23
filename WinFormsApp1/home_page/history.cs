using A_DAL.Context;
using B_BUS.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.home_page
{
    public partial class history : UserControl
    {
        private sevicedocgia _reader;
        public history()
        {
            _reader = new sevicedocgia();
            InitializeComponent();
            show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void show()
        {
            dtglichsu.Columns.Clear();
            dtglichsu.AutoGenerateColumns = false;
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "madocgia",
                HeaderText = "Mã Độc Giả",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ten",
                HeaderText = "Tên Độc giả",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ngaysinh",
                HeaderText = "Ngày sinh",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "doituong",
                HeaderText = "đối tượng",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "masach",
                HeaderText = "Mã Sách",
                Width = 120
            });

            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "tendausach",
                HeaderText = "Tên Đầu Sách",
                Width = 200

            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "tentg",
                HeaderText = "tên tác giả",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ngaymuon",
                HeaderText = "Ngày mượn",
                Width = 120
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "tinhtrang",
                HeaderText = "tình trạng giao",
                Width = 200
            });
            dtglichsu.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "ngaydukien",
                HeaderText = "ngày dự kiến trả",
                Width = 120
            });
            using (DBContext dbContext = new DBContext())
            {
                var query = from ct in dbContext.CtPbgs
                            join a in dbContext.Saches on ct.MaSach equals a.MaSach
                            join c in dbContext.CtSaches on a.MaSachCt equals c.MaSachCt
                            join s in dbContext.PhieuBanGiaoSaches on ct.MaPhieuBanGiao equals s.MaPhieuBanGiao
                            join d in dbContext.DocGia on s.MaTheDocGia equals d.MaTheDocGia
                            where d.HoTen.Contains(txttimkiem.Text)
                            select new
                            {

                                madocgia = s.MaTheDocGia,
                                ten = d.HoTen,
                                ngaysinh = d.NgaySinh,
                                doituong = d.DoiTuongDocGia,
                                masach = ct.MaSach,
                                tendausach = c.TenDauSach,
                                Tentg = c.TenTacGia,
                                ngaymuon = s.NgayMuon,
                                tinhtrang = s.TinhTrangKhiTrao,
                                Ngaydukien = s.NgayDuKienTra

                            };
                dtglichsu.DataSource = query.ToList();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            loan_manager ucLoan_Managerment = new loan_manager();
            add_usercontrol(ucLoan_Managerment);
        }
        public void add_usercontrol(Control control)
        {

            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel2.Controls.Add(control);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttimkiem_TextChanged_1(object sender, EventArgs e)
        {
            show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form_home form = this.FindForm() as form_home;
            Control currentControl = this;
            form.SwitchToControl1(currentControl);
        }
    }
}

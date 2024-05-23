using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using A_DAL.Context;
using B_BUS.service;
using A_DAL.DomainClass;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Storage;
using ExcelDataReader;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace C_PRL.home_page
{
    public partial class book_manager : UserControl
    {
        thuvienservice service;
        int newID;
        public book_manager()
        {
            service = new thuvienservice();
            InitializeComponent();
            show();
            loadcmb();
        }

        private void book_manager_Load(object sender, EventArgs e)
        {

        }
        public void loadcmb()
        {

            using (var context = new DBContext())
            {
                var data = context.TacGia.ToList();
                cmbtentacgia.DataSource = data;
                cmbtentacgia.DisplayMember = "tentacgia";

            }
        }
        public void show()

        {

            //txtsoluong.Enabled = false;
            datastatis.Visible = false;
            paner2.Visible = false;
            dtgsach.ColumnCount = 5;
            dtgsach.Columns[0].Name = "Mã Sách";
            dtgsach.Columns[0].Width = 150;
            dtgsach.Columns[1].Name = "Tên Sách";
            dtgsach.Columns[1].Width = 250;
            dtgsach.Columns[2].Name = "Số Trang";
            dtgsach.Columns[2].Width = 150;
            dtgsach.Columns[3].Name = "Số lượng";
            dtgsach.Columns[3].Width = 150;
            dtgsach.Columns[4].Name = "Tên Tác Giả";
            dtgsach.Columns[4].Width = 210;
            dtgsach.Rows.Clear();
            foreach (var i in service.sach(txttimkiemsach.Text))
            {
                dtgsach.Rows.Add(i.MaSachCt, i.TenDauSach, i.SoTrang, i.SoLuong, i.TenTacGia);
            }
        }
        private void txttimkiemsach_TextChanged(object sender, EventArgs e)
        {
            show();
        }
        public void TextSach(int id)
        {
            var s = service.sach(txttimkiemsach.Text).FirstOrDefault(x => x.MaSachCt == id);
            var a = service.TTSach(id).FirstOrDefault(x => x.MaSachCt == x.MaSachCt);
            txtTensach.Text = s.TenDauSach;
            txtsoluong.Text = s.SoLuong.ToString();
            txtsotrang.Text = s.SoTrang.ToString();
            txtmasach.Text = s.MaSachCt.ToString();
            if (s.MaSachCt == a.MaSachCt)
            {
                txtgia.Text = a.GiaSach.ToString("N0");
            }
            cmbtentacgia.Text = s.TenTacGia;
        }
        public void ShowKho()
        {

            dtgtinhtrang.ColumnCount = 3;
            dtgtinhtrang.Columns[0].Name = "MaSach";
            dtgtinhtrang.Columns[1].Name = "Tình trạng sách";
            dtgtinhtrang.Columns[0].Width = 200;
            dtgtinhtrang.Columns[1].Width = 200;
            dtgtinhtrang.Columns[2].Name = "giá sách";
            dtgtinhtrang.Rows.Clear();
            int con = 0;
            int het = 0;
            foreach (var x in service.TTSach(newID))
            {
                var sa = new CtSach();
                var s = new Sach();
                if (sa.MaSachCt == s.MaSachCt)
                {
                    dtgtinhtrang.Rows.Add(x.MaSach, x.TinhTrangSach,x.GiaSach.ToString("N0"));
                    if (x.TinhTrangSach == "Còn")
                    {
                        con++;
                    }
                    else if (x.TinhTrangSach == "đã mượn")
                    {
                        het++;
                    }
                }
            }
            datastatis.ColumnCount = 2;
            datastatis.Columns[0].Name = "Tình trạng";
            datastatis.Columns[1].Name = "Thống kê";
            datastatis.Rows.Clear();
            datastatis.Rows.Add("còn", con);
            datastatis.Rows.Add("đã mượn", het);



        }
        private void dtgtinhtrang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "" || txtTensach.Text == "" || txtsotrang.Text == "" || txtsoluong.Text == "" || txtgia.Text == "" || cmbtentacgia.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var S = new CtSach();
                S.MaSachCt = int.Parse(txtmasach.Text);
                S.TenDauSach = txtTensach.Text;
                S.SoLuong = int.Parse(txtsoluong.Text);
                S.SoTrang = int.Parse(txtsotrang.Text);
                S.TenTacGia = cmbtentacgia.Text;

                var tb = MessageBox.Show("Bạn có chắc chắn muốn thêm???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(service.ThemSach(S));
                    for (int i = 0; i < int.Parse(txtsoluong.Text); i++)
                    {
                        var ks = new Sach();
                        ks.MaSachCt = int.Parse(txtmasach.Text);
                        ks.TinhTrangSach = "Còn";
                        ks.GiaSach = Convert.ToDecimal(txtgia.Text);
                        service.masach(ks);
                    }
                    show();
                }
                else
                {
                    return;
                }
            }
        }
      
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "" || txtTensach.Text == "" || txtsotrang.Text == "" || txtsoluong.Text == "" || txtgia.Text == "" || cmbtentacgia.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var S = new CtSach();
                txtmasach.Enabled = false;
                S.MaSachCt = newID;
                S.TenDauSach = txtTensach.Text;
                S.SoLuong = int.Parse(txtsoluong.Text);
                S.SoTrang = int.Parse(txtsotrang.Text);
                S.TenTacGia = cmbtentacgia.Text;
                var tb = MessageBox.Show("Bạn có chắc chắn muốn Update???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(service.SuaSach(S));
                    var giaMoi = decimal.Parse(txtgia.Text);
                    using (var dbContext = new DBContext())
                    {
                        var sachDaCapNhat = dbContext.Saches .Where(s => s.MaSachCt == newID).ToList();

                        foreach (var sach in sachDaCapNhat)
                        {
                            sach.GiaSach = giaMoi;
                        }
                        dbContext.SaveChanges();
                      
                        //dbContext.Saches.Where(s => s.MaSachCt == s.MaSachCt).ToList().ForEach(s => s.GiaSach = giaMoi);
                        //dbContext.SaveChanges();
                    }
                  
                    show();

                }
                else
                {
                    return;
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "" || txtTensach.Text == "" || txtsotrang.Text == "" || txtsoluong.Text == "" || txtgia.Text == "" || cmbtentacgia.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var S = new CtSach();
                txtmasach.Enabled = false;
                S.MaSachCt = newID;
                S.TenDauSach = txtTensach.Text;
                S.SoLuong = int.Parse(txtsoluong.Text);
                S.SoTrang = int.Parse(txtsotrang.Text);
                S.TenTacGia = cmbtentacgia.Text;
                var tb = MessageBox.Show("Bạn có chắc chắn muốn delete???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(service.XoaSach(S));
                                   
                    show();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txtsoluong.Text = "";
            txtsotrang.Text = "";
            txtTensach.Text = "";
            cmbtentacgia.Text = "";
            txtsoluong.Enabled = true;
            txtmasach.Enabled = true;
        }




        private void dtgsach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var idrow = e.RowIndex;
            newID = int.Parse(dtgsach.Rows[idrow].Cells[0].Value.ToString());
            TextSach(newID);
            ShowKho();
            paner2.Visible = true;
            datastatis.Visible = true;
        }



        private void txttimkiemsach_TextChanged_1(object sender, EventArgs e)
        {
            show();
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex) { }
        }

        private void txtsotrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
            catch (Exception ex) { }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
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


















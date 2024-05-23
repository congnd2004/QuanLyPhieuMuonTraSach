using A_DAL.DomainClass;
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
    public partial class Reader_manager : UserControl
    {
        int newid;
        private sevicedocgia sevice;

        public Reader_manager()
        {
            sevice = new sevicedocgia();
            InitializeComponent();
            showdg();
        }

    

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtdiachi.Text == "" || txtphone.Text == "" || txtdoituong.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dg = new DocGium();
                dg.MaTheDocGia = newid;
                dg.HoTen = txtname.Text;
                dg.DiaChi = txtdiachi.Text;
                dg.DoiTuongDocGia = txtdoituong.Text;
                dg.NgaySinh = datebird.Value;
                dg.NgayLamThe = datecard.Value;
                dg.Sdt = txtphone.Text;
                var tb = MessageBox.Show("Bạn có chắc chắn muốn xóa???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(sevice.xoa(dg));
                    showdg();
                }
                else
                {
                    return;
                }
            }
        }

       
        public void showdg()
        {
            dtgdocgia.ColumnCount = 7;
            dtgdocgia.Columns[0].Name = "Mã thẻ độc giả";
            dtgdocgia.Columns[0].Width = 100;
            dtgdocgia.Columns[1].Name = "Tên độc giả";
            dtgdocgia.Columns[1].Width = 150;
            dtgdocgia.Columns[2].Name = "Số điện thoại";
            dtgdocgia.Columns[2].Width = 150;
            dtgdocgia.Columns[3].Name = "Ngày sinh";
            dtgdocgia.Columns[3].Width = 200;
            dtgdocgia.Columns[4].Name = "Ngày làm thẻ";
            dtgdocgia.Columns[4].Width = 200;
            dtgdocgia.Columns[5].Name = "Địa Chỉ";
            dtgdocgia.Columns[5].Width = 200;
            dtgdocgia.Columns[6].Name = "Đối tượng";
            dtgdocgia.Columns[6].Width = 130;
            dtgdocgia.Rows.Clear();
            foreach (var x in sevice.GetDocGiums(txtseach.Text))
            {
                dtgdocgia.Rows.Add(x.MaTheDocGia, x.HoTen, x.Sdt, x.NgaySinh, x.NgayLamThe, x.DiaChi, x.DoiTuongDocGia);
            }
        }

        private void txtseach_TextChanged(object sender, EventArgs e)
        {
            showdg();
        }

        private void dtgdocgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idrow = e.RowIndex;
            newid = int.Parse(dtgdocgia.Rows[idrow].Cells[0].Value.ToString());
            text(newid);
            textcode.Enabled = false;
        }
        public void text(int id)
        {
            var s = sevice.GetDocGiums(txtseach.Text).FirstOrDefault(x => x.MaTheDocGia == id);
            textcode.Text = s.MaTheDocGia.ToString();
            txtname.Text = s.HoTen;
            txtdiachi.Text = s.DiaChi;
            txtdoituong.Text = s.DoiTuongDocGia;
            datebird.Text = s.NgaySinh.ToString();
            datecard.Text = s.NgayLamThe.ToString();
            txtphone.Text = s.Sdt.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtdiachi.Text == "" || txtphone.Text == "" || txtdoituong.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dg = new DocGium();
                dg.HoTen = txtname.Text;
                dg.DiaChi = txtdiachi.Text;
                dg.DoiTuongDocGia = txtdoituong.Text;
                dg.NgaySinh = datebird.Value;
                dg.NgayLamThe = datecard.Value;
                dg.Sdt = txtphone.Text;
                var tb = MessageBox.Show("Bạn có chắc chắn muốn thêm???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(sevice.them(dg));
                    showdg();
                
                }
                else
                {
                    return;
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtdiachi.Text == "" || txtphone.Text == "" || txtdoituong.Text == "")
            {
                MessageBox.Show("thiếu thông tin!!! ", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var dg = new DocGium();
                dg.MaTheDocGia = newid;
                dg.HoTen = txtname.Text;
                dg.DiaChi = txtdiachi.Text;
                dg.DoiTuongDocGia = txtdoituong.Text;
                dg.NgaySinh = datebird.Value;
                dg.NgayLamThe = datecard.Value;
                dg.Sdt = txtphone.Text;
                var tb = MessageBox.Show("Bạn có chắc chắn muốn sửa???", "Thông báo", MessageBoxButtons.YesNo);
                if (tb == DialogResult.Yes)
                {
                    MessageBox.Show(sevice.sua(dg));
                    showdg();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            textcode.Text = "";
            txtphone.Text = "";
            txtdiachi.Text = "";
            txtdoituong.Text = "";
            txtname.Text = "";
            datebird.Text = "";
            datecard.Text = "";
            textcode.Enabled = true;
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
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

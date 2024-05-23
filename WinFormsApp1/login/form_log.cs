using A_DAL.Context;
using C_PRL.home_page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.login
{
    public partial class form_log : Form
    {
        private bool running = true;
        private DBContext _dbContext;
        public form_log()
        {

            _dbContext = new DBContext();
            InitializeComponent();
            this.AcceptButton = btn_login;
            RunTextColorAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private async void RunTextColorAsync()
        {
            while (running)
            {
                label3.ForeColor = GetNextColor();
                await Task.Delay(500);
            }
        }
        private Color GetNextColor()
        {
            Color[] colors = { Color.Yellow, Color.Red };

       
            int nextIndex = (Array.IndexOf(colors, label3.ForeColor) + 1) % colors.Length;
            return colors[nextIndex];
        }

        private void form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public class LoggedUser
        {
            public int Id { get; set; }
            public string TenNhanVien { get; set; }
            public string Gmail { get; set; }
            public string Pass { get; set; }
            public int Quyen { get; set; }
        }
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                using (var _dbcontext = new DBContext())
                {
                    var db = _dbcontext.Acounts.FirstOrDefault(d => d.Gmail == txtuserlg.Text && d.Pass == int.Parse(txtpasslg.Text));
                    if (db != null)
                    {
                        MessageBox.Show("Logged in successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var loggedUser = new LoggedUser
                        {
                            Id = db.MaNhanVien,
                            TenNhanVien = _dbcontext.NhanViens.FirstOrDefault(n => n.MaNhanVien == db.MaNhanVien)?.TenNhanVien,
                            Gmail = db.Gmail,
                            Pass = db.Pass.ToString(),
                            Quyen = (int)db.Quyen

                        };
                        form_home home = new form_home();
                        home.LoggedUser = loggedUser;
                        // home.Visible = false;
                        this.Hide();
                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("You have failed to login", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }catch(Exception) 
            {
                MessageBox.Show("thiếu thông tin đăng nhập","thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {

            if (checkpass.Checked == true)
            {
                txtpasslg.UseSystemPasswordChar = true;
            }
            else
            {
                txtpasslg.UseSystemPasswordChar = false;
            }
        }

        private void txtuserlg_Enter(object sender, EventArgs e)
        {
            if (txtuserlg.Text == "user name")
            {
                txtuserlg.Text = "";
                txtuserlg.ForeColor = Color.Black;
            }
        }

        private void txtuserlg_Leave(object sender, EventArgs e)
        {

            if (txtuserlg.Text == "")
            {
                txtuserlg.Text = "user name";
                txtuserlg.ForeColor = Color.Gray;
            }
        }

        private void txtpasslg_Enter(object sender, EventArgs e)
        {
            if (txtpasslg.Text == "password")
            {
                txtpasslg.Text = "";
                txtpasslg.ForeColor = Color.Black;
                txtpasslg.PasswordChar = '*';
            }
        }

        private void txtpasslg_Leave(object sender, EventArgs e)
        {
            if (txtpasslg.Text == "")
            {
                txtpasslg.Text = "password";
                txtpasslg.ForeColor = Color.Gray;
            }
        }
    }
}

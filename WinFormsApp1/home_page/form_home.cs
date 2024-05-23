using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C_PRL.login.form_log;

namespace C_PRL.home_page
{
    public partial class form_home : Form
    {
        public LoggedUser LoggedUser { get; set; }
        public form_home()
        {
            InitializeComponent();
            home_manager home = new home_manager();
            add_usercontrol(home);
        }
        public void add_usercontrol(Control control)
        {
            pt_main.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            pt_main.Controls.Add(control);
        }
        private void form_home_Load(object sender, EventArgs e)
        {

        }

        private void btn_homepage_Click(object sender, EventArgs e)
        {
            home_manager home = new home_manager();
            add_usercontrol(home);
        }

        private void brn_user_Click(object sender, EventArgs e)
        {
            User_manager user = new User_manager();
            user.LoggedUser = LoggedUser;
            add_usercontrol(user);
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            book_manager book = new book_manager();
            add_usercontrol(book);
        }

        private void btn_reader_Click(object sender, EventArgs e)
        {
            Reader_manager reader = new Reader_manager();

            add_usercontrol(reader);
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            loan_manager loan_ = new loan_manager();
            loan_.LoggedUser = LoggedUser;
            add_usercontrol(loan_);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit???", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void bth_retunr_Click(object sender, EventArgs e)
        {
            return_managercs return_ = new return_managercs();
            return_.LoggedUser = LoggedUser;
            add_usercontrol(return_);
        }
        public void SwitchToControl2(Control currentControl)
        {
            history newControl = new history();
            pt_main.Controls.Add(newControl);
            newControl.Location = currentControl.Location;
            newControl.Size = currentControl.Size;
            Debug.WriteLine($"New Control2 Location: {newControl.Location}");
            newControl.BringToFront();
            currentControl.Visible = false;
            this.Controls.Remove(currentControl);
            currentControl.Dispose();
            newControl.Visible = true;
            newControl.Focus();
        }
        public void SwitchToControl1(Control currentControl)
        {
            loan_manager newControl = new loan_manager();
            pt_main.Controls.Add(newControl);
            newControl.Location = currentControl.Location;
            newControl.Size = currentControl.Size;
            Debug.WriteLine($"New Control2 Location: {newControl.Location}");
            newControl.BringToFront();
            currentControl.Visible = false;
            this.Controls.Remove(currentControl);
            currentControl.Dispose();
            newControl.Visible = true;
            newControl.Focus();
        }
    }
}

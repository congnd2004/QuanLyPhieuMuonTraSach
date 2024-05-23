using A_DAL.DomainClass;
using B_BUS.service;
using C_PRL.login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static C_PRL.login.form_log;

namespace C_PRL.home_page
{
    public partial class User_manager : UserControl
    {

        public LoggedUser LoggedUser { get; set; }
        public User_manager()
        {
            InitializeComponent();
        }
        private void User_manager_Load(object sender, EventArgs e)
        {
            if (LoggedUser != null)
            {
                labelid.Text = LoggedUser.Id.ToString();
                labelname.Text = LoggedUser.TenNhanVien;
                labelgmail.Text = LoggedUser.Gmail;
                labelpass.Text = LoggedUser.Pass;
                if (LoggedUser.Quyen.ToString() == "1")
                {
                    labelquyen.Text = "admin";
                }
                else
                {
                    labelquyen.Text = "user";
                }
              
            }
        }
       

            private void btnlogout_Click(object sender, EventArgs e)
            {
            form_log login = new form_log();
            form_home home = new form_home();
            home = Application.OpenForms.OfType<form_home>().FirstOrDefault();
            if (home != null)
            {
                login.Show();
                home.Close();
            }
            else
            {
                login.Show();
            }


        }
    }
}

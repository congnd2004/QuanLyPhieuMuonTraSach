using C_PRL.home_page;
using C_PRL.login;

namespace WinFormsApp1
{
    internal static class Program
    {
        //Scaffold-DbContext 'Data Source=MINH-QUANG;Initial Catalog=ThuVien001;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;TrustServerCertificate=true' Microsoft.EntityFrameworkCore.SqlServer -OutputDir DomainClass -context DBContext -Contextdir Context -DataAnnotations -Force
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new form_log());
        }
    }
}
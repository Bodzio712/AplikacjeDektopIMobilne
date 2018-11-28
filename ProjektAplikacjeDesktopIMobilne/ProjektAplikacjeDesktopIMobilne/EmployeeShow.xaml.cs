using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Biblioteka.Model;
using ProjektAplikacjeDesktopIMobilne.XML;
using System.Configuration;

namespace ProjektAplikacjeDesktopIMobilne
{
    /// <summary>
    /// Logika interakcji dla klasy EmployeeShow.xaml
    /// </summary>
    public partial class EmployeeShow : Window
    {
        public EmployeeShow()
        {
            InitializeComponent();
        }

        private void Load (object sender, RoutedEventArgs e)
        {
            var emp = new Employee();
            emp = XMLActions.ReadEmployees(ConfigurationManager.AppSettings["employee"]);
            FirstName.Text = emp.FirstName;
            LastName.Text = emp.LastName;
            Phone.Text = emp.Phone;
            Job.Text = emp.Job;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            Close();
        }
    }
}

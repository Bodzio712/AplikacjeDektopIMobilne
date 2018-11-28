using System.Windows;
using Biblioteka.Model;
using System.Configuration;
using ProjektAplikacjeDesktopIMobilne.XML;

namespace ProjektAplikacjeDesktopIMobilne
{
    /// <summary>
    /// Logika interakcji dla klasy Employee.xaml
    /// </summary>
    public partial class EmloyeeForm : Window
    {
        public EmloyeeForm()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var emp = new Employee();
            emp.FirstName = FirstName.Text;
            emp.LastName = LastName.Text;
            emp.Phone = Phone.Text;
            emp.Job = Job.Text;

            XMLActions.SaveEmployees(ConfigurationManager.AppSettings["employee"], emp);

            var main = new MainWindow();
            main.Show();
            Close();
        }
    }
}

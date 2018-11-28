using System.Windows;
using Biblioteka.Model;
using System.Configuration;
using ProjektAplikacjeDesktopIMobilne.XML;


namespace ProjektAplikacjeDesktopIMobilne
{
    /// <summary>
    /// Logika interakcji dla klasy DepartmentForm.xaml
    /// </summary>
    public partial class DepartmentForm : Window
    {
        public DepartmentForm()
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
            var dep = new Department();
            dep.Name = Name.Text;
            dep.BossName = BossName.Text;
            dep.Address = Address.Text;

            XMLActions.SaveDepartment(ConfigurationManager.AppSettings["department"], dep);

            var main = new MainWindow();
            main.Show();
            Close();
        }
    }
}

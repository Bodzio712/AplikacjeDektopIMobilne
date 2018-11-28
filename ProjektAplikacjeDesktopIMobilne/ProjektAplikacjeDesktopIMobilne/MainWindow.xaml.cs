using System.Windows;
using ProjektAplikacjeDesktopIMobilne.XML;
using Biblioteka.Model;
using System.Configuration;

namespace ProjektAplikacjeDesktopIMobilne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddEmp_Click(object sender, RoutedEventArgs e)
        {
            var emp = new EmloyeeForm();
            emp.Show();
            Close();
        }

        private void Load(object sender, RoutedEventArgs e)
        {
            var emp = new Employee();
            emp = XMLActions.ReadEmployees(ConfigurationManager.AppSettings["employee"]);
            DataEmployee.Text = emp.ToString();

            var dep = new Department();
            dep = XMLActions.ReadDepartment(ConfigurationManager.AppSettings["department"]);
            DataDepatment.Text = dep.ToString();
        }

        private void AddDep_Click(object sender, RoutedEventArgs e)
        {
            var dep = new DepartmentForm();
            dep.Show();
            Close();
        }

        private void DeleteDep_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Czy na pewno chcesz usunąc oddział?", "Usunąć?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (res == MessageBoxResult.Yes)
            {
                var dep = new Department();
                dep.Address = "";
                dep.BossName = "";
                dep.Name = "";
                XMLActions.SaveDepartment(ConfigurationManager.AppSettings["department"], dep);
                DataDepatment.Text = dep.ToString();
            }
        }

        private void DeleteEmp_Click(object sender, RoutedEventArgs e)
        {
            var res = MessageBox.Show("Czy na pewno chcesz usunąc pracownika?", "Usunąć?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);

            if (res == MessageBoxResult.Yes)
            {
                var emp = new Employee();
                emp.FirstName = "";
                emp.LastName = "";
                emp.Job = "";
                emp.Phone = "";

                XMLActions.SaveEmployees(ConfigurationManager.AppSettings["employee"], emp);
                DataEmployee.Text = emp.ToString();
            }
        }
    }
}

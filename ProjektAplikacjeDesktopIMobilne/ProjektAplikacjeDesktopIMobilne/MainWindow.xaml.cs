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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjektAplikacjeDesktopIMobilne.XML;

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

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            var emp = new EmployeeShow();
            emp.Show();
            Close();
        }

        private void Test2_Click(object sender, RoutedEventArgs e)
        {
            var emp = new EmloyeeForm();
            emp.Show();
            Close();
        }
    }
}

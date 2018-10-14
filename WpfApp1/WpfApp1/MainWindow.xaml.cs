using System;
using System.Windows;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var u = new Models.User(NameBox.Text, SurnameBox.Text, DateTime.Parse(Date.Text));
                MessageBox.Show("Formularz został zapisany", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione", "Błąd danych", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            NameBox.Text = "";
            SurnameBox.Text = "";
            Date.Text = "";
        }
    }
}

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
using System.Collections.ObjectModel;


namespace UP_030101
{
    /// <summary>
    /// Логика взаимодействия для SpisUslug.xaml
    /// </summary>
    public partial class SpisUslug : Window
    {
        public static beauty_saloonEn DataEntitiesEmployee { get; set; }
        ObservableCollection<Service> ListServise;
        private bool isDirty;

        public SpisUslug()
        {
            var listTitle = new Service();
            this.Resources.Add(listTitle, "ListTitle");
            DataEntitiesEmployee = new beauty_saloonEn();
            InitializeComponent();
            ListServise = new ObservableCollection<Service>();

           
        }
        private void GetEmployees()
        {
            var servises = DataEntitiesEmployee.Service;
            var queryEmployee = from employee in servises
                                orderby employee.Title
                                select employee;
            foreach (Service emp in queryEmployee)
            {
                ListServise.Add(emp);
            }
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            GetEmployees();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 page = new Page1();
            MainFrame.Navigate(page);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UP_030101
{
    /// <summary>
    /// Логика взаимодействия для ZapisiPage.xaml
    /// </summary>
    public partial class ZapisiPage : Page
    {
        public static beauty_saloonEn DataEntitiesEmployee { get; set; }
        ObservableCollection<ClientService> ListServise;
        public ZapisiPage()
        {
            var listTitle = new ClientService();
            this.Resources.Add(listTitle, "ListTitle2");
            DataEntitiesEmployee = new beauty_saloonEn();
            InitializeComponent();
            ListServise = new ObservableCollection<ClientService>();
        }
        private void GetEmployees()
        {
            var servises = DataEntitiesEmployee.ClientService;
            var queryEmployee = from employee in servises
                                orderby employee.StartTime
                                select employee;
            foreach (ClientService emp in queryEmployee)
            {
                ListServise.Add(emp);
            }
            ListBoxEmployee2.ItemsSource = ListServise;
        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            GetEmployees();
            ListBoxEmployee2.SelectedIndex = 0;
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            ClientService _clientService = (sender as Button).DataContext as ClientService;
            
            var cnt = beauty_saloonEn.GetContext();

            ClientService clsv = new ClientService {
                ID = _clientService.ID
            };
            cnt.ClientService.Attach(clsv);
            cnt.ClientService.Remove(clsv);
            cnt.SaveChanges();
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit((sender as Button).DataContext as ClientService);
            edit.Show();
            
        }
    }
}

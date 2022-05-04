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

namespace UP_030101
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private ClientService editclientService = new ClientService();
        public Edit(ClientService Selectedclient)
        {
            if(Selectedclient != null)
            {
                editclientService = Selectedclient;
            }
            InitializeComponent();
            DataContext = editclientService;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Нажмите ОК для изменения текущей услуги", "Предупреждение", MessageBoxButton.OKCancel);
            if (editclientService.ID == 0)
            {
                beauty_saloonEn.GetContext().ClientService.Add(editclientService);
            }
            try
            {
                beauty_saloonEn.GetContext().SaveChanges();
                MessageBox.Show("Данные занесены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

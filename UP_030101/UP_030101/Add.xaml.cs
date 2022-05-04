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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        private ClientService _ClientAdd = new ClientService();
        public Add()
        {
            InitializeComponent();
            DataContext = _ClientAdd;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (_ClientAdd.ID == 0)
            {
                beauty_saloonEn.GetContext().ClientService.Add(_ClientAdd);
            }
            try
            {
                beauty_saloonEn.GetContext().SaveChanges();
                MessageBox.Show("данные занесены");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();

        }
    }
}

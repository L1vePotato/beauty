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
    /// Логика взаимодействия для EditSpis.xaml
    /// </summary>
    public partial class EditSpis : Window
    {
        private Service editService = new Service();
        public EditSpis(Service SelectedService)
        {
            if (SelectedService != null)
            {
                editService = SelectedService;
            }
            InitializeComponent();
            DataContext = editService;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Нажмите ОК для изменения текущей услуги", "Предупреждение", MessageBoxButton.OKCancel);
            if (editService.ID == 0)
            {
                beauty_saloonEn.GetContext().Service.Add(editService);
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

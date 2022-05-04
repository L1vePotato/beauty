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
    /// Логика взаимодействия для Zapisi.xaml
    /// </summary>
    public partial class Zapisi : Window
    {
        public Zapisi()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }
        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ZapisiPage page = new ZapisiPage();
            ZapFrame.Navigate(page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Add add = new Add();
            add.Show();
        }
    }
}

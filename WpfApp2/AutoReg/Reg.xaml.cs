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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public MainWindow mainwindow;

        public Reg(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainwindow = _mainWindow;
        }

        private void Button_Click_reg(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_back(object sender, RoutedEventArgs e)
        {
            mainwindow.OpenPage(MainWindow.pages.login);
        }
    }
}

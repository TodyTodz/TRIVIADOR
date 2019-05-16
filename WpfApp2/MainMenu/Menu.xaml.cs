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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public MainWindow mainWindow;

        public Menu(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            mainWindow.OpenPage(MainWindow.MainPages.profile);
        }

        private void MenuItem_Click_Profile(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.MainPages.profile);
        }

        private void MenuItem_Click_Courses(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.MainPages.course);
        }

        private void MenuItem_Click_Statist(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.MainPages.statistic);
        }

        private void MenuItem_Click_About(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.MainPages.about);
        }
    }
}

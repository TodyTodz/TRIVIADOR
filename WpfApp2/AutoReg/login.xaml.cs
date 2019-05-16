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
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public MainWindow mainWindow;

        public login(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.reg);
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.forget);
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
                if (Login.Text.Length > 0) 
                {
                    if (Password.Password.Length > 0) 
                    {
                        //DataTable dt_user = mainWindow.Select("SELECT * FROM [dbo].[users] WHERE [login] = '" + Login.Text + "' AND [password] = '" + Password.Password + "'");
                        //if (dt_user.Rows.Count > 0) 
                        {
                        mainWindow.Title = "Личный кабинет";
                        mainWindow.Height = 400;
                        mainWindow.Width = 600;
                        mainWindow.frame1.Visibility = System.Windows.Visibility.Hidden;
                        mainWindow.OpenPage(MainWindow.MainPages.menu);
                        MessageBox.Show("Пользователь авторизовался"); 
                        }
                        //else MessageBox.Show("Пользователь не найден"); 
                    }
                    else ErrorLabel.Content ="Введите пароль!"; 
                }
            else ErrorLabel.Content = "Введите логин!"; 
        }
        
    }
}

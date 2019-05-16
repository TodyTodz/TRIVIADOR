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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenPage(pages.login);
        }
        public enum pages
        {
            login,
            reg,
            forget
        }
        public enum MainPages
        { 
            menu,
            profile,
            course,
            statistic,
            about
        }

        public void OpenPage(pages Pag)
        {
            if (Pag == pages.login)
            {
                frame1.Navigate(new login(this));
            }
            else if (Pag == pages.reg)
            {
                frame1.Navigate(new Reg(this));
            }
            else if (Pag == pages.forget)
            {
                frame1.Navigate(new forget(this));
            } 
        }
        public void OpenPage(MainPages Pag)
        {
            if (Pag == MainPages.menu)
            {
                Menu.Navigate(new Menu(this));
            }
            else if (Pag == MainPages.profile)
            {
                AfterAuto.Navigate(new Profile(this));
            }
            else if (Pag == MainPages.course)
            {
                AfterAuto.Navigate(new Courses(this));
            }
            else if (Pag == MainPages.statistic)
            {
                AfterAuto.Navigate(new Statistic(this));
            }
            else if (Pag == MainPages.about)
            {
                AfterAuto.Navigate(new About(this));
            }
        }

    }
}

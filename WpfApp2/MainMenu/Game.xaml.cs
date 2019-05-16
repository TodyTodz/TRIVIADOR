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
using System.Net;
using System.Net.Sockets;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Courses : Page
    {

        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public Courses(MainWindow _mainWindow)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            socket.Bind(new IPEndPoint(IPAddress.Any, 2019));
            socket.Listen(1);
            Socket client = socket.Accept();
            byte[] ID = new byte[24];
            client.Receive(ID);
            MessageBox.Show(Encoding.ASCII.GetString(ID), Encoding.ASCII.GetString(ID));
            //Game ggg = new Game();
            //ggg.ShowDialog();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            socket.Connect(IPAddress.Loopback, 2019);
            string id = "1234";
            byte[] msg = Encoding.ASCII.GetBytes(id);
            socket.Send(msg);
        }
    }
}

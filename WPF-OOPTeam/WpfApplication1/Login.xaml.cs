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
using Test;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        MainWindow win = new MainWindow();

        public Login()
        {
            InitializeComponent();
            MyLoginWindow.Top = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - MyLoginWindow.Height;
            MyLoginWindow.Left = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) - MyLoginWindow.Width;
            win.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (Admin.IsCorrect(PassBox.Password))
            {

                MyLoginWindow.Close();
                win.IsEnabled = true;
            }
            else
            {
                PassBox.Background = Brushes.Red;
            }
        }
    }
}

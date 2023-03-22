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

namespace Usersapp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void reg_but_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxlogin.Text.Trim();
            string pass = PasswordText1.Password.Trim();
            string pass_2 = PasswordText2.Password.Trim();
            string number = number_phone.Text;
            if (login.Length < 5)
            {
                textBoxlogin.ToolTip = "Неккоректный логин";
                textBoxlogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5)
            {
                PasswordText1.ToolTip = "Неккоректный пароль";
                PasswordText1.Background = Brushes.DarkRed;
            }
            else if (pass != pass_2)
            {
                PasswordText2.ToolTip = "Неккоректный пароль";
                PasswordText2.Background = Brushes.DarkRed;
            }
            else if (number.Length < 11 || !number.Contains("7") || !number.Contains("+"))
            {
                PasswordText2.ToolTip = "Неккоректный номер телефона";
                PasswordText2.Background = Brushes.Red;
            }
            else 
            {
                textBoxlogin.ToolTip = "";
                textBoxlogin.Background = Brushes.Transparent;
                PasswordText1.ToolTip = "";
                PasswordText1.Background = Brushes.Transparent;
                PasswordText2.ToolTip = "";
                PasswordText2.Background = Brushes.Transparent;
                number_phone.ToolTip = "";
                number_phone.Background = Brushes.Transparent;
                MessageBox.Show("Регистрация прошла успешно");
            }
        }
    }
}

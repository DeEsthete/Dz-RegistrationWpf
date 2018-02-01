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

namespace Dz_RegistrationWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
        }

        public MainWindow(List<User> users)
        {
            this.users = users;
        }

        private void SignInButtonClick(object sender, RoutedEventArgs e)
        {
            bool IsFinded = false;
            foreach (var user in users)
            {
                if (user.Password == passwordTextBox.Text && user.Login == loginTextBox.Text)
                {
                    IsFinded = true;
                    new GreetingWindow(mainWindow, user).Show();
                }
            }
            if (!IsFinded)
            {
                MessageBox.Show("Неправильно введенный логин либо пароль");
            }
        }

        private void SignUpButtonClick(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow(mainWindow, users).Show();
        }
    }
}

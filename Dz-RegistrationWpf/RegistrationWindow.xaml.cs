using Microsoft.Win32;
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

namespace Dz_RegistrationWpf
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private List<User> users;
        private string path;
        private Window window;
        public RegistrationWindow(Window window ,List<User> users)
        {
            InitializeComponent();

            this.users = users;
            this.window = window;
            path = "";
            registrationWindow.Closed += RegistrationWindowClosed;

        }

        private void RegistrationWindowClosed(object sender, EventArgs e)
        {
            new MainWindow(users);
        }

        private void UpLoadImageButtonClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Картинки(*.PNG)| *.PNG";
            string path = "";
            if (browse.ShowDialog() == true)
            {
                path = browse.FileName;
            }
            if (path == null || path == "")
            {
                return;
            }
        }

        private void RegisterButtonClick(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text != null && loginTextBox.Text != "" && passwordTextBox.Text != null && passwordTextBox.Text != "" && emailTextBox.Text != null && emailTextBox.Text != "")
            {
                if (passwordTextBox.Text == repeatPasswordTextBox.Text)
                {
                    User temp = new User();
                    temp.Login = loginTextBox.Text;
                    temp.Password = passwordTextBox.Text;
                    temp.Email = emailTextBox.Text;
                    temp.imagePath = path;
                    if (aboutMeTextBox.Text != null)
                    {
                        temp.AboutMe = aboutMeTextBox.Text;
                    }
                    else
                    {
                        temp.AboutMe = "";
                    }
                    users.Add(temp);
                    registrationWindow.Close();
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
        }
    }
}

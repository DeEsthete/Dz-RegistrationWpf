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
    /// Логика взаимодействия для GreetingWindow.xaml
    /// </summary>
    public partial class GreetingWindow : Window
    {
        public GreetingWindow(Window window ,User user)
        {
            InitializeComponent();
            greetingTextBlock.Text = "Приветствую " + user.Login;
        }
    }
}

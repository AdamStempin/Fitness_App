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

namespace Fitness_App
{
        public partial class AddUser : Window
        {
            public AddUser()
            {
                InitializeComponent();
            }

            private void RemoveText(object sender, RoutedEventArgs e)
            {
                if (sender is TextBox textBox)
                {
                    if (textBox.Text == "Username" || textBox.Text == "E-mail")
                    {
                        textBox.Text = "";
                        textBox.Foreground = new SolidColorBrush(Colors.Black);
                    }
                }
            }

            private void AddText(object sender, RoutedEventArgs e)
            {
                if (sender is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Foreground = new SolidColorBrush(Colors.White);
                        textBox.Text = textBox.Name == "UsernameTextBox" ? "Username" : "E-mail";
                    }
                }
            }

            private void RemovePasswordText(object sender, RoutedEventArgs e)
            {
                if (sender is PasswordBox passwordBox)
                {
                    if (passwordBox.Password == "Password")
                    {
                        passwordBox.Password = "";
                        passwordBox.Foreground = new SolidColorBrush(Colors.Black);
                    }
                }
            }

            private void AddPasswordText(object sender, RoutedEventArgs e)
            {
                if (sender is PasswordBox passwordBox)
                {
                    if (string.IsNullOrWhiteSpace(passwordBox.Password))
                    {
                        passwordBox.Foreground = new SolidColorBrush(Colors.White);
                        passwordBox.Password = "Password";
                    }
                }
            }

        private void google_Click(object sender, RoutedEventArgs e)
        {
            var window = new Signupgoogle();
            window.ShowDialog();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            Close();    
        }
    }
}



using authorization.dbcontext;
using authorization.Views.AdminPage;
using authorization.Views.UserPage;
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

namespace authorization.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        // АВТОРИЗАЦИЯ

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = dbContext.db.SignIn.FirstOrDefault(item => item.Username == textboxLogin.Text && item.Password == textboxPassword.Password);
            if (currentUser != null)
            {
                switch (currentUser.IDRole)
                {
                    case "A":
                        MessageBox.Show("Здравствуйте администратор!");
                        NavigationService.Navigate(new PageAdmin()); 
                        break;
                    case "U":
                        MessageBox.Show("Здравствуйте пользователь!");
                        NavigationService.Navigate(new PageUser());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Вы можете войти в нашу систему как администратор, либо как пользователь.{Environment.NewLine}Ввеедите нужные данные для входа!", "Подсказка", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

using authorization.databaseSQL;
using authorization.dbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace authorization.Views.AdminPage.AddAdmin
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }

        // ДОБАВЛЕНИЯ
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Work newWork = new Work();
            CompletingOfTheWork newCompleting = new CompletingOfTheWork();
            Employee newEmployee = new Employee();

            newEmployee.PersonnelNomer = Convert.ToInt32(tb1.Text);
            newEmployee.FullName = tb2.Text;
            newEmployee.Position = tb3.Text;
            newCompleting.NomerJob = Convert.ToInt32(tb4.Text);
            newCompleting.NameWork = (tb5.Text);
            newCompleting.Laboriousness = Convert.ToInt32(tb6.Text);
            newCompleting.DataOfComplite = Convert.ToDateTime(tb7.SelectedDate);
            newCompleting.PlannedEndDate = Convert.ToDateTime(tb8.SelectedDate);
            newCompleting.Readiness = Convert.ToInt32(tb9.Text);
            newWork.JobNomer = newCompleting.ID;
            newWork.Worker = newWork.ID;



           
            dbContext.db.CompletingOfTheWork.Add(newCompleting);
            dbContext.db.Employee.Add(newEmployee);
            dbContext.db.Work.Add(newWork);
            dbContext.db.SaveChanges();

            MessageBox.Show("Вы добавили новые данные!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = ("");
            tb2.Text = ("");
            tb3.Text = ("");
            tb4.Text= ("");
            tb5.Text = ("");
            tb6.Text = ("");
            tb7.Text = ("");
            tb8.Text = ("");
            tb9.Text = ("");
        }

        private void ButtonGoBackEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
        }

        private void tb1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tb2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regax = new Regex("[^А-я]+");
            e.Handled = regax.IsMatch(e.Text);
        }

        private void tb3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regax = new Regex("[^А-я]+");
            e.Handled = regax.IsMatch(e.Text);
        }

        private void tb4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void tb5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regax = new Regex("[^А-я]+");
            e.Handled = regax.IsMatch(e.Text);
        }
        private void tb6_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private void tb9_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

using authorization.databaseSQL;
using authorization.dbcontext;
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

namespace authorization.Views.AdminPage.Edit
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Work selectedItems;

        public EditPage()
        {
            InitializeComponent();
        }

        // Страница редактирования
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public EditPage (Work selectedItems)
        {
            InitializeComponent();
            this.selectedItems = selectedItems;
            tb1.Text = Convert.ToString(selectedItems.Employee.PersonnelNomer); // номер    
            tb2.Text = (selectedItems.Employee.FullName); // фио
            tb3.Text = (selectedItems.Employee.Position); //должность
            tb4.Text = Convert.ToString(selectedItems.CompletingOfTheWork.NomerJob);//номер работы
            tb5.Text = Convert.ToString(selectedItems.CompletingOfTheWork.NameWork);//название работы
            tb6.Text = Convert.ToString(selectedItems.CompletingOfTheWork.Laboriousness); // nheljtvrjcnm
            tb7.SelectedDate = (DateTime)(selectedItems.CompletingOfTheWork.DataOfComplite);//трудоемкость
            tb8.SelectedDate = (DateTime)(selectedItems.CompletingOfTheWork.PlannedEndDate); //дата завершеня
            tb9.Text = Convert.ToString(selectedItems.CompletingOfTheWork.Readiness);  //планруемая дата завершиня
            //завершенность
            
        }          

        private void ButtonGoBackEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = (" ");
            tb2.Text = (" ");
            tb3.Text = (" ");
            tb4.Text = (" ");
            tb5.Text = (" ");
            tb6.Text = (" ");
            tb7.Text = (" ");
            tb8.Text = (" ");
            tb9.Text = (" ");
        }

        private void ButtonEditPage_Click(object sender, RoutedEventArgs e)
        {
            Work Save = dbContext.db.Work.FirstOrDefault(Item => Item.ID == selectedItems.ID);
            Save.Employee.PersonnelNomer = Convert.ToInt32(tb1.Text);
            Save.Employee.FullName = (tb2.Text);
            Save.Employee.Position =(tb3.Text);
            Save.CompletingOfTheWork.NomerJob = Convert.ToInt32(tb4.Text);
            Save.CompletingOfTheWork.NameWork = tb5.Text;
            Save.CompletingOfTheWork.Laboriousness = Convert.ToInt32(tb6.Text);
            Save.CompletingOfTheWork.DataOfComplite = Convert.ToDateTime(tb7.Text);
            Save.CompletingOfTheWork.PlannedEndDate = Convert.ToDateTime(tb8.Text);
            Save.CompletingOfTheWork.Readiness = Convert.ToInt32(tb9.Text);
            dbContext.db.SaveChanges();
            MessageBox.Show("Вы изменили данные!", "Изменение", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();

            
        }

    }
}

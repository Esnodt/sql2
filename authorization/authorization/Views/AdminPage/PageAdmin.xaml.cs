using authorization.dbcontext;
using authorization.databaseSQL;
using authorization.Views.AdminPage.Edit;
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
using authorization.Views.AdminPage.AddAdmin;
using authorization.Views.AdminPage.MoreInfo;

namespace authorization.Views.AdminPage
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page {


        public PageAdmin() {
            InitializeComponent();
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            DataGridTablica.ItemsSource = dbContext.db.Work.ToList();
        }



          

        private void ButtonDelete_Click(object sender, RoutedEventArgs e) // УДАЛЕНИЕ
        {
            try
            {
                Work deleteWork = (Work)DataGridTablica.SelectedItem;
                if (MessageBox.Show(messageBoxText: "Вы действительно хотите удалить выбранную строку?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (deleteWork != null)
                    {
                        dbContext.db.Work.Remove(deleteWork);
                        dbContext.db.SaveChanges();
                        Page_Loaded_1(sender: null, e: null);
                        MessageBox.Show("Вы удалили строку", "Оповещание", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    else
                        throw new Exception(message: "Вы не выбрали строку которые хотите удалить!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Work deleteAllWork = (Work)DataGridTablica.SelectedItem;
                if (MessageBox.Show("Вы точно хотите удалить все строки в таблице? Назад вернуть их будет не возможно!", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (MessageBox.Show("ВЫ ТОЧНО УВЕРЕНЫ???", "Последние предупреждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (deleteAllWork != null)
                        {
                            dbContext.db.Work.RemoveRange(dbContext.db.Work);
                            dbContext.db.SaveChanges();
                            Page_Loaded_1(sender: null, e: null);
                            MessageBox.Show("Вы удалили все строки", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                            throw new Exception(message: "Вам надо выбрать минимум одну строку!");
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e) // ПЕРЕХОД НА РЕДАКТИРОВАНИЕ
        {
            try
            {
                Work EditWork = (Work)DataGridTablica.SelectedItem;
                if (EditWork != null)
                {
                    NavigationService.Navigate(new EditPage(EditWork));
                }

                else
                {
                    throw new Exception("Вы не выбрали не одного элменента!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void ButtonGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataGridTablica.ItemsSource = dbContext.db.Work.ToList();
        }

        private void textboxSearch_TextChanged(object sender, TextChangedEventArgs e) // ПОИСК
        {
            DataGridTablica.ItemsSource = dbContext.db.Work.Where(item => item.CompletingOfTheWork.NameWork.Contains(textboxSearch.Text) 
            || item.Employee.FullName.ToString().Contains(textboxSearch.Text)   
            || item.CompletingOfTheWork.Readiness.ToString().Contains(textboxSearch.Text)).ToList();
        }

        private void DataGridTablica_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());

        }



    }
}



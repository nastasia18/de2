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
using System.Windows.Threading;

namespace DEMLASTMAY
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            InitializeComponent();

            var loginList = ConnectDB.conObj.Employee.Select(x => x.EmployeeLogin).Distinct().ToList();
            loginList.Insert(0, "Все");
            ComboFilter.ItemsSource = loginList;
            ComboFilter.SelectedIndex = 0;
            DateSort.SelectedIndex = 0;
        }

        public void UpdateData()
        {
            var History = ConnectDB.conObj.EmpoyeeHistory.ToList();
            if (ComboFilter.SelectedIndex > 0)
            {
                History = History.Where(x =>
                x.EmployeeLogin.Contains(ComboFilter.SelectedItem as string)).ToList();
            }

            if(DateSort.SelectedIndex != 0)
            {
                History = History.OrderByDescending(p => p.EmployeeDataLogin).ToList();
            } else
            {
                History = History.OrderBy(p => p.EmployeeDataLogin).ToList();
            }
                
            GridHistory.ItemsSource = History;
        }

        private void BtnBackHistory_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ConnectDB.conObj.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                GridHistory.ItemsSource = ConnectDB.conObj.EmpoyeeHistory.ToList();
            }
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }

        private void DateSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
    }
}

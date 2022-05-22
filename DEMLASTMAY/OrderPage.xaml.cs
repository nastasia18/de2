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

namespace DEMLASTMAY
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();

            var orderList = ConnectDB.conObj.Order.ToList().Last();
            int currentIndex = orderList.OrderID + 1;
            numberOrder.Text = currentIndex.ToString();

            var clientList = ConnectDB.conObj.Client.ToList();
            comboClient.ItemsSource = clientList;

            var serviceList = ConnectDB.conObj.Service.ToList();
            comboService.ItemsSource = serviceList;
        }

        private void BtnBackOrder_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void createClient_Click(object sender, RoutedEventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.Show();
            var clientList = ConnectDB.conObj.Client.ToList();
            comboClient.ItemsSource = clientList;
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

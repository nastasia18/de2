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
    /// Логика взаимодействия для SellerPage.xaml
    /// </summary>
    public partial class SellerPage : Page
    {
        private Employee _currentEmployee = new Employee();
        private EmployeePost _currentEmployeePost = new EmployeePost();
        public int seconds;
        public SellerPage(string selectedEmployeeLogin)
        {
            InitializeComponent();

            if (selectedEmployeeLogin != null)
            {
                _currentEmployee = ConnectDB.conObj.Employee.Where(user => user.EmployeeLogin == selectedEmployeeLogin)
                    .FirstOrDefault();
            }

            DataContext = _currentEmployee;

            try
            {
                string i = EmployeePostText.Text.Trim();
                EmployeePostText.Text = ConnectDB.conObj.EmployeePost.Where(post => post.PostID.ToString() == i).Select(p => p.PostName).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            DispatcherTimer timer = new DispatcherTimer();
            seconds = 0;

            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(dispatcherTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            seconds += 1;

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            TimerText.Text = time.ToString(@"hh\:mm");

            if (seconds == 600)
            {
                Manager.MainFrame.Navigate(new AutorizationPage());
            }

            if (seconds == 300)
            {
                MessageBox.Show("До окончания сеанса осталось 5 минут", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}

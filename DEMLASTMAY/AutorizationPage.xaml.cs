using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        private Employee _currentEmployee = new Employee();
        private EmpoyeeHistory _currentEmployeeLogin = new EmpoyeeHistory();
        public AutorizationPage()
        {
            InitializeComponent();

            ConnectDB.conObj = new demLastMayEntities1(); 
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim();
            string password = Password.Password.Trim();

            if (login.Length < 2)
            {
                Login.ToolTip = "Логин введен некорректно!";
            }
            else if (password.Length < 2)
            {
                Password.ToolTip = "Пароль введен некорректно!";
            }
            else
            {
                Login.ToolTip = "";
                Password.ToolTip = "";

                object triggerAuth = null;
                triggerAuth = ConnectDB.conObj.Employee.Where(user => user.EmployeeLogin == login &&
                user.EmployeePassword == password).FirstOrDefault();

                DataContext = triggerAuth;

                DateTime localDate = DateTime.Now;
                var culture = new CultureInfo("ru-RU");

                if (triggerAuth != null)
                {
                    var triggerEmployee = ConnectDB.conObj.Employee.Where(user => user.EmployeeLogin == login).FirstOrDefault();
                    //MessageBox.Show("Вы авторизавались!");
                    int id = ConnectDB.conObj.Employee.Where(user => user.EmployeeLogin == login)
                        .Select(p => p.PostID).FirstOrDefault();
                    if(id == 1)
                    {
                        Manager.MainFrame.Navigate(new SellerPage(login));
                    }
                    else if(id == 2)
                    {
                        Manager.MainFrame.Navigate(new AdminPage(login));
                    } else
                    {
                        Manager.MainFrame.Navigate(new UserPage(login));
                    }
                    Login.Text = "";

                    if (triggerEmployee != null)
                    {
                        triggerEmployee.EmployeeDataLogin = localDate;
                        triggerEmployee.EmployeeStatus = true;

                        _currentEmployeeLogin.EmployeeLogin = triggerEmployee.EmployeeLogin;
                        _currentEmployeeLogin.EmployeeDataLogin = triggerEmployee.EmployeeDataLogin;
                        _currentEmployeeLogin.LoginStatus = triggerEmployee.EmployeeStatus;
                        ConnectDB.conObj.EmpoyeeHistory.Add(_currentEmployeeLogin);
                    }
                } else
                {
                    var triggerEmployee = ConnectDB.conObj.Employee.Where(user => user.EmployeeLogin == login).FirstOrDefault();
                    MessageBox.Show("Введено что-то некорректно");

                    if (triggerEmployee != null)
                    {
                        triggerEmployee.EmployeeDataLogin = localDate;
                        triggerEmployee.EmployeeStatus = false;

                        _currentEmployeeLogin.EmployeeLogin = triggerEmployee.EmployeeLogin;
                        _currentEmployeeLogin.EmployeeDataLogin = triggerEmployee.EmployeeDataLogin;
                        _currentEmployeeLogin.LoginStatus = triggerEmployee.EmployeeStatus;
                        ConnectDB.conObj.EmpoyeeHistory.Add(_currentEmployeeLogin);
                    } else
                    {
                        _currentEmployeeLogin.EmployeeLogin = login;
                        _currentEmployeeLogin.EmployeeDataLogin = localDate;
                        _currentEmployeeLogin.LoginStatus = false;
                        ConnectDB.conObj.EmpoyeeHistory.Add(_currentEmployeeLogin);
                    }
                }

                try
                {
                    ConnectDB.conObj.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void ImgShowHide_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            HidePassword();
        }

        private void ImgShowHide_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPassword();
        }

        private void txtPasswordbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Password.Password.Length > 0)  
                TextShowHide.Visibility = Visibility.Visible;
            else
                TextShowHide.Visibility = Visibility.Hidden;
        }

        private void ImgShowHide_MouseLeave(object sender, MouseEventArgs e)
        {
            HidePassword();
        }

        void ShowPassword()
        {
            TextShowHide.Text = "Скрыть";
            txtVisiblePasswordbox.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Hidden;
            txtVisiblePasswordbox.Text = Password.Password;
        }
        void HidePassword()
        {
            TextShowHide.Text = "Показать";
            txtVisiblePasswordbox.Visibility = Visibility.Hidden;
            Password.Visibility = Visibility.Visible;
            Password.Focus();
        }
    }
}

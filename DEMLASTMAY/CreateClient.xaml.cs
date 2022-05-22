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

namespace DEMLASTMAY
{
    /// <summary>
    /// Логика взаимодействия для CreateClient.xaml
    /// </summary>
    public partial class CreateClient : Window
    {
        private Client _currentClient = new Client();
        public CreateClient()
        {
            InitializeComponent();
            DataContext = _currentClient;
        }

        private void addClint_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentClient.ClientCode))
            {
                errors.AppendLine("Укажите код клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientSurname))
            {
                errors.AppendLine("Укажите фамилию клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientFirstName))
            {
                errors.AppendLine("Укажите имя клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPassportSeries))
            {
                errors.AppendLine("Укажите серию паспорта клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPassportNumber))
            {
                errors.AppendLine("Укажите номер паспорта клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientIndex))
            {
                errors.AppendLine("Укажите корректный индекс");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientCity))
            {
                errors.AppendLine("Укажите город клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientStreet))
            {
                errors.AppendLine("Укажите улицу клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientHouse))
            {
                errors.AppendLine("Укажите дом клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientEmail))
            {
                errors.AppendLine("Укажите почту клиента");
            }
            if (string.IsNullOrWhiteSpace(_currentClient.ClientPassword))
            {
                errors.AppendLine("Укажите пароль клиента");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            ConnectDB.conObj.Client.Add(_currentClient);

            try
            {
                ConnectDB.conObj.SaveChanges();
                MessageBox.Show("Информация сохранена");
                CreateClient createClient = new CreateClient();
                createClient.Close();

                ConnectDB.conObj.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMLASTMAY
{
    class User
    {
        private int EmployeeID { get; set; }
        private int PostID { get; set; }
        private string EmployeeSurname { get; set; }
        private string EmployeeFirstName { get; set; }
        private string EmployeePatronymic { get; set; }
        private string EmployeeLogin { get; set; }
        private string EmployeePassword { get; set; }
        private DateTime EmployeeDataLogin { get; set; }
        private int StatusLogID { get; set; }

        public User() { }

        public User(string EmployeeLogin, string EmployeePassword)
        {
            this.EmployeeLogin = EmployeeLogin;
            this.EmployeePassword = EmployeePassword;
        }
    }
}

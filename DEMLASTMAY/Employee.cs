//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DEMLASTMAY
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public int PostID { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeePatronymic { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
        public System.DateTime EmployeeDataLogin { get; set; }
        public string EmployeeImagePath { get; set; }
        public bool EmployeeStatus { get; set; }
    
        public virtual EmployeePost EmployeePost { get; set; }
    }
}

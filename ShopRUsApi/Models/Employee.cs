using System.ComponentModel;

namespace ShopRUsApi.Models
{
    public class Employee
    {
        [DisplayName("EmployeeId")]
        public int EmployeeId { get; set; } 

        [DisplayName("EmployeeName")]
        public string EmployeeName { get; set; }

        [DisplayName("EmployeeSurname")]
        public int EmployeeSurname { get; set; }


    }
}

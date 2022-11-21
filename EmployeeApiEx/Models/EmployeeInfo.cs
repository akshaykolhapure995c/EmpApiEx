using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.Data.Sql;
namespace EmployeeApiEx.Models
{
    public class EmployeeInfo
    {
        [Key]
        public int  EmployeeID { get; set; }

        [Required(ErrorMessage = "Employee Name Required")]
        public string EmployeeFName { get; set; }

        [Required(ErrorMessage = "Employee Name Required")]
        public string EmployeeLName { get; set; } 

        [Required(ErrorMessage = "Email Address Required!")]
        [EmailAddress(ErrorMessage = "Invalid Email ID")] 
        public string EmailID { get; set; }
        
        [Required(ErrorMessage = "Employee Age Required")]
        public Int64? Age { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int empId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public int EmpRoleID { get; set; }
        public EmployeeRole Role { get; set; }
        public int Location_ID { get; set; }
        public EmployeeLocation EmployeeLocation { get; set; }

        public string PhoneNumber { get; set; }
        public EmployeePhoneNumber EmployeePhoneNumber { get; set; }
    }
}

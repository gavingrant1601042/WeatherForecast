using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data
{
    public class EmployeeRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpRoleID { get; set; }
        public string Role { get; set; }
        public IList<Employees> Employee { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data
{
    public class EmployeePhoneNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeePhoneNumber_ID { get; set; }

        public string PhoneNumber { get; set; }
        public IList<Employees> Employee { get; set; }
    }
}

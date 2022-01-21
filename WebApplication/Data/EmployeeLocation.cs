using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Data
{
    public class EmployeeLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public IList<Employees> Employee { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;

namespace WebApplication.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeRole> Role { get; set; }
        public DbSet<EmployeeLocation> Location { get; set; }
        public DbSet<EmployeePhoneNumber> PhoneNumber { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 

        }
    }
}

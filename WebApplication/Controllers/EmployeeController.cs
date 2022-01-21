using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View("Employees");
        }

        public ActionResult SaveRecordForEmployee(Employees model)
        {
            try
            {
                
                Employees emp = new Employees();
                emp.Email = model.Email;    
                emp.FirstName = model.FirstName;
                emp.Lastname = model.Lastname;
                emp.EmpRoleID = model.EmpRoleID;
                emp.Location_ID = model.Location_ID;
                emp.PhoneNumber = model.PhoneNumber;
                
                _context.Add(emp);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("EmployeeLocation");

        }

        public ActionResult SaveRecordForRole(EmployeeRole model)
        {

            try
            {
                EmployeeRole emp = new EmployeeRole();
                emp.Role = model.Role;
                _context.Add(emp);
                 _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Index");

        }
        public ActionResult SaveRecordForLocation(EmployeeLocation model)
        {

            try
            {
                EmployeeLocation emp = new EmployeeLocation();
                emp.City = model.City;
                emp.Country = model.Country;
                emp.Address = model.Address;

                _context.Add(emp);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("EmployeePhoneNumber");

        }
        public ActionResult SaveRecordForPhoneNumber(EmployeePhoneNumber model)
        {
            try
            {
                EmployeePhoneNumber emp = new EmployeePhoneNumber();
                emp.PhoneNumber = model.PhoneNumber;    
                _context.Add(emp);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("EmployeeRole");

        }

        public ActionResult Display(Employees model)
        {
            var emp = _context.Employees.ToList();
            if (emp != null)
            {
                Console.WriteLine(emp);
            }
            return View("DisplayEmployees", emp);
        }
        public ActionResult DisplayLocation (EmployeeLocation model)
        {
            var emp = _context.Location.ToList();
            if (emp != null)
            {
                Console.WriteLine(emp);
            }
            return View("DisplayLocation", emp);
        }
        public ActionResult DisplayRole(EmployeeRole model)
        {
            var emp = _context.Role.ToList();
            if (emp != null)
            {
                Console.WriteLine(emp);
            }
            return View("DisplayRole", emp);
        }
        public ActionResult DisplayPhoneNumber(EmployeeRole model)
        {
            var emp = _context.PhoneNumber.ToList();
            if (emp != null)
            {
                Console.WriteLine(emp);
            }
            return View("DisplayPhoneNumber", emp);
        }





















        //public ActionResult Display(Employee model)
        //{
        //    var emp = _context.Employee.ToList();
        //    if (emp != null)
        //    {
        //        Console.WriteLine(emp);
        //    }
        //    return View("Listof_Employees",emp);
        //}
        //[HttpPost]
        //public ActionResult SaveRecord(Employee model)
        //{
        //    try
        //    {
        //        Employee emp = new Employee();
        //        emp.EmailId = model.EmailId;
        //        emp.FirstName = model.FirstName;
        //        emp.Lastname = model.Lastname;
        //        emp.city = model.city;
        //        emp.country = model.country;
        //        emp.telephone = model.telephone;
        //        emp.role = model.role;
        //        emp.address_location = model.address_location;
        //        emp.password = model.password;
        //        _context.Add(emp);
        //        _context.SaveChanges();
        //    }catch(Exception e)
        //    {
        //        Console.WriteLine("Duplicate Data was found");

        //    }
        //        return RedirectToAction("Index");
        //}
    }

}

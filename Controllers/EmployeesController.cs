using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class EmployeesController : ApiController
    {
        #region DbContext
        private readonly ApplicationDbContext _context;
        public EmployeesController() => _context = new ApplicationDbContext();
        protected override void Dispose(bool disposing) => _context.Dispose();
        #endregion

        [HttpGet]
        public IHttpActionResult GetEmployees()
        {
            var employees = _context.Employees.ToList();
            return Ok(employees);
        }

        [HttpGet]
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            return Ok(employee);
        }

        [HttpPost]
        public IHttpActionResult CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + employee.Id), employee);
        }

        [HttpPut]
        public IHttpActionResult UpdateEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            var existingEmployee = _context.Employees.Find(id);
            if (existingEmployee == null)
                return NotFound();

            existingEmployee.Name = employee.Name;
            existingEmployee.Department = employee.Department;
            existingEmployee.Salary = employee.Salary;

            _context.SaveChanges();

            return Ok(existingEmployee);
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return Ok(employee);
        }
    }
}

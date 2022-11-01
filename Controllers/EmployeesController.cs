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
        public IEnumerable<Employee> Employees()
        {
            return _context.Employees.ToList();
        }







    }
}

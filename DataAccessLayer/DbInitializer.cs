using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIDemo.Models;

namespace WebAPIDemo.DataAccessLayer
{
    public class DbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);

            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=Guid.NewGuid(), FirstName = "Mark",LastName = "Hastings",Gender = "Male",Salary = 5000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Jane",LastName = "Doe",Gender = "Female",Salary = 23000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Ben",LastName = "Smith",Gender = "Male",Salary = 70000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Hastings",LastName = "Philip",Gender = "Male",Salary = 45000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Lambeth",LastName = "Mary",Gender = "Female",Salary = 30000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Valerie",LastName = "Vicky",Gender = "Female",Salary = 35000},
                new Employee{Id=Guid.NewGuid(), FirstName = "Stanley",LastName = "John",Gender = "Male",Salary = 80000},
            };
            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();


            context.Dispose();
        }

        public override void InitializeDatabase(ApplicationDbContext context)
        {
            //base.InitializeDatabase(context);
            this.Seed(context);
        }
    }

}
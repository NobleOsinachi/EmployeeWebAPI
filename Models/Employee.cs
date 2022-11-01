using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender{ get; set; }
        [DataType(DataType.Currency)]
        [Index(IsUnique =true)]
        public decimal Salary{ get; set; }
    }
}
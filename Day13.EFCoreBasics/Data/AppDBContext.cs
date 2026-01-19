using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day13.EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;




namespace Day13.EFCoreBasics.Data
{
    internal class AppDBContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("EmployeeDB");
        }
    }
}

using System;
using System.Linq;
using Day13.EFCoreBasics.Data;
using Day13.EFCoreBasics.Models;
using Microsoft.EntityFrameworkCore;


class Pogram
{
    static void Main()
    {
        using var context = new AppDBContext();

        // Insert Data
        context.Employees.Add(new Employee
        {
            Name="Rahul",
            Age=30,
            Salary=60000
        }  );

        context.Employees.Add( new Employee { 
        Name="Anita",
        Age=28,
        Salary=45000
        });
        context.SaveChanges();
        Console.WriteLine("Data Inserted");

        //Fetch Data
        var heightestSalEmp = context.Employees.Where(e=>e.Salary>50000).ToList();
        Console.WriteLine("Employee salary >50,000");

        foreach(var h in heightestSalEmp)
        {
            Console.WriteLine($"{h.Name}-{h.Salary}");
        }

        var readonlyEmployee = context.Employees.AsNoTracking().ToList();
        Console.WriteLine("As No Tracking employees fetched");
    }
}

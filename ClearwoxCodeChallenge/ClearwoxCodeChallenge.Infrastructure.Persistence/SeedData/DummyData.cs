using ClearwoxCodeChallenge.Domain.Entities;
using ClearwoxCodeChallenge.Infrastructure.Persistence.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ClearwoxCodeChallenge.Infrastructure.Persistence.SeedData
{
    public static class DummyData
    {
        public static void PrepPopulation(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                SeedDepartmentData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
                SeedEmployeeData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
            }
        }
        public static void SeedDepartmentData(ApplicationDbContext context)
        {
            if (!context.Employee.Any())
            {
                Console.WriteLine("Seeding Data.............");
                context.Department.AddRange(
                     new Department() { DepartmentId = 1, Address = "Lagos address" }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("==>> I already have data");
            }
        }
        public static void SeedEmployeeData(ApplicationDbContext context)
        {
            if (!context.Employee.Any())
            {
                Console.WriteLine("Seeding Data.............");
                context.Employee.AddRange(
                    new Employee() { EmployeeId = 1, FirstName = "Anthony", LastName = "Ikemefuna", Address = "Ikeja Lagos Nigeria", JobTitle = "Software Engineer", DepartmentId = 1 },
                       new Employee() { EmployeeId = 2, FirstName = "James", LastName = "Manuel", Address = "Ikeja Lagos Nigeria", JobTitle = "Software Tester", DepartmentId = 2 },
                          new Employee() { EmployeeId = 3, FirstName = "Mary", LastName = "Joshua", Address = "Ikeja Lagos Nigeria", JobTitle = "Soultions Developer", DepartmentId = 1 }
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("==>> I already have data");
            }
        }

    }
}

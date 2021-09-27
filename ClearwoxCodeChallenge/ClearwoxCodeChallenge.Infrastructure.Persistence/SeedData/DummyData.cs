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
                SeedPlatformData(serviceScope.ServiceProvider.GetService<ApplicationDbContext>());
            }
        }
        public static void SeedPlatformData(ApplicationDbContext context)
        {
            if (!context.Employee.Any())
            {
                Console.WriteLine("Seeding Data.............");
                context.Employee.AddRange(

                );
            }
            else
            {
                Console.WriteLine("==>> I already have data");
            }
        }
    }
}

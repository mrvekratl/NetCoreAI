using Microsoft.EntityFrameworkCore;
using NetCoreAI.Project01_ApiDemo.Entities;
using System.Data.Common;

namespace NetCoreAI.Project01_ApiDemo.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer("Server=.;initial catalog=ApiAIDb;integrated security=True;trustservercertificate=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

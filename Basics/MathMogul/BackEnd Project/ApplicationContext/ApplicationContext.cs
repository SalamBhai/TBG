
using BackEnd_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BackEnd_Project.Context
{
    public class ApplicationContext : DbContext
    {
         public ApplicationContext(DbContextOptions<ApplicationContext> options)
         : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
       public DbSet<Item> Items {get;set;}
    }
}
using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ExtraMap());
            modelBuilder.Configurations.Add(new IssueMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new SaloonMap());
        }
        public DbSet<Order>Orders { get; set; }
        public DbSet<Customer>Customers { get; set; }
        public DbSet<Extra>Extras { get; set; }
        public DbSet<Issue>Issues { get; set; }
        public DbSet<Saloon>Saloons { get; set; }
    }
}

using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iLabsServiceBroker.Models;

namespace iLabsServiceBroker.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbContextConnectionString")
        {
            Database.SetInitializer<MyDbContext>(new MyDbInitializer());
        }
        public DbSet<ExperimentViewModel> ExperimentModel { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    public class MyDbInitializer : CreateDatabaseIfNotExists<MyDbContext>
    {
        protected override void Seed(MyDbContext context)
        {
            context.ExperimentModel.Add(new ExperimentViewModel { ExperimentName = "Half wave rectification", ExperimentGroup = "ELE2010", DateCreated = DateTime.Now, CourseCategory = "Electronics", ExperimentAttempts = 10 });
            base.Seed(context);
        }
    }
}
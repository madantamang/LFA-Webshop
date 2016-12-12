namespace Web_codefirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_codefirst.Models.ShoppingDbContextModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
           
        }

        protected override void Seed(Web_codefirst.Models.ShoppingDbContextModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //var students = new List<Student>
            //{
            //    new Student { FirstMidName = "Carson",   LastName = "Alexander",
            //        EnrollmentDate = DateTime.Parse("2010-09-01") },
            //    new Student { FirstMidName = "Meredith", LastName = "Alonso",
            //        EnrollmentDate = DateTime.Parse("2012-09-01") },
            //    new Student { FirstMidName = "Arturo",   LastName = "Anand",
            //        EnrollmentDate = DateTime.Parse("2013-09-01") },
            //    new Student { FirstMidName = "Gytis",    LastName = "Barzdukas",
            //        EnrollmentDate = DateTime.Parse("2012-09-01") },
            //    new Student { FirstMidName = "Yan",      LastName = "Li",
            //        EnrollmentDate = DateTime.Parse("2012-09-01") },
            //    new Student { FirstMidName = "Peggy",    LastName = "Justice",
            //        EnrollmentDate = DateTime.Parse("2011-09-01") },
            //    new Student { FirstMidName = "Laura",    LastName = "Norman",
            //        EnrollmentDate = DateTime.Parse("2013-09-01") },
            //    new Student { FirstMidName = "Nino",     LastName = "Olivetto",
            //        EnrollmentDate = DateTime.Parse("2005-09-01") }
            //};


            //students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            //context.SaveChanges();

        }
    }
}

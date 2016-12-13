using System.Data.Entity.ModelConfiguration.Conventions;

namespace Web_codefirst.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShoppingDbContextModel : DbContext
    {
        // Your context has been configured to use a 'ShoppingModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Web_codefirst.Models.ShoppingModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ShoppingDbContextModel' 
        // connection string in the application configuration file.
        public ShoppingDbContextModel()
            : base("name=ShoppingModelConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
<<<<<<< HEAD
        public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }
=======
        public virtual DbSet<Cart>  Carts { get; set; }
>>>>>>> 7511cd15ede452d37c11ccbcfb7af88a9a5d9322

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // modelBuilder.Entity<Category>().ToTable("Tbl_Category");
        }
    }

}
namespace Web_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class variantadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Variant", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Variant");
        }
    }
}

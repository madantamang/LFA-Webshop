namespace Web_codefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sizeadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Size", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Size");
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixmovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: true));
            DropColumn("dbo.Customers", "IsSubscribedToNewLetter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewLetter", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
        }
    }
}

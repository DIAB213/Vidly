namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValueBIRTHDATE : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1-3-1999' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}

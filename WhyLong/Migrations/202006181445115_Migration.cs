namespace WhyLong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Migration", c => c.Int(nullable: false));
            AddColumn("dbo.People", "FirstName", c => c.String());
            AddColumn("dbo.People", "SecondName", c => c.String());
            AddColumn("dbo.People", "LastName", c => c.String());
            AddColumn("dbo.People", "Login", c => c.String(maxLength: 30));
            AddColumn("dbo.People", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Password");
            DropColumn("dbo.People", "Login");
            DropColumn("dbo.People", "LastName");
            DropColumn("dbo.People", "SecondName");
            DropColumn("dbo.People", "FirstName");
            DropColumn("dbo.Employees", "Migration");
        }
    }
}

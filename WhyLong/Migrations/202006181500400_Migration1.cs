namespace WhyLong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Position", c => c.String());
            DropColumn("dbo.People", "SFP");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "SFP", c => c.String());
            DropColumn("dbo.People", "Position");
        }
    }
}

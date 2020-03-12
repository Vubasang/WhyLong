namespace WhyLong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhyLong1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        Biography = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        Role = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Exhibitions",
                c => new
                    {
                        ExhibitionId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        Halls = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExhibitionId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        SFP = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        PictureId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Date = c.DateTime(nullable: false),
                        Cost = c.Double(nullable: false),
                        Author_ArtistId = c.Int(),
                        Genre_Id = c.Int(),
                    })
                .PrimaryKey(t => t.PictureId)
                .ForeignKey("dbo.Artists", t => t.Author_ArtistId)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Author_ArtistId)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pictures", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Pictures", "Author_ArtistId", "dbo.Artists");
            DropIndex("dbo.Pictures", new[] { "Genre_Id" });
            DropIndex("dbo.Pictures", new[] { "Author_ArtistId" });
            DropTable("dbo.Pictures");
            DropTable("dbo.People");
            DropTable("dbo.Genres");
            DropTable("dbo.Exhibitions");
            DropTable("dbo.Employees");
            DropTable("dbo.Artists");
        }
    }
}

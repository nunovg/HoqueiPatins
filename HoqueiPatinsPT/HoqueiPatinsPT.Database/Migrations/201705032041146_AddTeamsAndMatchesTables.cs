namespace HoqueiPatinsPT.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamsAndMatchesTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        PKID = c.Guid(nullable: false),
                        HomeTeamId = c.Guid(nullable: false),
                        HomeTeamScore = c.Int(nullable: false),
                        AwayTeamId = c.Guid(nullable: false),
                        AwayTeamScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PKID)
                .ForeignKey("dbo.Teams", t => t.AwayTeamId)
                .ForeignKey("dbo.Teams", t => t.HomeTeamId)
                .Index(t => t.HomeTeamId)
                .Index(t => t.AwayTeamId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        PKID = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PKID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matches", "HomeTeamId", "dbo.Teams");
            DropForeignKey("dbo.Matches", "AwayTeamId", "dbo.Teams");
            DropIndex("dbo.Matches", new[] { "AwayTeamId" });
            DropIndex("dbo.Matches", new[] { "HomeTeamId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Matches");
        }
    }
}

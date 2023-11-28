namespace IntroEFCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAddedAndTableModified : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Username);
            
            AlterColumn("dbo.Products", "Qty", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Qty", c => c.Int(nullable: false));
            DropTable("dbo.Users");
        }
    }
}

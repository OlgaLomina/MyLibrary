namespace LibraryAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Age");
        }
    }
}

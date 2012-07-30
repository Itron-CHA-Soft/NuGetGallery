namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisherToPackage : DbMigration
    {
        public override void Up()
        {
            AddColumn("Packages", "PublisherKey", c => c.Int());
            AddForeignKey("Packages", "PublisherKey", "Users", "Key");
            CreateIndex("Packages", "PublisherKey");
        }
        
        public override void Down()
        {
            DropIndex("Packages", new[] { "PublisherKey" });
            DropForeignKey("Packages", "PublisherKey", "Users");
            DropColumn("Packages", "PublisherKey");
        }
    }
}

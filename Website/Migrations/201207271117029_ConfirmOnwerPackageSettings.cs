namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ConfirmOnwerPackageSettings : DbMigration
    {
        public override void Up()
        {
          AddColumn("GallerySettings", "ConfirmOwnerPackage", c => c.Boolean(nullable: false, defaultValue: true));
        }
        
        public override void Down()
        {
            DropColumn("GallerySettings", "ConfirmOwnerPackage");
        }
    }
}

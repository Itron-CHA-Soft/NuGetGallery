// <auto-generated />
namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class CreateAggregateStatisticsSP : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201208302051344_CreateAggregateStatisticsSP"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
          get { return "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"; }
        }
    }
}

using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20260107_193000)]
    public class DefaultDB_20260107_1930_MovieTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Movie")
             .WithColumn("MovieId").AsInt32()
                 .Identity().PrimaryKey().NotNullable()
             .WithColumn("Title").AsString(200).NotNullable()
             .WithColumn("Description").AsString(1000).Nullable()
             .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
             .WithColumn("Year").AsInt32().Nullable()
             .WithColumn("ReleaseDate").AsDateTime().Nullable()
             .WithColumn("Runtime").AsInt32().Nullable();
        }
    }
}
using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20260109_194800)]
    public class DefaultDB_20260109_1948_PersonMovieImages : AutoReversingMigration
    {
        public override void Up()
        {
            Alter.Table("Person")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }
    }
}
using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20260108_130500)]
    public class DefaultDB_20260108_1305_GenreTable : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Genre")
            .WithColumn("GenreId").AsInt32().NotNullable()
                .PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");

            Insert.IntoTable("Genre")
                .Row(new { Name = "Action" })
                .Row(new { Name = "Drama" })
                .Row(new { Name = "Comedy" })
                .Row(new { Name = "Sci-fi" })
                .Row(new { Name = "Fantasy" })
                .Row(new { Name = "Documentary" });
        }
    }
}
using FluentMigrator;
using System;

namespace Serene1.Migrations.DefaultDB
{
    [Migration(20260108_170500)]
    public class DefaultDB_20260108_1705_MovieGenres : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("MovieGenres")
            .WithColumn("MovieGenreId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("MovieId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieGenres_MovieId", "Movie", "MovieId")
            .WithColumn("GenreId").AsInt32().NotNullable()
                .ForeignKey("FK_MovieGenres_GenreId", "Genre", "GenreId");

            Execute.Sql(@"
        INSERT INTO MovieGenres (MovieId, GenreId) 
        SELECT m.MovieId, m.GenreId 
        FROM Movie m 
        WHERE m.GenreId IS NOT NULL");

            // 3. ONLY THEN delete the old column and its key
            // Make sure the name matches your actual FK name in the DB
            Delete.ForeignKey("FK_Movie_GenreId").OnTable("Movie");
            Delete.Column("GenreId").FromTable("Movie");
        }
    }
}
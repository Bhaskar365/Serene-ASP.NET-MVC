
namespace Serene1.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serene1.Modules.Default.Movie;
    using Serene1.Default.Entities;

    [FormScript("Default.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public String Title { get; set; }

        [TextAreaEditor(Rows=3)]
        public String Description { get; set; }

        [DisplayName("Cast"), MovieCastEditor, IgnoreName]
        //[DisplayName("Cast"), IgnoreName]

        public List<MovieCastRow> CastList { get; set; }

        [TextAreaEditor(Rows=8)]
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }
        public MovieKind Kind { get; set; }
        //public int GenreId { get; set; }
        public List<int> GenreList { get; set; }

        public string PrimaryImage { get; set; }
        public string GalleryImages { get; set; }
    }
}
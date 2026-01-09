
namespace Serene1.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serene1.Modules.Default.Movie;

    [ColumnsScript("Default.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        [DisplayName("Runtime in Minutes"),Width(150),AlignRight]
        public Int32 Runtime { get; set; }
        public MovieKind Kind { get; set; }

        //[Width(100), QuickFilter]
        //public string GenreName { get; set; }
        //[Width(200)]
        [Width(200), GenreListFormatter]
        public List<int> GenreList { get; set; }


    }
}

namespace Serene1.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.MovieCast")]
    [BasedOnRow(typeof(Entities.MovieCastRow), CheckNames = true)]
    public class MovieCastColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int32 MovieCastId { get; set; }
        //public String MovieTitle { get; set; }
        //public String PersonFirstName { get; set; }
        //[EditLink]
        //public String Character { get; set; }

        public string PersonFullName { get; set; }
        public string Character { get; set; }
    }
}
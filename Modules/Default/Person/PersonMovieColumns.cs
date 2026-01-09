
namespace Serene1.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serene1.Default.Entities;

    [ColumnsScript("Default.Person")]
    [BasedOnRow(typeof(MovieCastRow))]
    public class PersonMovieColumns
    {
        [Width(220)]
        public string MovieTitle { get; set; }
        [Width(200)]
        public string Character { get; set; }
    }
}
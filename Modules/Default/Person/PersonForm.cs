
namespace Serene1.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;
    using Serene1.Default.Entities;

    [FormScript("Default.Person")]
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonForm
    {

        [Tab("Person")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }
        //public Int32 Gender { get; set; }

        public Gender Gender { get; set; }

        public Int32 Height { get; set; }


        public string PrimaryImage { get; set; }
        public string GalleryImages { get; set; }

        [Tab("Movies"), IgnoreName, LabelWidth("0")]
        // Use the "MovieCastEditor" or a generic "Editor" attribute with a string
        [EditorType("Default.PersonMovieGrid")]
        public string MoviesGrid { get; set; }

    }
}
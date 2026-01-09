
namespace Serene1.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Genre")]
    [BasedOnRow(typeof(Entities.GenreRow), CheckNames = true)]
    public class GenreForm
    {
        public String Name { get; set; }
    }
}
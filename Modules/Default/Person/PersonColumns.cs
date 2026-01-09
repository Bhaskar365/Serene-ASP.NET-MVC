
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
    [BasedOnRow(typeof(Entities.PersonRow), CheckNames = true)]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PersonId { get; set; }
        [EditLink]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public String BirthPlace { get; set; }

        //public Int32 Gender { get; set; }

        public Gender Gender { get; set; }

        public Int32 Height { get; set; }
    }
}
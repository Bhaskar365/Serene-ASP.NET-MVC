
namespace Serene1.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Person]")]
    [DisplayName("Person"), InstanceName("Person")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class PersonRow : Row, IIdRow, INameRow
    {
        [DisplayName("Person Id"), Identity]
        public Int32? PersonId
        {
            get { return Fields.PersonId[this]; }
            set { Fields.PersonId[this] = value; }
        }

        [DisplayName("First Name"), Size(50), NotNull]
        public String FirstName
        {
            get { return Fields.FirstName[this]; }
            set { Fields.FirstName[this] = value; }
        }

        [DisplayName("Last Name"), Size(50), NotNull]
        public String LastName
        {
            get { return Fields.LastName[this]; }
            set { Fields.LastName[this] = value; }
        }

        [DisplayName("Full Name"), QuickSearch, NameProperty]
        [Expression("t0.FirstName + ' ' + t0.LastName")]
        [LookupInclude]
        public string FullName { get => Fields.FullName[this]; set => Fields.FullName[this] = value; }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate
        {
            get { return Fields.BirthDate[this]; }
            set { Fields.BirthDate[this] = value; }
        }

        [DisplayName("Birth Place"), Size(100)]
        public String BirthPlace
        {
            get { return Fields.BirthPlace[this]; }
            set { Fields.BirthPlace[this] = value; }
        }

        //[DisplayName("Gender")]
        //public Int32? Gender
        //{
        //    get { return Fields.Gender[this]; }
        //    set { Fields.Gender[this] = value; }
        //}

        [DisplayName("Gender")]
        public Gender? Gender
        {
            get { return Fields.Gender[this]; }
            set { Fields.Gender[this] = value; }
        }

        [DisplayName("Height")]
        public Int32? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("Primary Image"), Size(100)]
        [ImageUploadEditor(FilenameFormat = "Person/PrimaryImage/~")]
        public string PrimaryImage { get => Fields.PrimaryImage[this]; set => Fields.PrimaryImage[this] = value; }

        [DisplayName("Gallery Images")]
        [MultipleImageUploadEditor(FilenameFormat = "Person/GalleryImages/~")]
        public string GalleryImages { get => Fields.GalleryImages[this]; set => Fields.GalleryImages[this] = value; }


        IIdField IIdRow.IdField
        {
            get { return Fields.PersonId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FirstName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PersonRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field PersonId;
            public StringField FirstName;
            public StringField LastName;
            public DateTimeField BirthDate;
            public StringField BirthPlace;
            //public Int32Field Gender;
            public Int32Field Height;
            public EnumField<Gender> Gender;
            public StringField FullName;

            public StringField PrimaryImage;
            public StringField GalleryImages;

        }
    }
}

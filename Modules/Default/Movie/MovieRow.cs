
namespace Serene1.Default.Entities
{
    using Serene1.Modules.Default.Movie;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Movie]")]
    [DisplayName("Movies"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity]
        public Int32? MovieId
        {
            get { return Fields.MovieId[this]; }
            set { Fields.MovieId[this] = value; }
        }

        [DisplayName("Title"), Size(200), NotNull, QuickSearch(SearchType.StartsWith), NameProperty]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Description"), Size(1000),QuickSearch]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Storyline"), QuickSearch]
        public String Storyline
        {
            get { return Fields.Storyline[this]; }
            set { Fields.Storyline[this] = value; }
        }

        [DisplayName("Year"), QuickSearch(SearchType.Equals, numericOnly:1)]
        public Int32? Year
        {
            get { return Fields.Year[this]; }
            set { Fields.Year[this] = value; }
        }

        [DisplayName("Release Date")]
        public DateTime? ReleaseDate
        {
            get { return Fields.ReleaseDate[this]; }
            set { Fields.ReleaseDate[this] = value; }
        }

        [DisplayName("Runtime (mins)")]
        public Int32? Runtime
        {
            get { return Fields.Runtime[this]; }
            set { Fields.Runtime[this] = value; }
        }

        [DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
        public MovieKind? Kind { get => Fields.Kind[this]; set => Fields.Kind[this] = value; }

        const string jGenre = nameof(jGenre);

        [DisplayName("Genres"), LookupEditor(typeof(GenreRow), Multiple = true), NotMapped]
        [LinkingSetRelation(typeof(MovieGenresRow), nameof(MovieGenresRow.MovieId), nameof(MovieGenresRow.GenreId))]
        public List<int> GenreList { get => Fields.GenreList[this]; set => Fields.GenreList[this] = value; }

        [DisplayName("Cast List"), MasterDetailRelation(foreignKey: "MovieId"), NotMapped]
        public List<MovieCastRow> CastList
        {
            get { return Fields.CastList[this]; }
            set { Fields.CastList[this] = value; }
        }

        //[DisplayName("Genre"), ForeignKey(typeof(GenreRow)), LeftJoin(jGenre)]
        //[LookupEditor(typeof(GenreRow), InplaceAdd = true, DialogType = "Default.Genre")]
        //public int? GenreId { get => Fields.GenreId[this]; set => Fields.GenreId[this] = value; }

        //[DisplayName("Genre"), Origin(jGenre, nameof(GenreRow.Name))]
        //public string GenreName { get => Fields.GenreName[this]; set => Fields.GenreName[this] = value; }

        [DisplayName("Primary Image"), Size(100)]
        [ImageUploadEditor(FilenameFormat = "Movie/PrimaryImage/~")]
        public string PrimaryImage { get => Fields.PrimaryImage[this]; set => Fields.PrimaryImage[this] = value; }

        [DisplayName("Gallery Images")]
        [MultipleImageUploadEditor(FilenameFormat = "Movie/GalleryImages/~")]
        public string GalleryImages { get => Fields.GalleryImages[this]; set => Fields.GalleryImages[this] = value; }



        IIdField IIdRow.IdField
        {
            get { return Fields.MovieId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MovieRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public EnumField<MovieKind> Kind;
            //public Int32Field GenreId;
            //public StringField GenreName;
            public ListField<int> GenreList;
            public RowListField<MovieCastRow> CastList;

            public StringField PrimaryImage;
            public StringField GalleryImages;

        }
    }
}

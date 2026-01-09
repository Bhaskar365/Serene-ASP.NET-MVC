
namespace Serene1.Default.Repositories
{
    using Org.BouncyCastle.Asn1.Ocsp;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.MovieRow;

    public class MovieRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        //public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        //{
        //    return new MyListHandler().Process(connection, request);
        //}

        public ListResponse<MyRow> List(IDbConnection connection, MovieListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

       // private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        //private class MyListHandler : ListRequestHandler<MyRow> { }

        private class MyListHandler : ListRequestHandler<MyRow, MovieListRequest>
        {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);

                if (!Request.Genres.IsEmptyOrNull())
                {
                    // This 'fld' refers to the static field at the top of your Repository
                    var mg = Entities.MovieGenresRow.Fields.As("mg");

                    query.Where(Criteria.Exists(
                        query.SubQuery()
                            .From(mg)
                            .Select("1")
                            .Where(
                                mg.MovieId == fld.MovieId &&
                                mg.GenreId.In(Request.Genres))
                            .ToString()));
                }
            }
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            protected override void AfterSave()
            {
                base.AfterSave();

                // Use the connection and Row from the handler itself
                var behavior = new MasterDetailRelationBehavior();

                // In legacy, behaviors often need to be "activated" or they 
                // expect the Row to be passed in a specific way.
                // However, usually, simply having the attribute on the Row is enough.
            }
        }
    }
}
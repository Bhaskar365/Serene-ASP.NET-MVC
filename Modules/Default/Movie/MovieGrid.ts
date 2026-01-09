

namespace Serene1.Default {

    @Serenity.Decorators.registerClass('MovieTutorial.MovieDB.MovieGrid')
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'Default.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const fldDesc = MovieRow.Fields.Description;
            const fldStry = MovieRow.Fields.Storyline;
            const fldYear = MovieRow.Fields.Year;
            const txt = s => Q.text(`Db.${MovieRow.localTextPrefix}.${s}`);
            return [
                { name: "", title: "All" },
                { name: fldDesc, title: txt(fldDesc) },
                { name: fldStry, title: txt(fldStry) },
                { name: fldYear, title: txt(fldYear) }
            ];
        }

        protected getQuickFilters() {
            // Get filters from base class (like the ones from MovieColumns.cs)
            let filters = super.getQuickFilters();

            // Add our custom Genre filter
            filters.push({
                field: 'Genres',
                type: Serenity.LookupEditor,
                title: 'Genres',
                options: {
                    lookupKey: 'Default.Genre', // Ensure this matches your GenreRow [LookupScript]
                    multiple: true
                },
                handler: h => {
                    // This links the UI selection to the C# Request.Genres property
                    (h.request as MovieListRequest).Genres = h.value;
                    h.handled = true;
                }
            });

            return filters;
        }
    }
}
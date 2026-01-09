
//namespace Serene1.Default {

//    @Serenity.Decorators.registerClass()
//    export class MovieCastEditor extends Serenity.Extensions.GridEditorBase<MovieCastRow> {
//        protected getColumnsKey() { return 'Default.MovieCast'; }
//        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

//        constructor(container: JQuery) {
//            super(container);
//        }

//        protected getAddButtonCaption() {
//            return "Add Cast Member";
//        }
//    }
//}

namespace Serene1.Default {
    @Serenity.Decorators.registerEditor("MovieTutorial.MovieDB.MovieCastEditor")
    export class MovieCastEditor extends Serene1.Common.GridEditorBase<MovieCastRow> {

        // In legacy, we use the string key directly
        protected getColumnsKey() { return 'Default.MovieCast'; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getDialogType() { return MovieCastEditDialog; }

        // Change constructor from (props) to (container)
        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add Cast Member";
        }

        protected validateEntity(row: MovieCastRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            // In legacy, lookups are already loaded in the client-side cache
            var person = Q.getLookup<PersonRow>('Default.Person').itemById[row.PersonId];

            if (person) {
                row.PersonFullName = person.FullName || (person.FirstName + ' ' + person.LastName);
            }

            return true;
        }
    }
}



//@Decorators.registerEditor("MovieTutorial.MovieDB.MovieCastEditor")
//export class MovieCastEditor<P = {}> extends GridEditorBase<MovieCastRow, P> {
//    protected getColumnsKey() { return MovieCastColumns.columnsKey }
//    protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

//    constructor(props: WidgetProps<P>) {
//        super(props);
//    }
//}
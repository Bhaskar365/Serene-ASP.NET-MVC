
namespace Serene1.Default {

    @Serenity.Decorators.registerClass('Serene1.Default.PersonMovieGrid')
    export class PersonMovieGrid extends Serenity.EntityGrid<MovieCastRow, any> {
        protected getColumnsKey() { return 'Default.Person'; }
        //protected getColumnsKey() { return PersonMovieColumns.columnsKey; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons() {
            // Usually, in a person's movie list, we don't want the "Add" button 
            // because we add them via the Movie dialog.
            let buttons = super.getButtons();
            buttons = buttons.filter(x => x.cssClass != 'add-button');
            return buttons;
        }

        protected usePager() {
            return false;
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return this.personId != null;
        }

        private _personId: number;

        get personId() {
            return this._personId;
        }

        set personId(value: number) {
            if (this._personId != value) {
                this._personId = value;
                this.setEquality(MovieCastRow.Fields.PersonId, value);
                this.refresh();
            }
        }


    }
}
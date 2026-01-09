
namespace Serene1.Default {

    @Serenity.Decorators.registerEditor("MovieTutorial.MovieDB.MovieCastEditDialog")
    export class MovieCastEditDialog extends Serene1.Common.GridEditorDialog<MovieCastRow> {
        protected getFormKey() { return MovieCastForm.formKey; }
        protected getNameProperty() { return MovieCastRow.nameProperty; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }

        protected form: MovieCastForm = new MovieCastForm(this.idPrefix);
    }
}
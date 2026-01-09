namespace Serene1.Default {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        CastList: MovieCastEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        Runtime: Serenity.IntegerEditor;
        Kind: Serenity.EnumEditor;
        GenreList: Serenity.LookupEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = MovieCastEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DateEditor;
                var w5 = s.EnumEditor;
                var w6 = s.LookupEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'CastList', w2,
                    'Storyline', w1,
                    'Year', w3,
                    'ReleaseDate', w4,
                    'Runtime', w3,
                    'Kind', w5,
                    'GenreList', w6
                ]);
            }
        }
    }
}


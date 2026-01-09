namespace Serene1.Default {
    export interface MovieRow {
        MovieId?: number;
        Title?: string;
        Description?: string;
        Storyline?: string;
        Year?: number;
        ReleaseDate?: string;
        Runtime?: number;
        Kind?: Modules.Default.Movie.MovieKind;
        GenreList?: number[];
        CastList?: MovieCastRow[];
    }

    export namespace MovieRow {
        export const idProperty = 'MovieId';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'Default.Movie';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            MovieId = "MovieId",
            Title = "Title",
            Description = "Description",
            Storyline = "Storyline",
            Year = "Year",
            ReleaseDate = "ReleaseDate",
            Runtime = "Runtime",
            Kind = "Kind",
            GenreList = "GenreList",
            CastList = "CastList"
        }
    }
}


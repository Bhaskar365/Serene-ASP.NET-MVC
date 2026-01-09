namespace Serene1.Modules.Default.Movie {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'Serene1.Modules.Default.Movie.MovieKind', 'Default.MovieKind');
}


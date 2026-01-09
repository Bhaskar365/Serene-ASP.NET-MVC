using Serenity.Navigation;
using MyPages = Serene1.Default.Pages;

//[assembly: NavigationLink(int.MaxValue, "Default/Movie", typeof(MyPages.MovieController), icon: null)]

[assembly: NavigationMenu(6000, "Movie Database", icon:"fa-film")]

[assembly: NavigationLink(int.MaxValue, "Movie Database/Movies", 
    typeof(MyPages.MovieController), icon: "fa-video-camera")]

//[assembly: NavigationLink(int.MaxValue, "Default/Genre", typeof(MyPages.GenreController), icon: null)]

[assembly: NavigationLink(int.MaxValue, "Movie Database/Genres", 
    typeof(MyPages.GenreController), icon: "fa-thumb-tack")]
//[assembly: NavigationLink(int.MaxValue, "Default/Person", typeof(MyPages.PersonController), icon: null)]

[assembly: NavigationLink(6300, "Movie Database/Person", 
    typeof(MyPages.PersonController), icon: "fa-users")]
//[assembly: NavigationLink(int.MaxValue, "Default/Movie Cast", typeof(MyPages.MovieCastController), icon: null)]

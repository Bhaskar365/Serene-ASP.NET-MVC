
namespace Serene1.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/MovieCast"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.MovieCastRow))]
    public class MovieCastController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/MovieCast/MovieCastIndex.cshtml");
        }
    }
}
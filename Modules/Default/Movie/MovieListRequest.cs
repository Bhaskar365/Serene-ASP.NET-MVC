using Serenity.Services;
using System.Collections.Generic;

namespace Serene1.Default
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}

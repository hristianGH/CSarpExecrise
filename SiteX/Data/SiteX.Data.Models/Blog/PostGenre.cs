using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteX.Data.Models.Blog
{
    public class PostGenre: BaseDeletableModel<int>
    {
        public Post Post { get; set; }
        public int PostId { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}

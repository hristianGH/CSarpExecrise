using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Blog
{
    public class DeletedPost
    {
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}

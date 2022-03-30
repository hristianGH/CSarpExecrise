using SiteX.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteX.Data.Models.Shop
{
    public class SoldProduct:BaseModel<int>
    {
     
        public Product Product { get; set; }
    }
}

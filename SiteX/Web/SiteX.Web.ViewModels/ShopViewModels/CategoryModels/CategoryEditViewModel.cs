using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels.CategoryModels
{
    public class CategoryEditViewModel
    {

        public int OldId { get; set; }

        public string NewName { get; set; }
    }
}

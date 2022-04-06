using SiteX.Data.Models.Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SiteX.Web.ViewModels.ShopViewModels
{
    public class SelectProductViewModel
    {
        [Required]
        public Guid ProductId { get; set; }

        [MaxLength(4)]
        public virtual ICollection<string> Pictures { get; set; } = new List<string>();


        [MaxLength(4)]
        public virtual ICollection<int> Locations { get; set; } = new List<int>();


        [  MaxLength(3)]
        public virtual ICollection<int> Categories { get; set; } = new List<int>();

    }
}

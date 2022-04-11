namespace SiteX.Web.ViewModels.ShopViewModels.ProductModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class SelectProductViewModel
    {
        [Required]
        public Guid ProductId { get; set; }
    }
}

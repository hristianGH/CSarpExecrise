namespace ProductShop.Models
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlType("Product")]
    public class Product
    {
        public Product()
        {
            this.CategoryProducts = new List<CategoryProduct>();
        }
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("sellerId")]
        public int SellerId { get; set; }

        [XmlIgnore]
        public User Seller { get; set; }

        [XmlElement("buyerId")]
        public int? BuyerId { get; set; }

        [XmlIgnore]
        public User Buyer { get; set; }

        [XmlIgnore]
        public ICollection<CategoryProduct> CategoryProducts { get; set; }
    }
}
//< name > SNORING HP </ name >
   
//           < price > 53.59 </ price >
   
//           < sellerId > 24 </ sellerId >
   
//           < buyerId > 30 </ buyerId >
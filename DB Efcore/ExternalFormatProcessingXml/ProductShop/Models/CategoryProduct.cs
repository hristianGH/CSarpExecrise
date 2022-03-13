using System.Xml.Serialization;

namespace ProductShop.Models
{
    
    public class CategoryProduct
    {
        [XmlElement("CategoryId")]
        public int CategoryId { get; set; }

        [XmlIgnore]
        public Category Category { get; set; }

        [XmlElement("ProductId")]
        public int ProductId { get; set; }

        [XmlIgnore]
        public Product Product { get; set; }
    }
}

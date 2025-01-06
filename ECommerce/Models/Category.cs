using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }

        //Navigational Propery
        public ICollection<Product> Products { get; set; }
    }
}

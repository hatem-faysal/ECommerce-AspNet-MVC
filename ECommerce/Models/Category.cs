﻿using System.ComponentModel.DataAnnotations;
using ECommerce.Data.Base;

namespace ECommerce.Models
{
    public class Category: IBaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        //[StringLength(10,ErrorMessage = "This {0} Is Spesific Between {2},{1}",MinimumLength=5)]
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public string Description { get; set; }



        //Navigational Propery
        public ICollection<Product> Products { get; set; }
    }
}

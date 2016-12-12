using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_codefirst.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [MaxLength(45, ErrorMessage = "The maximum length must be upto 45 characters only")]
        public string Name { get; set; }

        [RegularExpression(@"^\d+.\d{0,2}$", ErrorMessage = "Has to be decimal with two decimal points")]
        [Range(0, 5, ErrorMessage = "The maximum possible value should be upto 5 digits")]
        public Decimal Price { get; set; }

        public string Description { get; set; }

        [Display(Name = "Updated At")]
        [Column(TypeName = "datetime2")]
        public DateTime LastUpdated { get; set; }

        [DisplayName("Image")]
        [StringLength(1024)]
        public string Image { get; set; }

        public string Variant { get; set; }

        public string Size { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}
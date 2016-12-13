using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_codefirst.Models
{
    public class OrderedProductModel
    {
        [Key]
        public int ID { get; set; }
        public int CustomerOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_codefirst.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime DateCreated { get; set; }
        public int Count { get; set; }
    }
}
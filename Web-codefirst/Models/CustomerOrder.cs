using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_codefirst.Models
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Amount { get; set; }
        public string CustomerUserName { get; set; }
    }
}
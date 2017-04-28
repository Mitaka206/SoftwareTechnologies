using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Data
{
    public class Cart
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public DateTime BuyOn { get; set; }
        
        public int AdId { get; set; }
    }
}
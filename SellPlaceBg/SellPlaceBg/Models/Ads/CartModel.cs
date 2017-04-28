using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models
{
    public class CartModel
    {
        public int AdId { get; set; }

        public string Title { get; set; }

        public string ImgUrl { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
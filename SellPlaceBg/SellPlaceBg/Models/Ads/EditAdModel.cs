using SellPlaceBg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models.Ads
{
    public class EditAdModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Category Category { get; set; }

        public string Discription { get; set; }

        public decimal Price { get; set; }

        public string ImgUrl { get; set; }

        public string SellerId { get; set; }

        public virtual ApplicationUser Seller { get; set; }
    }
}
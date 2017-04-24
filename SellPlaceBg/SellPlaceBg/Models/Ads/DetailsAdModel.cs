using SellPlaceBg.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models.Ads
{
    public class DetailsAdModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public Category Category { get; set; }
        
        public string Discription { get; set; }
        
        public decimal Price { get; set; }
        
        public Town Town { get; set; }
        
        public string ImgUrl { get; set; }

        public bool IsSold { get; set; }

        public string SellerId { get; set; }

        public virtual ApplicationUser Seller { get; set; }

        public DateTime Date { get; set; }

        public string ContactInformation { get; set; }

        public bool IsSeller(string sellerId)
        {
            return this.SellerId == sellerId;
        }
    }
}
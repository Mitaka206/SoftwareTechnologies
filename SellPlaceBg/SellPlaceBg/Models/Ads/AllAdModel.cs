using SellPlaceBg.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models.Ads
{
    public class AllAdModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public Category Category { get; set; }
        
        public string Discription { get; set; }
        
        public decimal Price { get; set; }
        
        public string ImgUrl { get; set; }

        public bool IsSold { get; set; }

    }
}
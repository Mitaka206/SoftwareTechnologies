using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Data
{
    public class Ad
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(1000)]
        public string Discription { get; set; }

        //BGN
        [Range(1, 10000000)]
        public decimal Price { get; set; }

        [Required]
        public Town Town { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        public bool IsSold { get; set; }

        [Required]
        public string SellerId { get; set; }

        public virtual ApplicationUser Seller { get; set; }

        public DateTime Date { get; set; }

        public bool IsSeller(string sellerId)
        {
            return this.SellerId == sellerId;
        }

    }
}
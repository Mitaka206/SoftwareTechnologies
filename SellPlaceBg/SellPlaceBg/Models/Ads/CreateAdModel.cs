using SellPlaceBg.Data;
using SellPlaceBg.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models.Ads
{
    public class CreateAdModel
    {

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Category")]
        [ScaffoldColumn(false)]
        public Category Category { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(1000)]
        [Display(Name = "Discription")]
        public string Discription { get; set; }

        //BGN
        [Range(1, 1000000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Town")]
        [ScaffoldColumn(false)]
        public Town Town { get; set; }

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        [ImageValidateAtribut]
        public string ImgUrl { get; set; }

        public DateTime Date { get; set; }

    }
}
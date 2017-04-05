using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myMag.Models
{
    public class Ad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TitleAd { get; set; }

        [Required]
        public string CategotyAd { get; set; }

        [Required]
        public string DescriptionAd { get; set; }

        [Required]
        public string PhoneContact { get; set; }

        [ForeignKey("Seller")]
        public string AuthorID { get; set; }


        public ApplicationUser Seller { get; set; }
        
    }
}
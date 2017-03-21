using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlogFin.Models
{
    public class Article
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Range(10, 1000)]
        [Display(Name = "Content")]
        public string Content { get; set; }

        [ForeignKey("Author")]
        public string AuthorID { get; set; }

        public virtual ApplicationUser Author { get; set; }
    }
}
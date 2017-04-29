using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace myBlog.Models
{
    public class Article
    {
        public Article()
        {
            this.Date = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        [MinLength(3)]
        [DataType(DataType.MultilineText)]
        public String Content { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }
        

        public ICollection<Comment> Comments { get; set; }
    }
}
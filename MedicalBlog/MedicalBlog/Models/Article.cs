using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedicalBlog.Models
{
    public class Article
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Theme { get; set; }

        [Required]
        [StringLength(2500)]
        public string Content { get; set; }

        public DateTime Date { get; set; }


        public string AuthorId { get; set; }

        
        public virtual ApplicationUser Author { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public bool IsAuthor(string authorId)
        {
            return this.AuthorId == authorId;
        }
    }
}
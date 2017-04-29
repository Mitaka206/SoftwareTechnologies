using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicalBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }

        //public ApplicationUser Author { get; set; }

        public string Text { get; set; }

        public Article Post { get; set; }
    }
}
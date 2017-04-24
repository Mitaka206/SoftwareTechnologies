using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Data
{
    public class Archive
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Category Category { get; set; } // for statistic

        public Town Town { get; set; } // for statistic

        public decimal Price { get; set; }

        public int AdId { get; set; }

        public virtual Ad Ad { get; set; }
    }
}
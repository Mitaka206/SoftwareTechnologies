using SellPlaceBg.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SellPlaceBg.Models.Ads
{
    public class CategoryAdModel
    {
        public int Id { get; set; }

        public virtual Ad Ad { get; set; }
    }
}
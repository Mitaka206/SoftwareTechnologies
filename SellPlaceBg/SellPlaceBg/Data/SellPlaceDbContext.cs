using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SellPlaceBg.Data
{
    public class SellPlaceDbContext : IdentityDbContext<ApplicationUser>
    {
        public SellPlaceDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Ad> Ads { get; set; }

        public virtual IDbSet<Cart> Carts { get; set; }
        
        public static SellPlaceDbContext Create()
        {
            return new SellPlaceDbContext();
        }
    }
}
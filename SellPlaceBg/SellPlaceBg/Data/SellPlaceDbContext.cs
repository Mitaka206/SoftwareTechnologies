using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SellPlaceBg.Models.Ads;

namespace SellPlaceBg.Data
{
    public class SellPlaceDbContext : IdentityDbContext<ApplicationUser>
    {
        public SellPlaceDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Ad> Ads { get; set; }

        public virtual IDbSet<Archive> Archives { get; set; }
        

        public static SellPlaceDbContext Create()
        {
            return new SellPlaceDbContext();
        }
    }
}
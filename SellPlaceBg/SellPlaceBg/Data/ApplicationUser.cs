using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using SellPlaceBg.Models.Ads;

namespace SellPlaceBg.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Ads = new HashSet<Ad>();
            this.Archives = new HashSet<Archive>();
        }
        
        public virtual ICollection<Ad> Ads { get; set; }

        public virtual ICollection<Archive> Archives { get; set; }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }

}
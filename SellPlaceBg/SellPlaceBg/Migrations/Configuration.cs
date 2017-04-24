namespace SellPlaceBg.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using SellPlaceBg.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SellPlaceBg.Data.SellPlaceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(SellPlaceDbContext context)
        {
            if (!context.Users.Any())
            {
                // If the database is empty, populate sample data in it

                CreateUser(context, "admin@gmail.com", "123456");
                CreateUser(context, "mitaka206@gmail.com", "123");
                CreateUser(context, "stefcheto_83@gmail.com", "123");
                CreateUser(context, "stamat_29@gmail.com", "123");
                CreateUser(context, "muncho2000@gmail.com", "123");

                CreateRole(context, "Admin");

                AddUserToRole(context, "admin@gmail.com", "Admin");
                
                if (context.Ads.Count() < 1)
                {

                    var user = context.Users.FirstOrDefault();
                    
                    context.Ads.Add(new Ad
                    {
                        Title = "Vilage house",
                        Category = Category.RealEstate,
                        Discription = "Two levels and 5dka plane Two levels and 5dka plane Two levels and 5dka plane Two levels and 5dka plane ",
                        Price = 15800,
                        Town = Town.Burgas,
                        ImgUrl = "https://static.pexels.com/photos/186077/pexels-photo-186077.jpeg",
                        Date = new DateTime(2016, 05, 27, 17, 53, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Baby schuhes",
                        Category = Category.BabyAndChild,
                        Discription = "Color: Black. No: 2 EN",
                        Price = 60,
                        Town = Town.Haskovo,
                        ImgUrl = "https://archzine.net/wp-content/uploads/2015/03/coole-modelle-tolles-design-h%C3%A4keln-babyschuhe-fantastische-ideen-f%C3%BCr-h%C3%A4keleien.jpg",
                        Date = new DateTime(2012, 02, 07, 17, 53, 18),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Audi A8",
                        Category = Category.Cars,
                        Discription = "color is Black, power: 550ks, dors: 2",
                        Price = 10000,
                        Town = Town.StaraZagora,
                        ImgUrl = "https://www.audi.bg/media/Theme_Menu_Model_Dropdown_Item_Image_Component/root-bg-model-modelMenu-editableItems-20515-dropdown-92404-image/dh-500-a0e9a6/e77dce37/1452720699/_content_dam_nemo_models_a8_a8_my-2014-pa_multimedia-gallery_1920x1080_AA8_131004_oe_mo.jpg",
                        Date = new DateTime(2017, 03, 27, 17, 06, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Cool big house",
                        Category = Category.RealEstate,
                        Discription = "15 rooms",
                        Price = 158000,
                        Town = Town.Sofia,
                        ImgUrl = "http://www.hotelroomsearch.net/im/hotels/asia/th/grand-house-4.png",
                        Date = new DateTime(2016, 09, 27, 02, 52, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Laptop ASUS",
                        Category = Category.Electronics,
                        Discription = "Cool Laptop Cool Laptop Cool Laptop Cool Laptop Cool Laptop Cool Laptop ",
                        Price = 150,
                        Town = Town.Varna,
                        ImgUrl = "https://cdn1.pcadvisor.co.uk/cmsdata/reviews/3621086/Asus_X555LA-XX290H_budget_laptop_800_thumb800.jpg",
                        Date = new DateTime(2001, 05, 27, 17, 53, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Ryegrass",
                        Category = Category.HomeAndGarden,
                        Discription = "Very green and fresh Very green and fresh Very green and fresh Very green and fresh ",
                        Price = 60,
                        Town = Town.Haskovo,
                        ImgUrl = "http://kingofwallpapers.com/gras/gras-007.jpg",
                        Date = new DateTime(2010, 02, 07, 17, 53, 18),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Trabant 601",
                        Category = Category.Cars,
                        Discription = "color is red, power: 20ks, dors: 4",
                        Price = 1000,
                        Town = Town.Karjali,
                        ImgUrl = "http://p9.storage.canalblog.com/94/98/568981/55960347.jpg",
                        Date = new DateTime(2014, 03, 27, 17, 06, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "NIKE zoom",
                        Category = Category.Sports,
                        Discription = " for runners and fitness maniac  for runners and fitness maniac  for runners and fitness maniac  for runners and fitness maniac  for runners and fitness maniac ",
                        Price = 158000,
                        Town = Town.Sofia,
                        ImgUrl = "http://cdn.runningshoesguru.com/wp-content/uploads/2016/03/Nike-Zoom-Structure-19-Pair.jpg",
                        Date = new DateTime(2016, 09, 27, 02, 52, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });
                }
            }
            
        }
        private void CreateUser(SellPlaceDbContext context,
            string email, string password)
        {
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email
            };

            var userCreateResult = userManager.Create(user, password);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(SellPlaceDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(SellPlaceDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
        }
    }
}

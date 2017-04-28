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

                CreateUser(context, "admin@gmail.com", "123456", "Admin");
                CreateUser(context, "mitaka206@gmail.com", "123", "Dimitar Todorov");
                CreateUser(context, "stefcheto_83@gmail.com", "123", "Stefcheto");
                CreateUser(context, "stamat_29@gmail.com", "123", "Stamat Lambov");
                CreateUser(context, "muncho2000@gmail.com", "123", "Muncho Munchev");

                CreateRole(context, "Admin");
                CreateRole(context, "User");

                AddUserToRole(context, "admin@gmail.com", "Admin");
                AddUserToRole(context, "mitaka206@gmail.com", "User");
                AddUserToRole(context, "stefcheto_83@gmail.com", "User");
                AddUserToRole(context, "stamat_29@gmail.com", "User");
                AddUserToRole(context, "muncho2000@gmail.com", "User");

                if (context.Ads.Count() < 1)
                {

                    var user = context.Users.FirstOrDefault();
                    
                    context.Ads.Add(new Ad
                    {
                        Title = "Village house",
                        Category = Category.RealEstate,
                        Discription = "The tiny houses making headlines today aren’t always the cool new micro dwellings for middle and upper-middle class downsizers and nomads. In fact, if you set a Google alert for tiny homes, you’ll see that one topic comes up almost daily: tiny houses for the homeless.Embracing a strategy of Housing First—the idea that addressing homelessness starts with giving folks a place to live—U.S.cities like Dallas, Detroit, and Portland already have micro home communities for the homeless up and running.New proposals are emerging in towns big and small all the time. Below, check out an overview of 10 different tiny house villages for the homeless that have arisen over the last decade in the U.S., in order from newest to oldest.The fact that they adopt varying scales, amenities, and operating models suggests that whether tiny houses are a solution to homelessness is a question just as complex as the dilemma of homelessness reduction overall. Are there initiatives like these happening in your area ? Feel free to share in the comments below.",   
                        Price = 15800,
                        Town = Town.Burgas,
                        ImgURL = "https://assets.luxuryrealestate.com/lre-assets/images/versions/listings/w960h768_nc_q95/000/306/550/570/1485813538.jpg",
                        Date = new DateTime(2016, 05, 27, 17, 53, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Baby shoes",
                        Category = Category.BabyAndChild,
                        Discription = "These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster These Puma D Cat 5 Crib Shoes are ideal for any youngster ",
                        Price = 60,
                        Town = Town.Haskovo,
                        ImgURL = "https://archzine.net/wp-content/uploads/2015/03/coole-modelle-tolles-design-h%C3%A4keln-babyschuhe-fantastische-ideen-f%C3%BCr-h%C3%A4keleien.jpg",
                        Date = new DateTime(2012, 02, 07, 17, 53, 18),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Audi A8",
                        Category = Category.Cars,
                        Discription = "Audi’s A8L is the pinnacle of German über-luxury sedans, with an understated yet impressive design. It’s beautiful inside, too, and the A8 can be athletic when the road gets twisty. A 333-hp 3.0-liter supercharged V-6 is standard; a 450-hp 4.0-liter twin-turbo V-8 is optional. All-wheel drive and an eight-speed automatic transmission are standard on all models.",
                        Price = 10000,
                        Town = Town.StaraZagora,
                        ImgURL = "https://www.audi.bg/media/Theme_Menu_Model_Dropdown_Item_Image_Component/root-bg-model-modelMenu-editableItems-20515-dropdown-92404-image/dh-500-a0e9a6/e77dce37/1452720699/_content_dam_nemo_models_a8_a8_my-2014-pa_multimedia-gallery_1920x1080_AA8_131004_oe_mo.jpg",
                        Date = new DateTime(2017, 03, 27, 17, 06, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Cool big house",
                        Category = Category.RealEstate,
                        Discription = "Majestic neo-classical estate is positioned on a secluded hill in the Westlake area of Sofia, on just below ten pristine acres. Enter through the private gates and drive along a tree lined lane composed of gray pavers before catching your first glimpse of this stately residence. Architect Charles Fisk, Builder Brian Bailey and whole host of artisans, craftsmen and designers have created a one-of-a kind masterpiece.Two formal elevations that bring to mind a Georgian Tidelands style with columned porticos combines beautifully with the Greek Revival style of the back exterior. An entire wall of Palladian style windows allows for sweeping vistas of the grounds, pool and Sofia Hill Country. Featuring over 10,000 +/- square feet of internal living space, this significant home features five very large bedrooms, eight and a half bathrooms, seven awe-inspiring fireplaces and an additional apartment for guests or staff.The artistic elements that provide continuity of design include statuesque columns, deep crown molding, faux painting, marble and granite elements. Bold color choices warm the interior with luxurious fabric and paint choices in each room. Flooring selections incorporate limestone with diamond pattern granite inlays, Brazilian walnut hardwoods, marble and lush carpet. A stunning barrel ceiling with lavish colors tops off the second story for an Old World Venetian look.Numerous living areas encompass the first floor and provide extensive space to entertain or relax as a family. Formal great room and dining rooms flow into the remainder of the downstairs comprised of the family room, chef's kitchen, library and elegant master retreat. Multiple French doors allow you to walk out to the outdoor living area with an immense marble patio, substantial fireplace and infinity pool with forever views to Barton Creek Resort and beyond.The epicurean masterpiece kitchen has two Subzero refrigerators, two sinks, Dacor 6 burner stove, dual Thermador dishwashers and a warming oven. Large wraparound counter area engages guests in the cooking experience. Precast stone embellishes the cook top hood and natural stone wood-burning fireplace. Pantry, wine closet and Butler's area provide spaces for serving company, as well as storage.Luxurious appointments are abundant in the master retreat. His and Hers bathrooms are embellished with rich marble, granite, iridescent glass tiles and bronze accents. The cast stone impressive fireplace is warm and inviting on a cool Texas evening.Upstairs are four sizeable bedrooms, each with en suite bathroom and their own exclusive style. Balcony access and dramatic views that stretch for miles are hallmarks of theserooms. Enjoy the open sitting area separating two of the rooms with a cup of coffee and a coveted novel.This is a technologically modern home with every convenience at your fingertips. Completely networked and wired throughout for audio, music and internet access it also has security, central vacuum and graphic eye systems already in place.Incomparable attention to detail, classic touches and artistry are plentiful with the added inclusionof every technological home advantage for your lifestyle. A supreme mix of classical sumptuousness, comfort, privacy and up-to-date living are available in this superb estate.",
                        Price = 158000,
                        Town = Town.Sofia,
                        ImgURL = "https://assets.luxuryrealestate.com/lre-assets/images/versions/listings/w960h768_nc_q95/000/306/828/140/1485996442.jpg",
                        Date = new DateTime(2016, 09, 27, 02, 52, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Laptop ASUS GL552VW",
                        Category = Category.Electronics,
                        Discription = "16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM 16GB DDR4 RAMThe ROG GL552VW features a whopping 16GB of ultra - fast DDR4 RAM ",
                        Price = 150,
                        Town = Town.Varna,
                        ImgURL = "https://cdn1.pcadvisor.co.uk/cmsdata/reviews/3621086/Asus_X555LA-XX290H_budget_laptop_800_thumb800.jpg",
                        Date = new DateTime(2001, 05, 27, 17, 53, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Ryegrass",
                        Category = Category.HomeAndGarden,
                        Discription = "The plant is a low-growing, tufted, hairless grass, with a bunching (or tillering) growth habit. The leaves are dark green, smooth and glossy on the lower surface, with untoothed parallel sides and prominent parallel veins on the upper surface. The leaves are folded lengthwise in bud (unlike the rolled leaves of Italian ryegrass, Lolium multiflorum) with a strong central keel, giving a flattened appearance. The ligule is very short and truncate, often difficult to see, and small white auricles grip the stem at the base of the leaf blade. Leaf sheaths at the base are usually tinged pink and hairless. Stems grow up to 90 cm. It has auricles.[2] The inflorescence is unbranched, with spikelets on alternating sides edgeways - on to the stem.Each spikelet has only a single glume, on the side away from the stem, and between 4 and 14 Florets without awns, unlike Italian ryegrass.The anthers are pale yellow, and the plant flowers from May to November.Perennial ryegrass has a fibrous root system, with thick main roots and thinner lateral branches.Roots are usually arbuscular mycorrhizal.",
                        Price = 60,
                        Town = Town.Haskovo,
                        ImgURL = "http://kingofwallpapers.com/gras/gras-007.jpg",
                        Date = new DateTime(2010, 02, 07, 17, 53, 18),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "Trabant 601",
                        Category = Category.Cars,
                        Discription = "With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East With hindsight it can be considered East ",
                        Price = 1000,
                        Town = Town.Karjali,
                        ImgURL = "http://p9.storage.canalblog.com/94/98/568981/55960347.jpg",
                        Date = new DateTime(2014, 03, 27, 17, 06, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });

                    context.Ads.Add(new Ad
                    {
                        Title = "NIKE zoom",
                        Category = Category.Sports,
                        Discription = "Lightweight: With Nike Air cushioning, the weight of the shoe is reduced but performance is not sacrificed. This is important because the lighter the shoe, the less energy athletes must expend. Versatile: Athletes in different sports require diverse performance characteristics.Nike Air cushioning can be tuned to meet the exact specifications of athletic performance. Cushioning: As the foot strikes the ground, Nike Air cushioning absorbs the impact forces and protects muscles, joints and tendons.The Nike Air cushioning will immediately return to its original shape, ready to protect the body against the next impact force. As a result, the athlete can protect against fatigue and stress. Durable: Durability is pivotal because athletes need cushioning to last in their shoes. Nike Air cushioning provides constant cushioning throughout the life of the shoes.",
                        Price = 158000,
                        Town = Town.Sofia,
                        ImgURL = "http://cdn.runningshoesguru.com/wp-content/uploads/2016/03/Nike-Zoom-Structure-19-Pair.jpg",
                        Date = new DateTime(2016, 09, 27, 02, 52, 48),//yyyy,mm,dd , hh,mm,ss
                        SellerId = user.Id
                    });
                }
            }
            
        }
        private void CreateUser(SellPlaceDbContext context,
            string email, string password, string fullName)
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
                Email = email,
                FullName = fullName
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

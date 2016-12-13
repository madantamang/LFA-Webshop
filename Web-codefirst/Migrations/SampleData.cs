using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web_codefirst.Models;

namespace Web_codefirst.Migrations
{
    public class SampleData : DropCreateDatabaseIfModelChanges<Models.ShoppingDbContextModel>
    {
        protected override void Seed(Models.ShoppingDbContextModel context)
        {
            var categories = new List<Category>
            {
                new Category {Name = "Women's Fashion"},
                new Category {Name = "Men's Fashion"},
                new Category {Name = "TV"},
                new Category {Name = "Appliances"},
                new Category {Name = "Cameras"},
                new Category {Name = "Food & Beverages"},
                new Category {Name = "Health & Beauty"},
                new Category {Name = "Computer & Laptops"},
                new Category {Name = "Mobile & Tablets"},
                new Category {Name = "Jwellery"}
            };
            categories.ForEach(c => context.Categories.Add(c));

            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Convertible Car",
                    Description =
                        "This convertible car is fast! The engine is powered by a neutrino based battery (not included)." +
                        "Power it up and let it go!",
                    Image = "carconvert.png",
                    Price = 22.50M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Old-time Car",
                    Description =
                        "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    Image = "carearly.png",
                    Price = 15.95M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Fast Car",
                    Description = "Yes this car is fast, but it also floats in water.",
                    Image = "carfast.png",
                    Price = 32.99M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Super Fast Car",
                    Description = "Use this super fast car to entertain guests. Lights and doors work!",
                    Image = "carfaster.png",
                    Price = 8.95M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Old Style Racer",
                    Description =
                        "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                        "No batteries required.",
                    Image = "carracer.png",
                    Price = 34.95M,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "Ace Plane",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    Image = "planeace.png",
                    Price = 95.00M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Name = "Glider",
                    Description = "This fun glider is made from real balsa wood. Some assembly required.",
                    Image = "planeglider.png",
                    Price = 4.95M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Name = "Paper Plane",
                    Description = "This paper plane is like no other paper plane. Some folding required.",
                    Image = "planepaper.png",
                    Price = 2.95M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 9,
                    Name = "Propeller Plane",
                    Description = "Rubber band powered plane features two wheels.",
                    Image = "planeprop.png",
                    Price = 32.95M,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Name = "Early Truck",
                    Description = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    Image = "truckearly.png",
                    Price = 15.00M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 11,
                    Name = "Fire Truck",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    Image = "truckfire.png",
                    Price = 26.00M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 12,
                    Name = "Big Truck",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    Image = "truckbig.png",
                    Price = 29.00M,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 13,
                    Name = "Big Ship",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                                  "artifically intelligent computer brain!",
                    Image = "boatbig.png",
                    Price = 95.00M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 14,
                    Name = "Paper Boat",
                    Description =
                        "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" +
                        "Some folding required.",
                    Image = "boatpaper.png",
                    Price = 4.95M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 15,
                    Name = "Sail Boat",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    Image = "boatsail.png",
                    Price = 42.95M,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 16,
                    Name = "Rocket",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    Image = "rocket.png",
                    Price = 122.95M,
                    CategoryId = 5
                }

            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
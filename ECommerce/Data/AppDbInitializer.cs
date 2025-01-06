﻿using ECommerce.Models;

namespace ECommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using(var applicationservices = builder.ApplicationServices.CreateScope())
            {

                var context = applicationservices.ServiceProvider.GetService<EcommerceDbContext>();
                context.Database.EnsureCreated();
                //Category
                if (!context.Categories.Any())
                {
                    var categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "C1",
                            Description = "C1"
                        },
                        new Category()
                        {
                            Name = "C2",
                            Description = "C2"
                        },
                        new Category()
                        {
                            Name = "C3",
                            Description = "C3"
                        },
                    };
                    context.Categories.AddRange(categories);
                    context.SaveChanges();
                }
                //Product
                if (!context.Products.Any())
                {
                    var Prodcuts = new List<Product>()
                    {
                        new Product()
                        {
                            Name = "P1", Description = "D1" , Price=150,ImageURL="https...",
                            ProductColor = ProductColor.Red,CategoryId=1
                        },
                        new Product()
                        {
                            Name = "P2", Description = "D2" , Price=200,ImageURL="https...",
                            ProductColor = ProductColor.Red,CategoryId=2
                        },
                        new Product()
                        {
                            Name = "P3", Description = "D3" , Price=300,ImageURL="https...",
                            ProductColor = ProductColor.Red,CategoryId=3
                        },
                    };
                    context.Products.AddRange(Prodcuts);
                    context.SaveChanges();
                }

            }
        }
    }
}

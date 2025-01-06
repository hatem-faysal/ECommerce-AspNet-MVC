using ECommerce.Models;

namespace ECommerce.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            using (var applicationservices = builder.ApplicationServices.CreateScope())
            {
                var context = applicationservices.ServiceProvider.GetService<EcommerceDbContext>();
                context.Database.EnsureCreated();
                //CAtegory
                if (!context.Categories.Any())
                {
                    var caategoreies = new List<Category>()
                    {
                        new Category()
                        {
                            Name="c1",
                            Description="c2"
                        },
                        new Category()
                        {
                            Name="c2",
                            Description="c2"
                        },
                        new Category()
                        {
                            Name="c3",
                            Description="c3"
                        },
                    };
                    context.Categories.AddRange(caategoreies);
                    context.SaveChanges();
                }

                //Product
                if (!context.Products.Any())
                {
                    var product = new List<Product>()
                    {
                        new Product()
                        {
                            Name="p1",
                            Description="d1",
                            Price=120,
                            ImageURL="www",
                            ProductColor=ProductColor.Red,
                            CategoryId=1

                        },
                        new Product()
                        {
                           Name="p2",
                            Description="d2",
                            Price=170,
                            ImageURL="",
                            ProductColor=ProductColor.Green,
                            CategoryId=2

                        },
                        new Product()
                        {
                            Name="p3",
                            Description="d3",
                            Price=300,
                            ImageURL="",
                            ProductColor=ProductColor.Blue,
                            CategoryId=3
                        },
                    };
                    context.Products.AddRange(product);
                    context.SaveChanges();
                }
            }
        }
    }
}

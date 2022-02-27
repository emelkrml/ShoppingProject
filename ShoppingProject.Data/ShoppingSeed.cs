using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShoppingProject.Data.Context;
using ShoppingProject.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Data
{
    public static class ShoppingSeed
    {
        public static void AddData(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();
            var context = scope.ServiceProvider.GetService<ShoppingContext>();
            context.Database.Migrate();
            int customerCount = 7;

            if (!context.Customers.Any())
            {
                for (int i = 0; i < customerCount; i++)
                {
                    context.Customers.Add(new Customer
                    {
                        Name = Faker.Name.First(),
                        Surname = Faker.Name.Last(),
                        Email = Faker.Internet.Email(),
                        Phone = Faker.Phone.Number(),
                        Country = Faker.Country.Name(),
                        City = Faker.Address.City(),
                        Address = Faker.Address.StreetAddress(),
                        Region =Faker.Address.Country()
                    });
                }
                context.SaveChanges();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new List<Product>(){ 
                        new Product(){ ProductName = "Kapüşonlu Baskılı Sweatshirt Yeşil", UnitPrice=79.90M, CategoryID= 3, UnitsInStock=200 },
                        new Product(){ ProductName = "Uzun Kollu Baskılı Sweatshirt Lacivert", UnitPrice=179.15M, CategoryID= 1, UnitsInStock=179},
                        new Product(){ ProductName = "Baskılı Kısa Kollu Kapüşonlu Sweatshirt Pembe", UnitPrice=279.90M, CategoryID= 1, UnitsInStock=247},
                        new Product(){ ProductName = "Basic Kapüşonlu Sweatshirt Turuncu", UnitPrice=89.99M, CategoryID= 2, UnitsInStock=98},
                        new Product(){ ProductName = "Kamuflaj Desenli Kapüşonlu Sweatshirt Haki", UnitPrice=155, CategoryID= 1, UnitsInStock=46},
                        new Product(){ ProductName = "Havlu Kumaş İşlemeli Sweatshirt Mavi", UnitPrice=78.80M, CategoryID= 3, UnitsInStock=87},
                        new Product(){ ProductName = "Bisiklet Yaka Baskılı Sweatshirt Gri", UnitPrice=45.25M, CategoryID= 2, UnitsInStock=63},
                        new Product(){ ProductName = "İşlemeli Polar Sweatshirt Antrasit", UnitPrice=145.90M, CategoryID= 3, UnitsInStock=36},
                        new Product(){ ProductName = "Kapüşonlu Sweatshirt Fermuarlı Antrasit", UnitPrice=95.55M, CategoryID= 1, UnitsInStock=45},
                        new Product(){ ProductName = "Oversize Kapüşonlu Sweatshirt Lila", UnitPrice=45.90M, CategoryID= 1, UnitsInStock=99},
                        new Product(){ ProductName = "Kapitone Balıkçı Yaka Sweatshirt Haki", UnitPrice=78.99M, CategoryID= 3, UnitsInStock=98},
                        new Product(){ ProductName = "Kolej Bomber Ceket Sweatshirt Lacivert", UnitPrice=107.50M, CategoryID= 1, UnitsInStock=47},
                        new Product(){ ProductName = "Basic Kapüşonlu Sweatshirt Kırmızı", UnitPrice=107.50M, CategoryID= 2, UnitsInStock=453},
                        new Product(){ ProductName = "Bisiklet Yaka Baskılı Uzun Kollu Sweatshirt Yeşil", UnitPrice=125.99M, CategoryID= 2, UnitsInStock=129},
                        new Product(){ ProductName = "Oversize Kapüşonlu Sweatshirt Gül", UnitPrice=178.99M, CategoryID= 3, UnitsInStock=89},
                        new Product(){ ProductName = "Basic Kapüşonlu Sweatshirt Gri", UnitPrice=245.75M, CategoryID= 1, UnitsInStock=123},
                        new Product(){ ProductName = "Kadın Siyah V Yakalı Düğmeli Triko Hırka", UnitPrice=195.10M, CategoryID= 2, UnitsInStock=111},
                    }
                    ) ;
            
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new List<Category>(){
                        new Category(){ CategoryName = "Spor Giyim" },
                        new Category(){ CategoryName = "Üst Giyim"},
                        new Category(){ CategoryName = "Dış Giyim"},
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}

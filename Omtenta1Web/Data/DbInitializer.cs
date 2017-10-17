using System.Linq;
using Omtenta1Web.Models;

namespace Omtenta1Web.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                var product1 = new Product()
                {
                    Name = "IPhone X",
                    UnitPrice = 100,
                    NumberInstock = 43
                    

                };
                var product2 = new Product()
                {
                    Name = "Samsung Galaxy",
                    UnitPrice = 80,
                    NumberInstock = 23


                };
                var product3 = new Product()
                {
                    Name = "Sony Ericsson 337",
                    UnitPrice = 25,
                    NumberInstock = 10


                };

                context.Products.Add(product1);
                context.Products.Add(product2);
                context.Products.Add(product3);

                context.SaveChanges();

            }
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Omtenta1Web.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        [Range(50, double.MaxValue)]
        public decimal UnitPrice { get; set; }
        public int NumberInstock { get; set; }
    }
}

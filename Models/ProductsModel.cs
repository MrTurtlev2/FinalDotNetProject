using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FinalDotNetProject.Models
{
    public class ProductsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Brand { get; set; }

        public string Name { get; set; }
        public short YearOfProduction { get; set; }

        public bool IsFromCarDealership { get; set; }

        public string FuelType { get; set; }

        public int Mileage { get; set; }
        public decimal Price { get; set; }
        public decimal PriceGross => decimal.Multiply(Price, 1.23m);

    }
   
}

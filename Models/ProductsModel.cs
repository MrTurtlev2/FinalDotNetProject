using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDotNetProject.Models
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Brand { get; set; }

        public short YerOfProduction { get; set; }

        public bool IsFromCarDealership { get; set; }

        public string FuelType { get; set; }

        public int Mileage { get; set; }

    }
   
}

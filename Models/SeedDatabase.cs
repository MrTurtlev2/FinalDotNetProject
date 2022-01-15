using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalDotNetProject.Data;
using Microsoft.VisualBasic.FileIO;

namespace FinalDotNetProject.Models
{
public class SeedDatabase
{
        public static void Initialize(IServiceProvider serviceProvider)
{
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.ProductsModel.Any())
                {
                    return;   
                }

                context.ProductsModel.AddRange(
                    new ProductsModel
                    {
                        Brand = "Audi",
                        Name = "A7",
                        YearOfProduction = 2012,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 276000,
                        Price = 128900
                    },
                    new ProductsModel
                    {
                        Brand = "Audi",
                        Name = "A6",
                        YearOfProduction = 2017,
                        IsFromCarDealership = true,
                        FuelType = "Diesel",
                        Mileage = 15100,
                        Price = 165900
                    },
                    new ProductsModel
                    {
                        Brand = "Audi",
                        Name = "A5",
                        YearOfProduction = 2021,
                        IsFromCarDealership = true,
                        FuelType = "Diesel",
                        Mileage = 4000,
                        Price = 10900
                    },
                    new ProductsModel
                    {
                        Brand = "Audi",
                        Name = "A4 Avant",
                        YearOfProduction = 2011,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 121000,
                        Price = 50430
                    },
                    new ProductsModel
                    {
                        Brand = "Audi",
                        Name = "Q8",
                        YearOfProduction = 2021,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 276900,
                        Price = 128900
                    },
                    new ProductsModel
                    {
                        Brand = "BMW",
                        Name = "3GT",
                        YearOfProduction = 2017,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 198000,
                        Price = 109900
                    },
                    new ProductsModel
                    {
                        Brand = "BMW",
                        Name = "X3",
                        YearOfProduction = 2021,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 6000,
                        Price = 378900
                    },
                    new ProductsModel
                    {
                        Brand = "BMW",
                        Name = "7 730d",
                        YearOfProduction = 2017,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 189000,
                        Price = 19900
                    },
                    new ProductsModel
                    {
                        Brand = "BMW",
                        Name = "4 430i",
                        YearOfProduction = 2016,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 76000,
                        Price = 140000
                    },
                    new ProductsModel
                    {
                        Brand = "BMW",
                        Name = "5",
                        YearOfProduction = 2021,
                        IsFromCarDealership = true,
                        FuelType = "Diesel",
                        Mileage = 1000,
                        Price = 278900
                    },
                    new ProductsModel
                    {
                        Brand = "Volkswagen",
                        Name = "Passat",
                        YearOfProduction = 2018,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 140900,
                        Price = 92900
                    },
                    new ProductsModel
                    {
                        Brand = "Volkswagen",
                        Name = "Passat B5",
                        YearOfProduction = 2012,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 151000,
                        Price = 42000
                    },
                    new ProductsModel
                    {
                        Brand = "Volkswagen",
                        Name = "Touareg",
                        YearOfProduction = 2012,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 366000,
                        Price = 75000
                    },
                    new ProductsModel
                    {
                        Brand = "Volkswagen",
                        Name = "Amarok",
                        YearOfProduction = 2010,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 321000,
                        Price = 50430
                    },
                    new ProductsModel
                    {
                        Brand = "Volkswagen",
                        Name = "T-Cross",
                        YearOfProduction = 2019,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 15000,
                        Price = 77000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Ranger",
                        YearOfProduction = 2015,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 116000,
                        Price = 59900
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Focus",
                        YearOfProduction = 2029,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 6000,
                        Price = 96000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Transit",
                        YearOfProduction = 2016,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 219000,
                        Price = 58900
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Kuga",
                        YearOfProduction = 2016,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 7000,
                        Price = 109000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mondeo",
                        YearOfProduction = 2016,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 61000,
                        Price = 64500
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mustang Fastback",
                        YearOfProduction = 2019,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 1000,
                        Price = 280000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mustang",
                        YearOfProduction = 2017,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 1100,
                        Price = 327000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mustang 4.0",
                        YearOfProduction = 2012,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 1000,
                        Price = 69000
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mustang",
                        YearOfProduction = 2011,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 1000,
                        Price = 84500
                    },
                    new ProductsModel
                    {
                        Brand = "Ford",
                        Name = "Mustang 2.3",
                        YearOfProduction = 2016,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 900,
                        Price = 99630
                    },
                    new ProductsModel
                    {
                        Brand = "Porsche",
                        Name = "Cayenne",
                        YearOfProduction = 2011,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 297000,
                        Price = 135000
                    },
                    new ProductsModel
                    {
                        Brand = "Porsche",
                        Name = "Macan S",
                        YearOfProduction = 2016,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 36000,
                        Price = 220900
                    },
                    new ProductsModel
                    {
                        Brand = "Porsche",
                        Name = "Macan",
                        YearOfProduction = 2017,
                        IsFromCarDealership = true,
                        FuelType = "Diesel",
                        Mileage = 189000,
                        Price = 290900
                    },
                    new ProductsModel
                    {
                        Brand = "Porsche",
                        Name = "911 Carrera",
                        YearOfProduction = 2017,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 97000,
                        Price = 4490000
                    },
                    new ProductsModel
                    {
                        Brand = "Porsche",
                        Name = "Panamera 4S",
                        YearOfProduction = 2017,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 95484,
                        Price = 389900
                    },
                    new ProductsModel
                    {
                        Brand = "Mercedes-Benz",
                        Name = "E 220",
                        YearOfProduction = 2018,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 210000,
                        Price = 199900
                    },
                    new ProductsModel
                    {
                        Brand = "Mercedes-Benz",
                        Name = "S 500",
                        YearOfProduction = 2016,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 135000,
                        Price = 252500
                    },
                    new ProductsModel
                    {
                        Brand = "Mercedes-Benz",
                        Name = "GLC AMG",
                        YearOfProduction = 2019,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 4000,
                        Price = 500000
                    },
                    new ProductsModel
                    {
                        Brand = "Mercedes-Benz",
                        Name = "S 350",
                        YearOfProduction = 2019,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 99900,
                        Price = 339972
                    },
                    new ProductsModel
                    {
                        Brand = "Mercedes-Benz",
                        Name = "BLB",
                        YearOfProduction = 2021,
                        IsFromCarDealership = true,
                        FuelType = "Benzyna",
                        Mileage = 1,
                        Price = 251100
                    },
                    new ProductsModel
                    {
                        Brand = "Toyota",
                        Name = "Corolla",
                        YearOfProduction = 2019,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 30000,
                        Price = 80900
                    },
                    new ProductsModel
                    {
                        Brand = "Toyota",
                        Name = "RAV4",
                        YearOfProduction = 2017,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 79500,
                        Price = 108000
                    },
                    new ProductsModel
                    {
                        Brand = "Toyota",
                        Name = "ProAce",
                        YearOfProduction = 2018,
                        IsFromCarDealership = false,
                        FuelType = "Diesel",
                        Mileage = 202000,
                        Price = 84900
                    },
                    new ProductsModel
                    {
                        Brand = "Toyota",
                        Name = "Land Cruiser",
                        YearOfProduction = 2008,
                        IsFromCarDealership = false,
                        FuelType = "Benzyna",
                        Mileage = 138000,
                        Price = 95900
                    },
                    new ProductsModel
                    {
                        Brand = "Toyota",
                        Name = "C-HR",
                        YearOfProduction = 2022,
                        IsFromCarDealership = true,
                        FuelType = "Diesel",
                        Mileage = 1,
                        Price = 122700
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

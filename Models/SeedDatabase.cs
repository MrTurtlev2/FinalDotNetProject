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
            using (var context = new FinalDotNetProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FinalDotNetProjectContext>>()))
            {
                // Look for any movies.
                if (context.ProductsModel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ProductsModel.AddRange(
                    new ProductsModel
                    {
                        Name = "Tires",
                        Brand = "Poland",
                        YerOfProduction = 2009,
                        IsFromCarDealership = true,
                        FuelType = "nwm jakie",
                        Mileage = 200000,
                    },
                    new ProductsModel
                    {
                        Name = "Tires1",
                        Brand = "Poland",
                        YerOfProduction = 2008,
                        IsFromCarDealership = true,
                        FuelType = "nwm jakie",
                        Mileage = 200001,
                    },
                    new ProductsModel
                    {
                        Name = "Tires2",
                        Brand = "Poland",
                        YerOfProduction = 2011,
                        IsFromCarDealership = true,
                        FuelType = "nwm jakie",
                        Mileage = 200000,
                    }

                );
                context.SaveChanges();
            }
        }
    }
}

using FinalDotNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalDotNetProject.Interfaces
{
    public interface ProductsModelInterface
    {
        List<ProductsModel> GetProducts();
        ProductsModel GetProduct(int id);
    }
}

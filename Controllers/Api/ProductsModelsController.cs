using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FinalDotNetProject.Data;
using System.Threading.Tasks;
using FinalDotNetProject.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FinalDotNetProject.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class ApiProductsModelController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ApiProductsModelController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductsModel> Get([FromRoute] int id)
        {
            var car = _dbContext.ProductsModel.FirstOrDefault(c => c.Id == id);

            if (car == null)
                return NotFound();
            return Ok(car);
        }
        [HttpGet]
        public ActionResult<IEnumerable<ProductsModel>> GetAll()
        {
            var cars = _dbContext.ProductsModel.ToList();
            return Ok(cars);
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Brand,Name,YearOfProduction,IsFromCarDealership,FuelType,Mileage,Price")] ProductsModel productsModel)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(productsModel);
                await _dbContext.SaveChangesAsync();
            }
            return Created($"/api/cars/{productsModel.Id}", null);
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update(int id, [Bind("Id,Brand,Name,YearOfProduction,IsFromCarDealership,FuelType,Mileage,Price")] ProductsModel productsModel)
        {
            if(id != productsModel.Id)
            {
                return NotFound();
            }
            _dbContext.Update(productsModel);
            _dbContext.SaveChanges();
            return Ok(productsModel);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var car = _dbContext.ProductsModel.FirstOrDefaultAsync(c => c.Id == id);

            if (id == null || car == null)
            {
                return NotFound();
            }
            return Ok(car);

        }
    }
}

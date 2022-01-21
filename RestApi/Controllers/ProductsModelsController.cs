using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FinalDotNetProject.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using FinalDotNetProject.Models;
//using AutoMapper;

namespace RestApi.Controllers
{
    [ApiController]
    public class ProductsModelController : ControllerBase
    {
        private readonly FinalDotNetProjectContext _dbContext;

        public ProductsModelController(FinalDotNetProjectContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        [Route("api/cars/{id}")]
        public ActionResult<ProductsModel> Get([FromRoute] int id)
        {
            var car = _dbContext.ProductsModel.FirstOrDefault(c => c.Id == id);

            if (car == null)
                return NotFound();
            return Ok(car);
        }
        [HttpGet]
        [Route("api/cars")]
        public ActionResult<IEnumerable<ProductsModel>> GetAll()
        {
            var cars = _dbContext.ProductsModel.ToList();
            return Ok(cars);
        }
        [HttpPost]
        [Route("api/cars")]
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
        [Route("api/cars/{id}")]
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
        [Route("api/cars/{id}")]
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

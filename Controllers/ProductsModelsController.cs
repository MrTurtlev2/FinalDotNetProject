using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalDotNetProject.Data;
using FinalDotNetProject.Models;

namespace FinalDotNetProject.Controllers
{
    public class ProductsModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductsModel.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsModel = await _context.ProductsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productsModel == null)
            {
                return NotFound();
            }

            return View(productsModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Brand,Name,YearOfProduction,IsFromCarDealership,FuelType,Mileage,Price")] ProductsModel productsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productsModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsModel = await _context.ProductsModel.FindAsync(id);
            if (productsModel == null)
            {
                return NotFound();
            }
            return View(productsModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Brand,Name,YearOfProduction,IsFromCarDealership,FuelType,Mileage,Price")] ProductsModel productsModel)
        {
            if (id != productsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsModelExists(productsModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productsModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productsModel = await _context.ProductsModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productsModel == null)
            {
                return NotFound();
            }

            return View(productsModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productsModel = await _context.ProductsModel.FindAsync(id);
            _context.ProductsModel.Remove(productsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsModelExists(int id)
        {
            return _context.ProductsModel.Any(e => e.Id == id);
        }
    }
}

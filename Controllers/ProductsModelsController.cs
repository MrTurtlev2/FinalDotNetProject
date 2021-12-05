using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalDotNetProject.Data;
using FinalDotNetProject.Models;

namespace FinalDotNetProject.Controllers
{
    public class ProductsModelsController : Controller
    {
        private readonly FinalDotNetProjectContext _context;

        public ProductsModelsController(FinalDotNetProjectContext context)
        {
            _context = context;
        }

        // GET: ProductsModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductsModel.ToListAsync());
        }

        // GET: ProductsModels/Details/5
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

        // GET: ProductsModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductsModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Brand,YerOfProduction,IsFromCarDealership,FuelType,Mileage")] ProductsModel productsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productsModel);
        }

        // GET: ProductsModels/Edit/5
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

        // POST: ProductsModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Brand,YerOfProduction,IsFromCarDealership,FuelType,Mileage")] ProductsModel productsModel)
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

        // GET: ProductsModels/Delete/5
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

        // POST: ProductsModels/Delete/5
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

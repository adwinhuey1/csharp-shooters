using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using valkyrieID.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ValkyrieIMS.Controllers
{
    [Authorize]
    public class SaleReceiptController : Controller
    {
        
        private readonly ValkyrieDBContext _context;

        public SaleReceiptController(ValkyrieDBContext context)
        {
            _context = context;
        }

        // GET: SaleReceipt
        public async Task<IActionResult> Index()
        {
            return View(await _context.SaleReceipts.ToListAsync());
        }

        // GET: SaleReceipt/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleReceipt = await _context.SaleReceipts
                .FirstOrDefaultAsync(m => m.SaleReceiptId == id);
            if (saleReceipt == null)
            {
                return NotFound();
            }

            return View(saleReceipt);
        }

        // GET: SaleReceipt/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SaleReceipt/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SaleReceiptId,ReceiptDate,Quantity,SalePrice")] SaleReceipt saleReceipt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saleReceipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saleReceipt);
        }

        // GET: SaleReceipt/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleReceipt = await _context.SaleReceipts.FindAsync(id);
            if (saleReceipt == null)
            {
                return NotFound();
            }
            return View(saleReceipt);
        }

        // POST: SaleReceipt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SaleReceiptId,ReceiptDate,Quantity,SalePrice")] SaleReceipt saleReceipt)
        {
            if (id != saleReceipt.SaleReceiptId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleReceipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleReceiptExists(saleReceipt.SaleReceiptId))
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
            return View(saleReceipt);
        }

        // GET: SaleReceipt/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleReceipt = await _context.SaleReceipts
                .FirstOrDefaultAsync(m => m.SaleReceiptId == id);
            if (saleReceipt == null)
            {
                return NotFound();
            }

            return View(saleReceipt);
        }

        // POST: SaleReceipt/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleReceipt = await _context.SaleReceipts.FindAsync(id);
            _context.SaleReceipts.Remove(saleReceipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleReceiptExists(int id)
        {
            return _context.SaleReceipts.Any(e => e.SaleReceiptId == id);
        }
    }
}

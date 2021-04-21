using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using com.study.core.model;

namespace com.study.core.web.Controllers
{
    public class TblOptionsController : Controller
    {
        private readonly mobileSurveyContext _context;

        public TblOptionsController(mobileSurveyContext context)
        {
            _context = context;
        }

        // GET: TblOptions
        public async Task<IActionResult> Index()
        {
            var mobileSurveyContext = _context.TblOption.Include(t => t.TblQuestion);
            return View(await mobileSurveyContext.ToListAsync());
        }

        // GET: TblOptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblOption = await _context.TblOption
                .Include(t => t.TblQuestion)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblOption == null)
            {
                return NotFound();
            }

            return View(tblOption);
        }

        // GET: TblOptions/Create
        public IActionResult Create()
        {
            ViewData["SurveyNo"] = new SelectList(_context.TblQuestion, "SurveyNo", "QtCode");
            return View();
        }

        // POST: TblOptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyNo,QtCode,OpCode,InputType,InputLabel,InputValue,NextQuestion,EndCode,Open")] TblOption tblOption)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblOption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblQuestion, "SurveyNo", "QtCode", tblOption.SurveyNo);
            return View(tblOption);
        }

        // GET: TblOptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblOption = await _context.TblOption.FindAsync(id);
            if (tblOption == null)
            {
                return NotFound();
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblQuestion, "SurveyNo", "QtCode", tblOption.SurveyNo);
            return View(tblOption);
        }

        // POST: TblOptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyNo,QtCode,OpCode,InputType,InputLabel,InputValue,NextQuestion,EndCode,Open")] TblOption tblOption)
        {
            if (id != tblOption.SurveyNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblOption);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblOptionExists(tblOption.SurveyNo))
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
            ViewData["SurveyNo"] = new SelectList(_context.TblQuestion, "SurveyNo", "QtCode", tblOption.SurveyNo);
            return View(tblOption);
        }

        // GET: TblOptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblOption = await _context.TblOption
                .Include(t => t.TblQuestion)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblOption == null)
            {
                return NotFound();
            }

            return View(tblOption);
        }

        // POST: TblOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblOption = await _context.TblOption.FindAsync(id);
            _context.TblOption.Remove(tblOption);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblOptionExists(int id)
        {
            return _context.TblOption.Any(e => e.SurveyNo == id);
        }
    }
}

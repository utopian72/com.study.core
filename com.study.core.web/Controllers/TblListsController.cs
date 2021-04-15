using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using com.study.core.model;
using Microsoft.Extensions.Logging;

namespace com.study.core.web.Controllers
{
    public class TblListsController : Controller
    {
        private readonly mobileSurveyContext _context;
        private readonly ILogger<TblListsController> _logger;

        public TblListsController(mobileSurveyContext context  , ILogger<TblListsController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: TblLists
        public async Task<IActionResult> Index(int? surveyno)
        {
            var mobileSurveyContext = _context.TblList.Include(t => t.SurveyNoNavigation);
            
            var lists = mobileSurveyContext.AsNoTracking();

            //surveyno = surveyno ?? 0;

            _logger.LogInformation($"SurveyNo = {surveyno}");

            lists  = lists.Where(a => a.SurveyNo.Equals(surveyno));

            return View(await lists.ToListAsync());

            //return View(await mobileSurveyContext.ToListAsync());
        }

        // GET: TblLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblList = await _context.TblList
                .Include(t => t.SurveyNoNavigation)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblList == null)
            {
                return NotFound();
            }

            return View(tblList);
        }

        // GET: TblLists/Create
        public IActionResult Create()
        {
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage");
            return View();
        }

        // POST: TblLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyNo,ListNo,CellNum,FinishBl,IngBl,RefusalBl,QuotaOverBl,StopBl,EndCode,StateCode,Col01,Col02,Col03,Col04,Col05,Col06,QuestCount")] TblList tblList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);
            return View(tblList);
        }

        // GET: TblLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblList = await _context.TblList.FindAsync(id);
            if (tblList == null)
            {
                return NotFound();
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);
            return View(tblList);
        }

        // POST: TblLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyNo,ListNo,CellNum,FinishBl,IngBl,RefusalBl,QuotaOverBl,StopBl,EndCode,StateCode,Col01,Col02,Col03,Col04,Col05,Col06,QuestCount")] TblList tblList)
        {
            if (id != tblList.SurveyNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblListExists(tblList.SurveyNo))
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
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);
            return View(tblList);
        }

        // GET: TblLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblList = await _context.TblList
                .Include(t => t.SurveyNoNavigation)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblList == null)
            {
                return NotFound();
            }

            return View(tblList);
        }

        // POST: TblLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblList = await _context.TblList.FindAsync(id);
            _context.TblList.Remove(tblList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblListExists(int id)
        {
            return _context.TblList.Any(e => e.SurveyNo == id);
        }
    }
}

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
    public class TblSurveysController : Controller
    {
        private ILogger<TblSurveysController> _logger;
        private readonly mobileSurveyContext _context;
        const int pageSize = 5;
        public TblSurveysController(mobileSurveyContext context , ILogger<TblSurveysController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: TblSurveys
        public async Task<IActionResult> Index(string query ,  int page = 1)
        {
            string notnullquery = query ?? "";

            //var surveys = await _context
            //                        .TblSurvey
            //                        .OrderBy(p => p.SurveyNo)
            //                        .Skip((page - 1) * pageSize)
            //                        .Take(pageSize)
            //                        .ToListAsync();

            var surveys = await _context
                                    .TblSurvey
                                    .Where(x => x.SName.Contains(notnullquery))
                                    .ToListAsync();

            int total = _context.TblSurvey.Count();

            ViewBag.Query = query;
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalPages = Math.Ceiling((double)total / (double)pageSize);

            //return View(await _context.TblSurvey.ToListAsync());
            PagedList.Core.PagedList<TblSurvey> pagesurveys = new PagedList.Core.PagedList<TblSurvey>(surveys.AsQueryable(), page, pageSize);

            //_logger.LogInformation($"ViewBag.CurrentPage:{ViewBag.CurrentPage},ViewBag.PageSize:{ViewBag.PageSize}, ViewBag.TotalPages;{ ViewBag.TotalPages}");
            return View(pagesurveys);
        }

        // GET: TblSurveys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSurvey = await _context.TblSurvey
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblSurvey == null)
            {
                return NotFound();
            }

            return View(tblSurvey);
        }

        // GET: TblSurveys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblSurveys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyNo,SName,UseBl,SmsMessage,IngQuotaBl,LastDay,Callback,Url,Description,LogoFile,UseListCountBl,CssStyleName,UseQuotaAccessBl,LogoWidth,LogHeight,SurveyYear")] TblSurvey tblSurvey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblSurvey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblSurvey);
        }

        // GET: TblSurveys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSurvey = await _context.TblSurvey.FindAsync(id);
            if (tblSurvey == null)
            {
                return NotFound();
            }
            return View(tblSurvey);
        }

        // POST: TblSurveys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SurveyNo,SName,UseBl,SmsMessage,IngQuotaBl,LastDay,Callback,Url,Description,LogoFile,UseListCountBl,CssStyleName,UseQuotaAccessBl,LogoWidth,LogHeight,SurveyYear")] TblSurvey tblSurvey)
        {
            if (id != tblSurvey.SurveyNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblSurvey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblSurveyExists(tblSurvey.SurveyNo))
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
            return View(tblSurvey);
        }

        // GET: TblSurveys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSurvey = await _context.TblSurvey
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblSurvey == null)
            {
                return NotFound();
            }

            return View(tblSurvey);
        }

        // POST: TblSurveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblSurvey = await _context.TblSurvey.FindAsync(id);
            _context.TblSurvey.Remove(tblSurvey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblSurveyExists(int id)
        {
            return _context.TblSurvey.Any(e => e.SurveyNo == id);
        }
    }
}

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
    public class TblQuestionsController : Controller
    {
        private readonly mobileSurveyContext _context;

        public TblQuestionsController(mobileSurveyContext context)
        {
            _context = context;
        }

        // GET: TblQuestions
        public async Task<IActionResult> Index(int? surveyno)
        {
            var mobileSurveyContext = _context.TblQuestion.Include(t => t.SurveyNoNavigation);


            ViewData["surveyno"] = surveyno;


            return View(await mobileSurveyContext.Where(x => x.SurveyNo.Equals(surveyno)).ToListAsync());
        }

        //[HttpPost]
        public List<TblQuestion> List(int? surveyno)
        {
            //var mobileSurveyContext = _context.TblQuestion.Include(t => t.SurveyNoNavigation);

            ViewData["surveyno"] = surveyno;
            return _context.TblQuestion.Where(x => x.SurveyNo.Equals(surveyno)).ToList();
        }

        // GET: TblQuestions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblQuestion = await _context.TblQuestion
                .Include(t => t.SurveyNoNavigation)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblQuestion == null)
            {
                return NotFound();
            }
            
            ViewData["surveyno"] = id;

            return View(tblQuestion);
        }

        // GET: TblQuestions/Create
        public IActionResult Create()
        {
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage");
            return View();
        }

        // POST: TblQuestions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SurveyNo,QtCode,QtType,QtText,QtBody,QtScript,UseQuotaBl,NextQuestion,EndCode,Exclude,Include,Detailorder")] TblQuestion tblQuestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblQuestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblQuestion.SurveyNo);
            return View(tblQuestion);
        }

        // GET: TblQuestions/Edit/5
        public async Task<IActionResult> Edit(int? surveyno , string qtcode)
        {
            if (surveyno == null || qtcode == null )
            {
                return NotFound();
            }

            var tblQuestion = await _context.TblQuestion.FindAsync(surveyno , qtcode );
            if (tblQuestion == null)
            {
                return NotFound();
            }
            ViewData["SurveyItems"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblQuestion.SurveyNo);
            return View(tblQuestion);
        }

        // POST: TblQuestions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("SurveyNo,QtCode,QtType,QtText,QtBody,QtScript,UseQuotaBl,NextQuestion,EndCode,Exclude,Include,Detailorder")] TblQuestion tblQuestion)
        {
            if (tblQuestion.SurveyNo == 0 )
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblQuestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblQuestionExists(tblQuestion.SurveyNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index) , new { surveyno = tblQuestion.SurveyNo});
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblQuestion.SurveyNo);
            return View(tblQuestion);
        }

        // GET: TblQuestions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblQuestion = await _context.TblQuestion
                .Include(t => t.SurveyNoNavigation)
                .FirstOrDefaultAsync(m => m.SurveyNo == id);
            if (tblQuestion == null)
            {
                return NotFound();
            }

            return View(tblQuestion);
        }

        // POST: TblQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblQuestion = await _context.TblQuestion.FindAsync(id);
            _context.TblQuestion.Remove(tblQuestion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblQuestionExists(int id)
        {
            return _context.TblQuestion.Any(e => e.SurveyNo == id);
        }
    }
}

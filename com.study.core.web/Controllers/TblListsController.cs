using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using com.study.core.model;
using Microsoft.Extensions.Logging;
using PagedList.Core.Mvc;
using PagedList.Core;

namespace com.study.core.web.Controllers
{
    public class TblListsController : Controller
    {
        private readonly mobileSurveyContext _context;
        private readonly ILogger<TblListsController> _logger;

        const int pageSize = 10;

        public TblListsController(mobileSurveyContext context  , ILogger<TblListsController> logger)
        {
            _logger = logger;
            _context = context;
        }


        private IQueryable<TblList> getLists(int? surveyno , string query)
        {
            var includelists = _context.TblList.Include(t => t.SurveyNoNavigation);

            var lists = includelists.AsNoTracking();

            return lists.Where(x=>x.SurveyNo.Equals(surveyno)).Where(x => x.CellNum.Contains(query));

        }

        private IQueryable<TblList> sortList(IQueryable<TblList> lists, string sortOrder)
        {

            ViewData["sortOrderCellNum"] = sortOrder.Equals("CellNum") ? "CellNum_desc" : "CellNum";
            ViewData["sortOrderCol01"] = sortOrder.Equals("Col01") ? "Col01_desc" : "Col01";

            switch (sortOrder)
            {
                case "CellNum":
                    lists = lists.OrderBy(a => a.CellNum);
                    break;
                case "CellNum_desc":
                    lists = lists.OrderByDescending(a => a.CellNum);
                    break;
                case "Col01":
                    lists = lists.OrderBy(a => a.Col01);
                    break;
                case "Col01_desc":
                    lists = lists.OrderByDescending(a => a.Col01);
                    break;

                default:
                    lists = lists.OrderByDescending(a => a.CellNum);
                    break;
            }
            return lists;
        }

        // GET: TblLists
        public IActionResult Index(int? surveyno , string sortOrder, string query, int page = 1)
        {
           

            query = query ?? "";

            sortOrder = string.IsNullOrEmpty(sortOrder) ? "CellNum" : sortOrder;

            //var lists = mobileSurveyContext.AsNoTracking();

            //surveyno = surveyno ?? 0;
            var lists = getLists(surveyno , query);

            lists = sortList(lists, sortOrder);
            
            ViewData["query"] = query;
            ViewData["sortOrder"] = sortOrder;
            ViewData["currentSort"] = sortOrder;
            ViewData["surveyno"] = surveyno?? 0;

            if (lists != null)
            {
                var pagesurveys = new PagedList.Core.PagedList<TblList>(lists, page, pageSize);
                return View(pagesurveys);
            }else
            {
                return View();
            }
          
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
                return RedirectToAction(nameof(Index) , nameof(tblList) , new {surveyno = tblList.SurveyNo });
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);
            return View(tblList);
        }

        // GET: TblLists/Edit/5
        public async Task<IActionResult> Edit(int? surveyno , int? listno)
        {
            if (surveyno == null && listno ==null )
            {
                return NotFound();
            }

            var tblList = await _context.TblList.FindAsync(surveyno , listno);
            if (tblList == null)
            {
                return NotFound();
            }

            ViewData["SurveyItems"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);

            return View(tblList);
        }

        // POST: TblLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( [Bind("SurveyNo,ListNo,CellNum,FinishBl,IngBl,RefusalBl,QuotaOverBl,StopBl,EndCode,StateCode,Col01,Col02,Col03,Col04,Col05,Col06,QuestCount")] TblList tblList)
        {
            //if (surveyno != tblList.SurveyNo || listno != tblList.ListNo)
            //{
            //    return NotFound();
            //}

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblListExists(tblList.SurveyNo , tblList.ListNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "TblLists", new { surveyno = tblList.SurveyNo });
            }
            ViewData["SurveyNo"] = new SelectList(_context.TblSurvey, "SurveyNo", "SmsMessage", tblList.SurveyNo);
            return View(tblList);
        }

        // GET: TblLists/Delete/5
        public async Task<IActionResult> Delete(int? surveyno, int? listno)
        {
            if (surveyno == null && listno == null )
            {
                return NotFound();
            }

            var tblList = await _context.TblList
                .Include(t => t.SurveyNoNavigation)
                .FirstOrDefaultAsync(m => m.SurveyNo == surveyno  && m.ListNo == listno);
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

        private bool TblListExists(int surveyno, int listno)
        {
            return _context.TblList.Any(e => e.SurveyNo == surveyno &&   e.ListNo == listno);
        }
    }
}

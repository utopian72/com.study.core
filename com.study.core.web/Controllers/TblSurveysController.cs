using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Net.Http.Headers;
using com.study.core.model;
using System.Net;
using com.study.core.utility;
namespace com.study.core.web.Controllers
{
    public class TblSurveysController : Controller
    {
        private ILogger<TblSurveysController> _logger;
        private readonly mobileSurveyContext _context;
        const int pageSize = 10;
        private IWebHostEnvironment _environment;

        
        
        public TblSurveysController(mobileSurveyContext context , ILogger<TblSurveysController> logger , IWebHostEnvironment environment)
        {
            _logger = logger;
            _context = context;
            _environment = environment;
        }

        private IQueryable<TblSurvey> sortSurveys(IQueryable<TblSurvey> surveys  ,  string sortOrder )
        {

            ViewData["sortOrderSName"] = sortOrder.Equals("SName") ? "SName_desc" : "SName";

            switch (sortOrder)
            {
                case "SName":
                    surveys = surveys.OrderBy(a => a.SName);
                    break;
                case "SName_desc":
                    surveys = surveys.OrderByDescending(a => a.SName);
                    break;
                default:
                    surveys = surveys.OrderByDescending(a => a.SName);
                    break;
            }
            return surveys;
        }

        public IActionResult DownLoad(string query)
        {
            var toexcel = new ToExcelWithOfficeOpenXml();
            var lists = getSurveys(query);

            MemoryStream stream = toexcel.convertToExcel<TblSurvey>(lists.ToList());

            string fileName = "data.xlsx";
            string fileType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            stream.Position = 0;

            return File(stream, fileType, fileName);

        }

        private IQueryable<TblSurvey> getSurveys(string query)
        {
            var surveys = _context.TblSurvey.AsNoTracking();

            return  surveys.Where(x => x.SName.Contains(query));

        }
        // GET: TblSurveys
        public IActionResult Index( string sortOrder ,  string query ,  int page = 1)
        {
           
            query = query ?? "";

            
            sortOrder = string.IsNullOrEmpty(sortOrder) ? "SName_desc" : sortOrder;


            var surveys = getSurveys(query);

            surveys = sortSurveys(surveys, sortOrder);

            ViewData["query"] = query;
            ViewData["sortOrder"] = sortOrder;
            ViewData["currentSort"] = sortOrder;
            ViewData["query"] = query;

            PagedList.Core.PagedList<TblSurvey> pagesurveys = new PagedList.Core.PagedList<TblSurvey>(surveys.AsNoTracking(), page, pageSize);

            
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
        public async Task<IActionResult> Edit(int id, [Bind("SurveyNo,SName,UseBl,SmsMessage,IngQuotaBl,LastDay,Callback,Url,Description,LogoFile,UseListCountBl,CssStyleName,UseQuotaAccessBl,LogoWidth,LogHeight,SurveyYear")] TblSurvey tblSurvey , ICollection<IFormFile> fileCollection)        
        {
            if (id != tblSurvey.SurveyNo)
            {
                return NotFound();
            }

            _logger.LogInformation($"fileCollection :{fileCollection.Count}");

            long totalSize = 0L;

            if (!fileCollection.Count.Equals(0))
            {
                var uploadDirectoryPath = Path.Combine(_environment.WebRootPath, "upload");

                foreach (IFormFile formFile in fileCollection) { 
                    string uploadFilePath = Path.Combine(uploadDirectoryPath, formFile.FileName); 
                    using (FileStream fileStream = System.IO.File.Create(uploadFilePath)) { 
                        formFile.CopyTo(fileStream); fileStream.Flush(); } totalSize += formFile.Length; 
                }
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

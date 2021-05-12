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
    public class TblUsersController : Controller
    {
        private readonly mobileSurveyContext _context;

        public TblUsersController(mobileSurveyContext context)
        {
            _context = context;
        }

        // GET: TblUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblUsers.ToListAsync());
        }

        // GET: TblUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.MemId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // GET: TblUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MemId,Pwd,MemName,Grade,IsDel,LastDate,RegDate")] TblUser tblUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblUser);
        }

        // GET: TblUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }
            return View(tblUser);
        }

        // POST: TblUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MemId,Pwd,MemName,Grade,IsDel,LastDate,RegDate")] TblUser tblUser)
        {
            if (id != tblUser.MemId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblUserExists(tblUser.MemId))
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
            return View(tblUser);
        }

        // GET: TblUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblUser = await _context.TblUsers
                .FirstOrDefaultAsync(m => m.MemId == id);
            if (tblUser == null)
            {
                return NotFound();
            }

            return View(tblUser);
        }

        // POST: TblUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblUser = await _context.TblUsers.FindAsync(id);
            _context.TblUsers.Remove(tblUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblUserExists(string id)
        {
            return _context.TblUsers.Any(e => e.MemId == id);
        }
    }
}

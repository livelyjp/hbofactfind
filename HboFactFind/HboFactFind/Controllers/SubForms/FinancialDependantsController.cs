using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HboFactFind.Domain.Questions.Dependants;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubForms
{
    public class FinancialDependantsController : Controller
    {
        private HboDbContext db = new HboDbContext();

        // GET: FinancialDependants
        public async Task<ActionResult> Index()
        {
            var financialDependants = db.FinancialDependants.Include(f => f.PageFour);
            return View(await financialDependants.ToListAsync());
        }

        // GET: FinancialDependants/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDependant financialDependant = await db.FinancialDependants.FindAsync(id);
            if (financialDependant == null)
            {
                return HttpNotFound();
            }
            return View(financialDependant);
        }

        // GET: FinancialDependants/Create
        public ActionResult Create()
        {
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id");
            return View();
        }

        // POST: FinancialDependants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PageFourId,DependantName,DateOfBirth,DependantOn,AgeOfIndependance,RelationshipAndReason,CreatedDateTime")] FinancialDependant financialDependant)
        {
            if (ModelState.IsValid)
            {
                db.FinancialDependants.Add(financialDependant);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", financialDependant.PageFourId);
            return View(financialDependant);
        }

        // GET: FinancialDependants/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDependant financialDependant = await db.FinancialDependants.FindAsync(id);
            if (financialDependant == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", financialDependant.PageFourId);
            return View(financialDependant);
        }

        // POST: FinancialDependants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PageFourId,DependantName,DateOfBirth,DependantOn,AgeOfIndependance,RelationshipAndReason,CreatedDateTime")] FinancialDependant financialDependant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(financialDependant).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", financialDependant.PageFourId);
            return View(financialDependant);
        }

        // GET: FinancialDependants/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinancialDependant financialDependant = await db.FinancialDependants.FindAsync(id);
            if (financialDependant == null)
            {
                return HttpNotFound();
            }
            return View(financialDependant);
        }

        // POST: FinancialDependants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            FinancialDependant financialDependant = await db.FinancialDependants.FindAsync(id);
            db.FinancialDependants.Remove(financialDependant);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

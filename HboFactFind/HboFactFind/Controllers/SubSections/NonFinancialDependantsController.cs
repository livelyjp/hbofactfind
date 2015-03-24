using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Questions.Dependants;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubSections
{
    public class NonFinancialDependantsController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: NonFinancialDependants
        public async Task<ActionResult> Index()
        {
            var nonFinancialDependantses = db.NonFinancialDependantses.Include(n => n.PageFour);
            return View(await nonFinancialDependantses.ToListAsync());
        }

        // GET: NonFinancialDependants/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var nonFinancialDependants = await db.NonFinancialDependantses.FindAsync(id);
            if (nonFinancialDependants == null)
            {
                return HttpNotFound();
            }
            return View(nonFinancialDependants);
        }

        // GET: NonFinancialDependants/Create
        public ActionResult Create()
        {
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id");
            return View();
        }

        // POST: NonFinancialDependants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(Include = "Id,PageFourId,Name,DateOfBirth,Relationship,Notes,CreatedDateTime")] NonFinancialDependants
                nonFinancialDependants)
        {
            if (ModelState.IsValid)
            {
                db.NonFinancialDependantses.Add(nonFinancialDependants);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", nonFinancialDependants.PageFourId);
            return View(nonFinancialDependants);
        }

        // GET: NonFinancialDependants/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var nonFinancialDependants = await db.NonFinancialDependantses.FindAsync(id);
            if (nonFinancialDependants == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", nonFinancialDependants.PageFourId);
            return View(nonFinancialDependants);
        }

        // POST: NonFinancialDependants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,PageFourId,Name,DateOfBirth,Relationship,Notes,CreatedDateTime")] NonFinancialDependants
                nonFinancialDependants)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nonFinancialDependants).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageFourId = new SelectList(db.PageFours, "Id", "Id", nonFinancialDependants.PageFourId);
            return View(nonFinancialDependants);
        }

        // GET: NonFinancialDependants/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var nonFinancialDependants = await db.NonFinancialDependantses.FindAsync(id);
            if (nonFinancialDependants == null)
            {
                return HttpNotFound();
            }
            return View(nonFinancialDependants);
        }

        // POST: NonFinancialDependants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var nonFinancialDependants = await db.NonFinancialDependantses.FindAsync(id);
            db.NonFinancialDependantses.Remove(nonFinancialDependants);
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
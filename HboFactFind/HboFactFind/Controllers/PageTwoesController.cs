using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageTwoesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageTwoes
        public async Task<ActionResult> Index()
        {
            var pageTwos = db.PageTwos.Include(p => p.FactFind);
            return View(await pageTwos.ToListAsync());
        }

        // GET: PageTwoes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTwo = await db.PageTwos.FindAsync(id);
            if (pageTwo == null)
            {
                return HttpNotFound();
            }
            return View(pageTwo);
        }

        // GET: PageTwoes/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageTwoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneEmploymentStatus,ClientOneOccupation,ClientOneDetailsOfEmployer,ClientOneEmploymentStartDate,ClientOneIntendedRetirementAge,ClientTwoStatusEmploymentStatus,ClientTwoOccupation,ClientTwoDetailsOfEmployer,ClientTwoEmploymentStartDate,ClientTwoIntendedRetirementAge,FactFindId,CreatedDateTime"
                )] PageTwo pageTwo)
        {
            if (ModelState.IsValid)
            {
                db.PageTwos.Add(pageTwo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTwo.FactFindId);
            return View(pageTwo);
        }

        // GET: PageTwoes/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTwo = await db.PageTwos.FindAsync(id);
            if (pageTwo == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTwo.FactFindId);
            return View(pageTwo);
        }

        // POST: PageTwoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneEmploymentStatus,ClientOneOccupation,ClientOneDetailsOfEmployer,ClientOneEmploymentStartDate,ClientOneIntendedRetirementAge,ClientTwoStatusEmploymentStatus,ClientTwoOccupation,ClientTwoDetailsOfEmployer,ClientTwoEmploymentStartDate,ClientTwoIntendedRetirementAge,FactFindId,CreatedDateTime"
                )] PageTwo pageTwo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageTwo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTwo.FactFindId);
            return View(pageTwo);
        }

        // GET: PageTwoes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTwo = await db.PageTwos.FindAsync(id);
            if (pageTwo == null)
            {
                return HttpNotFound();
            }
            return View(pageTwo);
        }

        // POST: PageTwoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageTwo = await db.PageTwos.FindAsync(id);
            db.PageTwos.Remove(pageTwo);
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
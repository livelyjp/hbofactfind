using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageFoursController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageFours
        public async Task<ActionResult> Index()
        {
            var pageFours = db.PageFours.Include(p => p.FactFind);
            return View(await pageFours.ToListAsync());
        }

        // GET: PageFours/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFour = await db.PageFours.FindAsync(id);
            if (pageFour == null)
            {
                return HttpNotFound();
            }
            return View(pageFour);
        }

        // GET: PageFours/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageFours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(Include = "Id,AnyFinancialDependants,FactFindId,CreatedDateTime")] PageFour pageFour)
        {
            if (ModelState.IsValid)
            {
                db.PageFours.Add(pageFour);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFour.FactFindId);
            return View(pageFour);
        }

        // GET: PageFours/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFour = await db.PageFours.FindAsync(id);
            if (pageFour == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFour.FactFindId);
            return View(pageFour);
        }

        // POST: PageFours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,AnyFinancialDependants,FactFindId,CreatedDateTime")] PageFour pageFour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageFour).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFour.FactFindId);
            return View(pageFour);
        }

        // GET: PageFours/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFour = await db.PageFours.FindAsync(id);
            if (pageFour == null)
            {
                return HttpNotFound();
            }
            return View(pageFour);
        }

        // POST: PageFours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageFour = await db.PageFours.FindAsync(id);
            db.PageFours.Remove(pageFour);
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
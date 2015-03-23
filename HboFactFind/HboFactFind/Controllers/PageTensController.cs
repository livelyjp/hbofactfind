using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageTensController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageTens
        public async Task<ActionResult> Index()
        {
            var pageTens = db.PageTens.Include(p => p.FactFind);
            return View(await pageTens.ToListAsync());
        }

        // GET: PageTens/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTen = await db.PageTens.FindAsync(id);
            if (pageTen == null)
            {
                return HttpNotFound();
            }
            return View(pageTen);
        }

        // GET: PageTens/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageTens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(Include = "Id,ExistingPlansNotes,FactFindId,CreatedDateTime")] PageTen pageTen)
        {
            if (ModelState.IsValid)
            {
                db.PageTens.Add(pageTen);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTen.FactFindId);
            return View(pageTen);
        }

        // GET: PageTens/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTen = await db.PageTens.FindAsync(id);
            if (pageTen == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTen.FactFindId);
            return View(pageTen);
        }

        // POST: PageTens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,ExistingPlansNotes,FactFindId,CreatedDateTime")] PageTen pageTen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageTen).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageTen.FactFindId);
            return View(pageTen);
        }

        // GET: PageTens/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTen = await db.PageTens.FindAsync(id);
            if (pageTen == null)
            {
                return HttpNotFound();
            }
            return View(pageTen);
        }

        // POST: PageTens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageTen = await db.PageTens.FindAsync(id);
            db.PageTens.Remove(pageTen);
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
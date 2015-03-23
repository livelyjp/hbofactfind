using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageThreesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageThrees
        public async Task<ActionResult> Index()
        {
            var pageThrees = db.PageThrees.Include(p => p.FactFind);
            return View(await pageThrees.ToListAsync());
        }

        // GET: PageThrees/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageThree = await db.PageThrees.FindAsync(id);
            if (pageThree == null)
            {
                return HttpNotFound();
            }
            return View(pageThree);
        }

        // GET: PageThrees/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageThrees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneSolicitor,ClientOneAccountant,ClientOneAdviserOther,ClientTwoSolicitor,ClientTwoAccountant,ClientTwoAdviserOther,FactFindId,CreatedDateTime"
                )] PageThree pageThree)
        {
            if (ModelState.IsValid)
            {
                db.PageThrees.Add(pageThree);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageThree.FactFindId);
            return View(pageThree);
        }

        // GET: PageThrees/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageThree = await db.PageThrees.FindAsync(id);
            if (pageThree == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageThree.FactFindId);
            return View(pageThree);
        }

        // POST: PageThrees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneSolicitor,ClientOneAccountant,ClientOneAdviserOther,ClientTwoSolicitor,ClientTwoAccountant,ClientTwoAdviserOther,FactFindId,CreatedDateTime"
                )] PageThree pageThree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageThree).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageThree.FactFindId);
            return View(pageThree);
        }

        // GET: PageThrees/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageThree = await db.PageThrees.FindAsync(id);
            if (pageThree == null)
            {
                return HttpNotFound();
            }
            return View(pageThree);
        }

        // POST: PageThrees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageThree = await db.PageThrees.FindAsync(id);
            db.PageThrees.Remove(pageThree);
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
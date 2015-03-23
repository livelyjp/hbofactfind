using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageEightsController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageEights
        public async Task<ActionResult> Index()
        {
            var pageEights = db.PageEights.Include(p => p.FactFind);
            return View(await pageEights.ToListAsync());
        }

        // GET: PageEights/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageEight = await db.PageEights.FindAsync(id);
            if (pageEight == null)
            {
                return HttpNotFound();
            }
            return View(pageEight);
        }

        // GET: PageEights/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageEights/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneRequiredEmergancyFund,ClientOnePlannedExpenditure,ClientOneMadeAWill,ClientOneWillNotes,ClientTwoRequiredEmergancyFund,ClientTwoPlannedExpenditure,ClientTwoMadeAWill,ClientTwoWillNotes,FactFindId,CreatedDateTime"
                )] PageEight pageEight)
        {
            if (ModelState.IsValid)
            {
                db.PageEights.Add(pageEight);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageEight.FactFindId);
            return View(pageEight);
        }

        // GET: PageEights/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageEight = await db.PageEights.FindAsync(id);
            if (pageEight == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageEight.FactFindId);
            return View(pageEight);
        }

        // POST: PageEights/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneRequiredEmergancyFund,ClientOnePlannedExpenditure,ClientOneMadeAWill,ClientOneWillNotes,ClientTwoRequiredEmergancyFund,ClientTwoPlannedExpenditure,ClientTwoMadeAWill,ClientTwoWillNotes,FactFindId,CreatedDateTime"
                )] PageEight pageEight)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageEight).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageEight.FactFindId);
            return View(pageEight);
        }

        // GET: PageEights/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageEight = await db.PageEights.FindAsync(id);
            if (pageEight == null)
            {
                return HttpNotFound();
            }
            return View(pageEight);
        }

        // POST: PageEights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageEight = await db.PageEights.FindAsync(id);
            db.PageEights.Remove(pageEight);
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
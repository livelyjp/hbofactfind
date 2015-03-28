using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageEightController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageEights.ToListAsync());
        }

        // GET: PageEights/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageEight = await _db.PageEights.FindAsync(id);
            if (pageEight == null)
            {
                return HttpNotFound();
            }
            return View(pageEight);
        }

        // GET: PageEights/Edit/5
        [Route("~/FactFind/PageEight/{factFindId}", Name = "PageEight")]
        public async Task<ActionResult> Edit(long? factFindId)
        {
            if (factFindId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await _db.FactFinds.FindAsync(factFindId);
            if (factFind == null)
            {
                return HttpNotFound();
            }

            var page = await _db.PageEights.FirstAsync(x => x.Id == factFind.PageEightId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageEights/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageEight/{factFindId}")]
        public async Task<ActionResult> Edit(
           [Bind(Include = "Id,ClientOneRequiredEmergancyFund,ClientOnePlannedExpenditure,ClientOneMadeAWill,ClientOneWillNotes,ClientTwoRequiredEmergancyFund,ClientTwoPlannedExpenditure,ClientTwoMadeAWill,ClientTwoWillNotes,CreatedDateTime")] PageEight pageEight)
        {
            if (!ModelState.IsValid) return View(pageEight);
            _db.Entry(pageEight).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return RedirectToAction("Edit", "PageNine");
        }

        // GET: PageEights/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageEight = await _db.PageEights.FindAsync(id);
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
            var pageEight = await _db.PageEights.FindAsync(id);
            _db.PageEights.Remove(pageEight);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
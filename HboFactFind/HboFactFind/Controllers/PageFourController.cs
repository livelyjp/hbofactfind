using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    [Authentication]
    public class PageFourController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageFours.ToListAsync());
        }

        // GET: PageFours/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFour = await _db.PageFours.FindAsync(id);
            if (pageFour == null)
            {
                return HttpNotFound();
            }
            return View(pageFour);
        }

        // GET: PageFours/Edit/5
        [Route("~/FactFind/PageFour/{factFindId}", Name = "PageFour")]
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

            var page = await _db.PageFours.FirstAsync(x => x.Id == factFind.PageFourId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageFours/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageFour/{factFindId}")]
        public async Task<ActionResult> Edit(
           [Bind(Include = "Id,AnyFinancialDependants,CreatedDateTime")] PageFour pageFour)
        {
            if (!ModelState.IsValid) return View(pageFour);
            _db.Entry(pageFour).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageFive");
        }

        // GET: PageFours/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFour = await _db.PageFours.FindAsync(id);
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
            var pageFour = await _db.PageFours.FindAsync(id);
            _db.PageFours.Remove(pageFour);
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
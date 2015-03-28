using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageThreeController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageThrees.ToListAsync());
        }

        // GET: PageThrees/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var PageThree = await _db.PageThrees.FindAsync(id);
            if (PageThree == null)
            {
                return HttpNotFound();
            }
            return View(PageThree);
        }

        // GET: PageThrees/Edit/5
        [Route("~/FactFind/PageThree/{factFindId}", Name = "PageThree")]
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

            var page = await _db.PageThrees.FirstAsync(x => x.Id == factFind.PageThreeId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageThrees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageThree/{factFindId}")]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,ClientOneSolicitor,ClientOneAccountant,ClientOneAdviserOther,ClientTwoSolicitor,ClientTwoAccountant,ClientTwoAdviserOther,CreatedDateTime")] PageThree PageThree)
        {
            if (!ModelState.IsValid) return View(PageThree);
            _db.Entry(PageThree).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageFour");
        }

        // GET: PageThrees/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageThree = await _db.PageThrees.FindAsync(id);
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
            var pageThree = await _db.PageThrees.FindAsync(id);
            _db.PageThrees.Remove(pageThree);
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
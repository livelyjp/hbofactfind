using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageTenController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageTens.ToListAsync());
        }

        // GET: PageTens/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTen = await _db.PageTens.FindAsync(id);
            if (pageTen == null)
            {
                return HttpNotFound();
            }
            return View(pageTen);
        }

        // GET: PageTens/Edit/5
        [Route("~/FactFind/PageTen/{factFindId}")]
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

            var page = await _db.PageTens.FirstAsync(x => x.Id == factFind.PageTenId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageTens/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageTen/{factFindId}")]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ExistingPlansNotes,CreatedDateTime")] PageTen pageTen)
        {
            if (!ModelState.IsValid) return View(pageTen);
            _db.Entry(pageTen).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Details", "FactFind", new {@id = 1});
        }

        // GET: PageTens/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTen = await _db.PageTens.FindAsync(id);
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
            var pageTen = await _db.PageTens.FindAsync(id);
            _db.PageTens.Remove(pageTen);
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
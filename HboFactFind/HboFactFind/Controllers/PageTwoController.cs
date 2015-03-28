using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageTwoController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: PageTwoes
        public async Task<ActionResult> Index()
        {
            return View(await _db.PageTwos.ToListAsync());
        }

        // GET: PageTwoes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTwo = await _db.PageTwos.FindAsync(id);
            if (pageTwo == null)
            {
                return HttpNotFound();
            }
            return View(pageTwo);
        }

        // GET: PageTwoes/Edit/5
        [Route("~/FactFind/PageTwo/{factFindId}")]
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

            var page = await _db.PageTwos.FirstAsync(x => x.Id == factFind.PageTwoId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageTwoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageTwo/{factFindId}")]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,ClientOneEmploymentStatus,ClientOneOccupation,ClientOneDetailsOfEmployer,ClientOneEmploymentStartDate,ClientOneIntendedRetirementAge,ClientTwoStatusEmploymentStatus,ClientTwoOccupation,ClientTwoDetailsOfEmployer,ClientTwoEmploymentStartDate,ClientTwoIntendedRetirementAge,CreatedDateTime")] PageTwo pageTwo)
        {
            if (!ModelState.IsValid) return View(pageTwo);
            _db.Entry(pageTwo).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageThree");
        }

        // GET: PageTwoes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageTwo = await _db.PageTwos.FindAsync(id);
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
            var pageTwo = await _db.PageTwos.FindAsync(id);
            _db.PageTwos.Remove(pageTwo);
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
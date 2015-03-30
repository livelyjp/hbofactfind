using System;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;
using HboFactFind.Services;

namespace HboFactFind.Controllers
{
    [Authentication]
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
        [Route("~/FactFind/PageTen/{factFindId}", Name = "PageTen")]
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
        public async Task<ActionResult> Edit([Bind(Include = "Id,Notes,CreatedDateTime")] PageTen pageTen)
        {
            if (!ModelState.IsValid) return View(pageTen);
            _db.Entry(pageTen).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            var factFindRepositorty = new FactFindRepositorty(_db);
            var factFind = await factFindRepositorty.Get(pageTen.Id);

            if (factFind == null) return RedirectToAction("Details", "FactFind");
            factFind.CompletionDateTime = DateTime.UtcNow;
            _db.Entry(factFind).State = EntityState.Modified;
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
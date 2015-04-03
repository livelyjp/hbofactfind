using System;
using System.Data.Entity;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain;
using HboFactFind.EF;
using HboFactFind.Services;

namespace HboFactFind.Controllers
{
    [Authentication]
    public class FactFindController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: FactFinds
        public async Task<ActionResult> Index()
        {
            var factFinds = _db.FactFinds.Include(x=>x.User);
            return View(await factFinds.ToListAsync());
        }

        // GET: FactFinds/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFindRepositorty = new FactFindRepositorty(_db);
            var factFind = await factFindRepositorty.Get(id.Value);

            if (factFind == null)
            {
                return HttpNotFound();
            }
            return View(factFind);
        }

        // GET: FactFinds/Create
        public ActionResult Create()
        {
//            var newFactFind = new FactFind();
            var factFindRepositorty = new FactFindRepositorty(_db);
            var newFactFind = factFindRepositorty.Create(Convert.ToInt32(User.Identity.Name));

            return RedirectToAction("PageOne", "FactFind", new {@id = newFactFind.Id});
        }

        // POST: FactFinds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "ClientOneName,ClientTwoName"
                )] FactFind factFind)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (factFind.CreatedDateTime == DateTime.MinValue) factFind.CreatedDateTime = DateTime.Now;
                    _db.FactFinds.Add(factFind);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return View(factFind);
        }

        // GET: FactFinds/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return RedirectToAction("PageOne", "FactFind", new { @id =id });
        }

        // POST: FactFinds/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneName,ClientTwoName,UserId,CompletionDateTime,PageOneClientOneId,PageTwoId,PageThreeId,PageFourId,PageFiveId,PageSixId,PageSevenId,PageEightId,PageNineId,PageTenId,CreatedDateTime"
                )] FactFind factFind)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(factFind).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(_db.PageEights, "Id", "ClientOneRequiredEmergancyFund", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFives, "Id", "IncomeNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageFours, "Id", "Id", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageNines, "Id", "Notes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageOnes, "Id", "ClientOneForename", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSevens, "Id", "AssetsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageSixs, "Id", "OutGoingsNotes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTens, "Id", "Notes", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageThrees, "Id", "ClientOneSolicitor", factFind.Id);
            ViewBag.Id = new SelectList(_db.PageTwos, "Id", "ClientOneOccupation", factFind.Id);
            return View(factFind);
        }

        // GET: FactFinds/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await _db.FactFinds.FindAsync(id);
            if (factFind == null)
            {
                return HttpNotFound();
            }
            return View(factFind);
        }

        // POST: FactFinds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var factFind = await _db.FactFinds.FindAsync(id);
            _db.FactFinds.Remove(factFind);
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

        public async Task<ActionResult> ExportPdf(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFindRepositorty = new FactFindRepositorty(_db);
            var factFind = await factFindRepositorty.Get(id.Value);

            if (factFind == null)
            {
                return HttpNotFound();
            }
            return null;
        }
    }
}
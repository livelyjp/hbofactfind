using System;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class FactFindController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: FactFinds
        public async Task<ActionResult> Index()
        {
            var factFinds = db.FactFinds;
            return View(await factFinds.ToListAsync());
        }

        // GET: FactFinds/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await db.FactFinds.FindAsync(id);
            if (factFind == null)
            {
                return HttpNotFound();
            }
            return View(factFind);
        }

        // GET: FactFinds/Create
        public ActionResult Create()
        {
            return View();
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
                    db.FactFinds.Add(factFind);
                    await db.SaveChangesAsync();
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
            var factFind = await db.FactFinds.FindAsync(id);
            if (factFind == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.PageEights, "Id", "ClientOneRequiredEmergancyFund", factFind.Id);
            ViewBag.Id = new SelectList(db.PageFives, "Id", "ClientOneIncomeNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageFours, "Id", "Id", factFind.Id);
            ViewBag.Id = new SelectList(db.PageNines, "Id", "ClientOnePrioritiesNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageOnes, "Id", "ClientOneForename", factFind.Id);
            ViewBag.Id = new SelectList(db.PageSevens, "Id", "AssetsNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageSixs, "Id", "OutGoingsNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageTens, "Id", "ExistingPlansNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageThrees, "Id", "ClientOneSolicitor", factFind.Id);
            ViewBag.Id = new SelectList(db.PageTwos, "Id", "ClientOneOccupation", factFind.Id);
            return View(factFind);
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
                db.Entry(factFind).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.PageEights, "Id", "ClientOneRequiredEmergancyFund", factFind.Id);
            ViewBag.Id = new SelectList(db.PageFives, "Id", "ClientOneIncomeNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageFours, "Id", "Id", factFind.Id);
            ViewBag.Id = new SelectList(db.PageNines, "Id", "ClientOnePrioritiesNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageOnes, "Id", "ClientOneForename", factFind.Id);
            ViewBag.Id = new SelectList(db.PageSevens, "Id", "AssetsNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageSixs, "Id", "OutGoingsNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageTens, "Id", "ExistingPlansNotes", factFind.Id);
            ViewBag.Id = new SelectList(db.PageThrees, "Id", "ClientOneSolicitor", factFind.Id);
            ViewBag.Id = new SelectList(db.PageTwos, "Id", "ClientOneOccupation", factFind.Id);
            return View(factFind);
        }

        // GET: FactFinds/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var factFind = await db.FactFinds.FindAsync(id);
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
            var factFind = await db.FactFinds.FindAsync(id);
            db.FactFinds.Remove(factFind);
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
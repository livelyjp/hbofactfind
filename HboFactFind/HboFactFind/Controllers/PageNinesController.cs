using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageNinesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageNines
        public async Task<ActionResult> Index()
        {
            var pageNines = db.PageNines.Include(p => p.FactFind);
            return View(await pageNines.ToListAsync());
        }

        // GET: PageNines/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageNine = await db.PageNines.FindAsync(id);
            if (pageNine == null)
            {
                return HttpNotFound();
            }
            return View(pageNine);
        }

        // GET: PageNines/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageNines/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOnePersonalProtectionPriority,ClientOnePensionPlanningPriority,ClientOneOptionsAtRetirementPriority,ClientOneSavingsAndInvestmentsPriority,ClientOneEstatePlanningPriority,ClientOneMortgageNeedsPriority,ClientOneEquityReleasePriority,ClientOneLongTermCarePriority,ClientOneGeneralInsuranceNeedsPriority,ClientOnePrioritiesNotes,ClientTwoPersonalProtectionPriority,ClientTwoPensionPlanningPriority,ClientTwoOptionsAtRetirementPriority,ClientTwoSavingsAndInvestmentsPriority,ClientTwoEstatePlanningPriority,ClientTwoMortgageNeedsPriority,ClientTwoEquityReleasePriority,ClientTwoLongTermCarePriority,ClientTwoGeneralInsuranceNeedsPriority,ClientTwoPrioritiesNotes,FactFindId,CreatedDateTime"
                )] PageNine pageNine)
        {
            if (ModelState.IsValid)
            {
                db.PageNines.Add(pageNine);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageNine.FactFindId);
            return View(pageNine);
        }

        // GET: PageNines/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageNine = await db.PageNines.FindAsync(id);
            if (pageNine == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageNine.FactFindId);
            return View(pageNine);
        }

        // POST: PageNines/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOnePersonalProtectionPriority,ClientOnePensionPlanningPriority,ClientOneOptionsAtRetirementPriority,ClientOneSavingsAndInvestmentsPriority,ClientOneEstatePlanningPriority,ClientOneMortgageNeedsPriority,ClientOneEquityReleasePriority,ClientOneLongTermCarePriority,ClientOneGeneralInsuranceNeedsPriority,ClientOnePrioritiesNotes,ClientTwoPersonalProtectionPriority,ClientTwoPensionPlanningPriority,ClientTwoOptionsAtRetirementPriority,ClientTwoSavingsAndInvestmentsPriority,ClientTwoEstatePlanningPriority,ClientTwoMortgageNeedsPriority,ClientTwoEquityReleasePriority,ClientTwoLongTermCarePriority,ClientTwoGeneralInsuranceNeedsPriority,ClientTwoPrioritiesNotes,FactFindId,CreatedDateTime"
                )] PageNine pageNine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageNine).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageNine.FactFindId);
            return View(pageNine);
        }

        // GET: PageNines/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageNine = await db.PageNines.FindAsync(id);
            if (pageNine == null)
            {
                return HttpNotFound();
            }
            return View(pageNine);
        }

        // POST: PageNines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageNine = await db.PageNines.FindAsync(id);
            db.PageNines.Remove(pageNine);
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
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageNineController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageNines.ToListAsync());
        }

        // GET: PageNines/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageNine = await _db.PageNines.FindAsync(id);
            if (pageNine == null)
            {
                return HttpNotFound();
            }
            return View(pageNine);
        }

        // GET: PageNines/Edit/5
        [Route("~/FactFind/PageNine/{factFindId}", Name = "PageNine")]
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

            var page = await _db.PageNines.FirstAsync(x => x.Id == factFind.PageNineId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageNines/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageNine/{factFindId}")]
        public async Task<ActionResult> Edit(
           [Bind(Include = "Id,ClientOnePersonalProtectionPriority,ClientOnePensionPlanningPriority,ClientOneOptionsAtRetirementPriority,ClientOneSavingsAndInvestmentsPriority,ClientOneEstatePlanningPriority,ClientOneMortgageNeedsPriority,ClientOneEquityReleasePriority,ClientOneLongTermCarePriority,ClientOneGeneralInsuranceNeedsPriority,ClientOnePrioritiesNotes,ClientTwoPersonalProtectionPriority,ClientTwoPensionPlanningPriority,ClientTwoOptionsAtRetirementPriority,ClientTwoSavingsAndInvestmentsPriority,ClientTwoEstatePlanningPriority,ClientTwoMortgageNeedsPriority,ClientTwoEquityReleasePriority,ClientTwoLongTermCarePriority,ClientTwoGeneralInsuranceNeedsPriority,ClientTwoPrioritiesNotes,CreatedDateTime")] PageNine pageNine)
        {
            if (!ModelState.IsValid) return View(pageNine);
            _db.Entry(pageNine).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageTen");
        }

        // GET: PageNines/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageNine = await _db.PageNines.FindAsync(id);
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
            var pageNine = await _db.PageNines.FindAsync(id);
            _db.PageNines.Remove(pageNine);
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
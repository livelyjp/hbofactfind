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
    public class PageFiveController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageFives.ToListAsync());
        }

        // GET: PageFives/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await _db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            return View(pageFive);
        }

        // GET: PageFives/Edit/5
        [Route("~/FactFind/PageFive/{factFindId}", Name = "PageFive")]
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

            var page = await _db.PageFives.FirstAsync(x => x.Id == factFind.PageFiveId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageFives/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageFive/{factFindId}")]
        public async Task<ActionResult> Edit(
           [Bind(Include = "Id,ClientOneGrossEmploymentIncome,ClientOneGrossSelfEmploymentIncome,ClientOneGrossPrivatePensionIncome,ClientOneGrossStatePension,ClientOneAdditionalIncome,ClientOneTotalAnnualIncome,ClientOneTotalGrossMonthlyIncome,ClientOneTotalNetMonthlyIncome,ClientOneTaxRate,ClientOneAnyChangesToIncome,ClientOneAnyChangesToTax,ClientOneIncomeNotes,ClientTwoGrossEmploymentIncome,ClientTwoGrossSelfEmploymentIncome,ClientTwoGrossPrivatePensionIncome,ClientTwoGrossStatePension,ClientTwoAdditionalIncome,ClientTwoTotalAnnualIncome,ClientTwoTotalGrossMonthlyIncome,ClientTwoTotalNetMonthlyIncome,ClientTwoTaxRate,ClientTwoAnyChangesToIncome,ClientTwoAnyChangesToTax,ClientTwoIncomeNotes,CreatedDateTime")] PageFive pageFive)
        {
            if (!ModelState.IsValid) return View(pageFive);
            _db.Entry(pageFive).State = EntityState.Modified;

            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageSix");
        }

        // GET: PageFives/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await _db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            return View(pageFive);
        }

        // POST: PageFives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageFive = await _db.PageFives.FindAsync(id);
            _db.PageFives.Remove(pageFive);
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
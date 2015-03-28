using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageSixController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageSixs.ToListAsync());
        }

        // GET: PageSixs/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSix = await _db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // GET: PageSixs/Edit/5
        [Route("~/FactFind/PageSix/{factFindId}", Name = "PageSix")]
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

            var page = await _db.PageSixs.FirstAsync(x => x.Id == factFind.PageSixId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageSixs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageSix/{factFindId}")]
        public async Task<ActionResult> Edit(
           [Bind(Include = "Id,ClientOneMortageRent,ClientOneCouncilTax,ClientOneUtilities,ClientOneFoodShopping,ClientOneTvSateliteCableInternet,ClientOnePhone,ClientOneTransportation,ClientOneFinancials,ClientOneLoansCreditStoreCardRepayments,ClientOneSavings,ClientOneInsurance,ClientOnePensionContributions,ClientOneMiscellaneious,ClientOneHolidays,ClientOneRegularSubscriptions,ClientOneClothing,ClientOneOther,ClientOneTotalOutgoings,ClientOneSurplusIncome,ClientOneFinancialGoalCommitment,ClientTwoMortageRent,ClientTwoCouncilTax,ClientTwoUtilities,ClientTwoFoodShopping,ClientTwoTvSateliteCableInternet,ClientTwoPhone,ClientTwoTransportation,ClientTwoFinancials,ClientTwoLoansCreditStoreCardRepayments,ClientTwoSavings,ClientTwoInsurance,ClientTwoPensionContributions,ClientTwoMiscellaneious,ClientTwoHolidays,ClientTwoRegularSubscriptions,ClientTwoClothing,ClientTwoOther,ClientTwoTotalOutgoings,ClientTwoSurplusIncome,ClientTwoFinancialGoalCommitment,OutGoingsNotes,CreatedDateTime")] PageSix pageSix)
        {
            if (!ModelState.IsValid) return View(pageSix);
            _db.Entry(pageSix).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageSeven");
        }

        // GET: PageSixs/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSix = await _db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // POST: PageSixs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageSix = await _db.PageSixs.FindAsync(id);
            _db.PageSixs.Remove(pageSix);
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
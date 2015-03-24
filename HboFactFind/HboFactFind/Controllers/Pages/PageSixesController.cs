using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers.Pages
{
    public class PageSixesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageSixes
        public async Task<ActionResult> Index()
        {
            var pageSixs = db.PageSixs.Include(p => p.FactFind);
            return View(await pageSixs.ToListAsync());
        }

        // GET: PageSixes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSix = await db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // GET: PageSixes/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageSixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneMortageRent,ClientOneCouncilTax,ClientOneUtilities,ClientOneFoodShopping,ClientOneTvSateliteCableInternet,ClientOnePhone,ClientOneTransportation,ClientOneFinancials,ClientOneLoansCreditStoreCardRepayments,ClientOneSavings,ClientOneInsurance,ClientOnePensionContributions,ClientOneMiscellaneious,ClientOneHolidays,ClientOneRegularSubscriptions,ClientOneClothing,ClientOneOther,ClientOneTotalOutgoings,ClientOneSurplusIncome,ClientOneFinancialGoalCommitment,ClientTwoMortageRent,ClientTwoCouncilTax,ClientTwoUtilities,ClientTwoFoodShopping,ClientTwoTvSateliteCableInternet,ClientTwoPhone,ClientTwoTransportation,ClientTwoFinancials,ClientTwoLoansCreditStoreCardRepayments,ClientTwoSavings,ClientTwoInsurance,ClientTwoPensionContributions,ClientTwoMiscellaneious,ClientTwoHolidays,ClientTwoRegularSubscriptions,ClientTwoClothing,ClientTwoOther,ClientTwoTotalOutgoings,ClientTwoSurplusIncome,ClientTwoFinancialGoalCommitment,OutGoingsNotes,FactFindId,CreatedDateTime"
                )] PageSix pageSix)
        {
            if (ModelState.IsValid)
            {
                db.PageSixs.Add(pageSix);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSix.FactFindId);
            return View(pageSix);
        }

        // GET: PageSixes/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSix = await db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSix.FactFindId);
            return View(pageSix);
        }

        // POST: PageSixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneMortageRent,ClientOneCouncilTax,ClientOneUtilities,ClientOneFoodShopping,ClientOneTvSateliteCableInternet,ClientOnePhone,ClientOneTransportation,ClientOneFinancials,ClientOneLoansCreditStoreCardRepayments,ClientOneSavings,ClientOneInsurance,ClientOnePensionContributions,ClientOneMiscellaneious,ClientOneHolidays,ClientOneRegularSubscriptions,ClientOneClothing,ClientOneOther,ClientOneTotalOutgoings,ClientOneSurplusIncome,ClientOneFinancialGoalCommitment,ClientTwoMortageRent,ClientTwoCouncilTax,ClientTwoUtilities,ClientTwoFoodShopping,ClientTwoTvSateliteCableInternet,ClientTwoPhone,ClientTwoTransportation,ClientTwoFinancials,ClientTwoLoansCreditStoreCardRepayments,ClientTwoSavings,ClientTwoInsurance,ClientTwoPensionContributions,ClientTwoMiscellaneious,ClientTwoHolidays,ClientTwoRegularSubscriptions,ClientTwoClothing,ClientTwoOther,ClientTwoTotalOutgoings,ClientTwoSurplusIncome,ClientTwoFinancialGoalCommitment,OutGoingsNotes,FactFindId,CreatedDateTime"
                )] PageSix pageSix)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageSix).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSix.FactFindId);
            return View(pageSix);
        }

        // GET: PageSixes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSix = await db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // POST: PageSixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageSix = await db.PageSixs.FindAsync(id);
            db.PageSixs.Remove(pageSix);
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
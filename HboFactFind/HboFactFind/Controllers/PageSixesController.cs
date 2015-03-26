using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageSixesController : Controller
    {
        private HboDbContext db = new HboDbContext();

        // GET: PageSixes
        public async Task<ActionResult> Index()
        {
            return View(await db.PageSixs.ToListAsync());
        }

        // GET: PageSixes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageSix pageSix = await db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // GET: PageSixes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PageSixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,ClientOneMortageRent,ClientOneCouncilTax,ClientOneUtilities,ClientOneFoodShopping,ClientOneTvSateliteCableInternet,ClientOnePhone,ClientOneTransportation,ClientOneFinancials,ClientOneLoansCreditStoreCardRepayments,ClientOneSavings,ClientOneInsurance,ClientOnePensionContributions,ClientOneMiscellaneious,ClientOneHolidays,ClientOneRegularSubscriptions,ClientOneClothing,ClientOneOther,ClientOneTotalOutgoings,ClientOneSurplusIncome,ClientOneFinancialGoalCommitment,ClientTwoMortageRent,ClientTwoCouncilTax,ClientTwoUtilities,ClientTwoFoodShopping,ClientTwoTvSateliteCableInternet,ClientTwoPhone,ClientTwoTransportation,ClientTwoFinancials,ClientTwoLoansCreditStoreCardRepayments,ClientTwoSavings,ClientTwoInsurance,ClientTwoPensionContributions,ClientTwoMiscellaneious,ClientTwoHolidays,ClientTwoRegularSubscriptions,ClientTwoClothing,ClientTwoOther,ClientTwoTotalOutgoings,ClientTwoSurplusIncome,ClientTwoFinancialGoalCommitment,OutGoingsNotes,CreatedDateTime")] PageSix pageSix)
        {
            if (ModelState.IsValid)
            {
                db.PageSixs.Add(pageSix);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(pageSix);
        }

        // GET: PageSixes/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageSix pageSix = await db.PageSixs.FindAsync(id);
            if (pageSix == null)
            {
                return HttpNotFound();
            }
            return View(pageSix);
        }

        // POST: PageSixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,ClientOneMortageRent,ClientOneCouncilTax,ClientOneUtilities,ClientOneFoodShopping,ClientOneTvSateliteCableInternet,ClientOnePhone,ClientOneTransportation,ClientOneFinancials,ClientOneLoansCreditStoreCardRepayments,ClientOneSavings,ClientOneInsurance,ClientOnePensionContributions,ClientOneMiscellaneious,ClientOneHolidays,ClientOneRegularSubscriptions,ClientOneClothing,ClientOneOther,ClientOneTotalOutgoings,ClientOneSurplusIncome,ClientOneFinancialGoalCommitment,ClientTwoMortageRent,ClientTwoCouncilTax,ClientTwoUtilities,ClientTwoFoodShopping,ClientTwoTvSateliteCableInternet,ClientTwoPhone,ClientTwoTransportation,ClientTwoFinancials,ClientTwoLoansCreditStoreCardRepayments,ClientTwoSavings,ClientTwoInsurance,ClientTwoPensionContributions,ClientTwoMiscellaneious,ClientTwoHolidays,ClientTwoRegularSubscriptions,ClientTwoClothing,ClientTwoOther,ClientTwoTotalOutgoings,ClientTwoSurplusIncome,ClientTwoFinancialGoalCommitment,OutGoingsNotes,CreatedDateTime")] PageSix pageSix)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageSix).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pageSix);
        }

        // GET: PageSixes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PageSix pageSix = await db.PageSixs.FindAsync(id);
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
            PageSix pageSix = await db.PageSixs.FindAsync(id);
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

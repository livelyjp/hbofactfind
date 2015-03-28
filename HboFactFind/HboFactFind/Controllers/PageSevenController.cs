using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageSevenController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageSevens.ToListAsync());
        }

        // GET: PageSevens/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSeven = await _db.PageSevens.FindAsync(id);
            if (pageSeven == null)
            {
                return HttpNotFound();
            }
            return View(pageSeven);
        }

        // GET: PageSevens/Edit/5
        [Route("~/FactFind/PageSeven/{factFindId}")]
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

            var page = await _db.PageSevens.FirstAsync(x => x.Id == factFind.PageSevenId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageSevens/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageSeven/{factFindId}")]
        public async Task<ActionResult> Edit(
            [Bind(Include = "Id,ClientOneHome,ClientOneOtherProperty,ClientOneCashDeposits,ClientOneInvestmentBonds,ClientOnePensionFunds,ClientOneIsa,ClientOneCollectives,ClientOneShares,ClientOneBuisnessAssets,ClientOneOtherAssets,ClientOneTotalAssets,ClientOneMainMortgage,ClientOneCreditCards,ClientOneOverdraft,ClientOneLoansHp,ClientOneOtherMortgage,ClientOneOtherLending,ClientOneTotalDebt,ClientTwoHome,ClientTwoOtherProperty,ClientTwoCashDeposits,ClientTwoInvestmentBonds,ClientTwoPensionFunds,ClientTwoIsa,ClientTwoCollectives,ClientTwoShares,ClientTwoBuisnessAssets,ClientTwoOtherAssets,ClientTwoTotalAssets,ClientTwoMainMortgage,ClientTwoCreditCards,ClientTwoOverdraft,ClientTwoLoansHp,ClientTwoOtherMortgage,ClientTwoOtherLending,ClientTwoTotalDebt,AssetsNotes,CreatedDateTime")] PageSeven pageSeven)
        {
            if (!ModelState.IsValid) return View(pageSeven);
            _db.Entry(pageSeven).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Edit", "PageEight");
        }

        // GET: PageSevens/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSeven = await _db.PageSevens.FindAsync(id);
            if (pageSeven == null)
            {
                return HttpNotFound();
            }
            return View(pageSeven);
        }

        // POST: PageSevens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageSeven = await _db.PageSevens.FindAsync(id);
            _db.PageSevens.Remove(pageSeven);
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
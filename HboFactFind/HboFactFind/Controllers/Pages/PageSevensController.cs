using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers.Pages
{
    public class PageSevensController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageSevens
        public async Task<ActionResult> Index()
        {
            var pageSevens = db.PageSevens.Include(p => p.FactFind);
            return View(await pageSevens.ToListAsync());
        }

        // GET: PageSevens/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSeven = await db.PageSevens.FindAsync(id);
            if (pageSeven == null)
            {
                return HttpNotFound();
            }
            return View(pageSeven);
        }

        // GET: PageSevens/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageSevens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneHome,ClientOneOtherProperty,ClientOneCashDeposits,ClientOneInvestmentBonds,ClientOnePensionFunds,ClientOneIsa,ClientOneCollectives,ClientOneShares,ClientOneBuisnessAssets,ClientOneOtherAssets,ClientOneTotalAssets,ClientOneMainMortgage,ClientOneCreditCards,ClientOneOverdraft,ClientOneLoansHp,ClientOneOtherMortgage,ClientOneOtherLending,ClientOneTotalDebt,ClientTwoHome,ClientTwoOtherProperty,ClientTwoCashDeposits,ClientTwoInvestmentBonds,ClientTwoPensionFunds,ClientTwoIsa,ClientTwoCollectives,ClientTwoShares,ClientTwoBuisnessAssets,ClientTwoOtherAssets,ClientTwoTotalAssets,ClientTwoMainMortgage,ClientTwoCreditCards,ClientTwoOverdraft,ClientTwoLoansHp,ClientTwoOtherMortgage,ClientTwoOtherLending,ClientTwoTotalDebt,AssetsNotes,FactFindId,CreatedDateTime"
                )] PageSeven pageSeven)
        {
            if (ModelState.IsValid)
            {
                db.PageSevens.Add(pageSeven);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSeven.FactFindId);
            return View(pageSeven);
        }

        // GET: PageSevens/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSeven = await db.PageSevens.FindAsync(id);
            if (pageSeven == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSeven.FactFindId);
            return View(pageSeven);
        }

        // POST: PageSevens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneHome,ClientOneOtherProperty,ClientOneCashDeposits,ClientOneInvestmentBonds,ClientOnePensionFunds,ClientOneIsa,ClientOneCollectives,ClientOneShares,ClientOneBuisnessAssets,ClientOneOtherAssets,ClientOneTotalAssets,ClientOneMainMortgage,ClientOneCreditCards,ClientOneOverdraft,ClientOneLoansHp,ClientOneOtherMortgage,ClientOneOtherLending,ClientOneTotalDebt,ClientTwoHome,ClientTwoOtherProperty,ClientTwoCashDeposits,ClientTwoInvestmentBonds,ClientTwoPensionFunds,ClientTwoIsa,ClientTwoCollectives,ClientTwoShares,ClientTwoBuisnessAssets,ClientTwoOtherAssets,ClientTwoTotalAssets,ClientTwoMainMortgage,ClientTwoCreditCards,ClientTwoOverdraft,ClientTwoLoansHp,ClientTwoOtherMortgage,ClientTwoOtherLending,ClientTwoTotalDebt,AssetsNotes,FactFindId,CreatedDateTime"
                )] PageSeven pageSeven)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageSeven).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageSeven.FactFindId);
            return View(pageSeven);
        }

        // GET: PageSevens/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageSeven = await db.PageSevens.FindAsync(id);
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
            var pageSeven = await db.PageSevens.FindAsync(id);
            db.PageSevens.Remove(pageSeven);
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
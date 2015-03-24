using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubSections
{
    public class SavingsAndInvestmentPoliciesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: SavingsAndInvestmentPolicies
        public async Task<ActionResult> Index()
        {
            var savingsAndInvestmentPolicieses = db.SavingsAndInvestmentPolicieses.Include(s => s.PageTen);
            return View(await savingsAndInvestmentPolicieses.ToListAsync());
        }

        // GET: SavingsAndInvestmentPolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes");
            return View();
        }

        // POST: SavingsAndInvestmentPolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,Contrbution,Frequency,InTrust,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] SavingsAndInvestmentPolicies savingsAndInvestmentPolicies)
        {
            if (ModelState.IsValid)
            {
                db.SavingsAndInvestmentPolicieses.Add(savingsAndInvestmentPolicies);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                savingsAndInvestmentPolicies.PageTenId);
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                savingsAndInvestmentPolicies.PageTenId);
            return View(savingsAndInvestmentPolicies);
        }

        // POST: SavingsAndInvestmentPolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,Contrbution,Frequency,InTrust,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] SavingsAndInvestmentPolicies savingsAndInvestmentPolicies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(savingsAndInvestmentPolicies).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                savingsAndInvestmentPolicies.PageTenId);
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            return View(savingsAndInvestmentPolicies);
        }

        // POST: SavingsAndInvestmentPolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var savingsAndInvestmentPolicies = await db.SavingsAndInvestmentPolicieses.FindAsync(id);
            db.SavingsAndInvestmentPolicieses.Remove(savingsAndInvestmentPolicies);
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
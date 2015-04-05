using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubForms
{
    [Authentication]
    public class SavingsAndInvestmentPoliciesController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: SavingsAndInvestmentPolicies
        public async Task<ActionResult> Index()
        {
            var savingsAndInvestmentPolicieses = _db.SavingsAndInvestmentPolicieses.Include(s => s.PageTen);
            return View(await savingsAndInvestmentPolicieses.ToListAsync());
        }

        // GET: SavingsAndInvestmentPolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await _db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes");
            return View();
        }

        // POST: SavingsAndInvestmentPolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,Contrbution,Frequency,InTrust,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] SavingsAndInvestmentPolicies savingsAndInvestmentPolicies)
        {
            if (ModelState.IsValid)
            {
                _db.SavingsAndInvestmentPolicieses.Add(savingsAndInvestmentPolicies);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", savingsAndInvestmentPolicies.PageTenId);
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await _db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", savingsAndInvestmentPolicies.PageTenId);
            return PartialView("Partials/_SavingsEdit", savingsAndInvestmentPolicies);

        }

        // POST: SavingsAndInvestmentPolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,Contrbution,Frequency,InTrust,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] SavingsAndInvestmentPolicies savingsAndInvestmentPolicies)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(savingsAndInvestmentPolicies).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", savingsAndInvestmentPolicies.PageTenId);
            return View(savingsAndInvestmentPolicies);
        }

        // GET: SavingsAndInvestmentPolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var savingsAndInvestmentPolicies = await _db.SavingsAndInvestmentPolicieses.FindAsync(id);
            if (savingsAndInvestmentPolicies == null)
            {
                return HttpNotFound();
            }
            return PartialView("Partials/_SavingsDelete", savingsAndInvestmentPolicies);
        }

        // POST: SavingsAndInvestmentPolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var savingsAndInvestmentPolicies = await _db.SavingsAndInvestmentPolicieses.FindAsync(id);
            _db.SavingsAndInvestmentPolicieses.Remove(savingsAndInvestmentPolicies);
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
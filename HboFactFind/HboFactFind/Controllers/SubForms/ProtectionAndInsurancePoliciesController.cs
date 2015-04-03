using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubForms
{
    public class ProtectionAndInsurancePoliciesController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: ProtectionAndInsurancePolicies
        public async Task<ActionResult> Index()
        {
            var protectionAndInsurancePolicieses = _db.ProtectionAndInsurancePolicieses.Include(p => p.PageTen);
            return View(await protectionAndInsurancePolicieses.ToListAsync());
        }

        // GET: ProtectionAndInsurancePolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await _db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes");
            return View();
        }

        // POST: ProtectionAndInsurancePolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,GrossPremium,PremiumFrequency,Waiver,InTrust,Term,LifeCover,CICCover,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] ProtectionAndInsurancePolicies protectionAndInsurancePolicies)
        {
            if (ModelState.IsValid)
            {
                _db.ProtectionAndInsurancePolicieses.Add(protectionAndInsurancePolicies);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", protectionAndInsurancePolicies.PageTenId);
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await _db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", protectionAndInsurancePolicies.PageTenId);
            return PartialView("Partials/_ProtectionEdit", protectionAndInsurancePolicies);

        }

        // POST: ProtectionAndInsurancePolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,GrossPremium,PremiumFrequency,Waiver,InTrust,Term,LifeCover,CICCover,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] ProtectionAndInsurancePolicies protectionAndInsurancePolicies)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(protectionAndInsurancePolicies).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", protectionAndInsurancePolicies.PageTenId);
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await _db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            return PartialView("Partials/_ProtectionDelete", protectionAndInsurancePolicies);

        }

        // POST: ProtectionAndInsurancePolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var protectionAndInsurancePolicies = await _db.ProtectionAndInsurancePolicieses.FindAsync(id);
            _db.ProtectionAndInsurancePolicieses.Remove(protectionAndInsurancePolicies);
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
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubSections
{
    public class ProtectionAndInsurancePoliciesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: ProtectionAndInsurancePolicies
        public async Task<ActionResult> Index()
        {
            var protectionAndInsurancePolicieses = db.ProtectionAndInsurancePolicieses.Include(p => p.PageTen);
            return View(await protectionAndInsurancePolicieses.ToListAsync());
        }

        // GET: ProtectionAndInsurancePolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes");
            return View();
        }

        // POST: ProtectionAndInsurancePolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,GrossPremium,PremiumFrequency,Waiver,InTrust,Term,LifeCover,CICCover,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] ProtectionAndInsurancePolicies protectionAndInsurancePolicies)
        {
            if (ModelState.IsValid)
            {
                db.ProtectionAndInsurancePolicieses.Add(protectionAndInsurancePolicies);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                protectionAndInsurancePolicies.PageTenId);
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                protectionAndInsurancePolicies.PageTenId);
            return View(protectionAndInsurancePolicies);
        }

        // POST: ProtectionAndInsurancePolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,GrossPremium,PremiumFrequency,Waiver,InTrust,Term,LifeCover,CICCover,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] ProtectionAndInsurancePolicies protectionAndInsurancePolicies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(protectionAndInsurancePolicies).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes",
                protectionAndInsurancePolicies.PageTenId);
            return View(protectionAndInsurancePolicies);
        }

        // GET: ProtectionAndInsurancePolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var protectionAndInsurancePolicies = await db.ProtectionAndInsurancePolicieses.FindAsync(id);
            if (protectionAndInsurancePolicies == null)
            {
                return HttpNotFound();
            }
            return View(protectionAndInsurancePolicies);
        }

        // POST: ProtectionAndInsurancePolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var protectionAndInsurancePolicies = await db.ProtectionAndInsurancePolicieses.FindAsync(id);
            db.ProtectionAndInsurancePolicieses.Remove(protectionAndInsurancePolicies);
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
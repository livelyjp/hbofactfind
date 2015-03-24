using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubSections
{
    public class PensionPoliciesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PensionPolicies
        public async Task<ActionResult> Index()
        {
            var pensionPolicieses = db.PensionPolicieses.Include(p => p.PageTen);
            return View(await pensionPolicieses.ToListAsync());
        }

        // GET: PensionPolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes");
            return View();
        }

        // POST: PensionPolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,Contribution,Frequency,Pci,AdditionalLifeCover,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] PensionPolicies pensionPolicies)
        {
            if (ModelState.IsValid)
            {
                db.PensionPolicieses.Add(pensionPolicies);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes", pensionPolicies.PageTenId);
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes", pensionPolicies.PageTenId);
            return View(pensionPolicies);
        }

        // POST: PensionPolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,Contribution,Frequency,Pci,AdditionalLifeCover,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] PensionPolicies pensionPolicies)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pensionPolicies).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(db.PageTens, "Id", "ExistingPlansNotes", pensionPolicies.PageTenId);
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            return View(pensionPolicies);
        }

        // POST: PensionPolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pensionPolicies = await db.PensionPolicieses.FindAsync(id);
            db.PensionPolicieses.Remove(pensionPolicies);
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
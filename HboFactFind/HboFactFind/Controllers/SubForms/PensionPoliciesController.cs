using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Questions.ExistingPlans;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubForms
{
    public class PensionPoliciesController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: PensionPolicies
        public async Task<ActionResult> Index()
        {
            var pensionPolicieses = _db.PensionPolicieses.Include(p => p.PageTen);
            return View(await pensionPolicieses.ToListAsync());
        }

        // GET: PensionPolicies/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await _db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Create
        public ActionResult Create()
        {
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes");
            return View();
        }

        // POST: PensionPolicies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,Contribution,Frequency,Pci,AdditionalLifeCover,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] PensionPolicies pensionPolicies)
        {
            if (ModelState.IsValid)
            {
                _db.PensionPolicieses.Add(pensionPolicies);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", pensionPolicies.PageTenId);
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await _db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", pensionPolicies.PageTenId);
            return PartialView("Partials/_PensionEdit", pensionPolicies);

        }

        // POST: PensionPolicies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,Contribution,Frequency,Pci,AdditionalLifeCover,LastValuation,PageTenId,Owner,Provider,PolicyNumber,ProductPlanType,InForce,CreatedDateTime"
                )] PensionPolicies pensionPolicies)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(pensionPolicies).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageTenId = new SelectList(_db.PageTens, "Id", "Notes", pensionPolicies.PageTenId);
            return View(pensionPolicies);
        }

        // GET: PensionPolicies/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pensionPolicies = await _db.PensionPolicieses.FindAsync(id);
            if (pensionPolicies == null)
            {
                return HttpNotFound();
            }
            return PartialView("Partials/_PensionDelete", pensionPolicies);
        }

        // POST: PensionPolicies/Delete/5
        [HttpPost, ActionName("Delete")]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pensionPolicies = await _db.PensionPolicieses.FindAsync(id);
            _db.PensionPolicieses.Remove(pensionPolicies);
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
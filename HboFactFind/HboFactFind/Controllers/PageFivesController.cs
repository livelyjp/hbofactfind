using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageFivesController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        // GET: PageFives
        public async Task<ActionResult> Index()
        {
            var pageFives = db.PageFives.Include(p => p.FactFind);
            return View(await pageFives.ToListAsync());
        }

        // GET: PageFives/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            return View(pageFive);
        }

        // GET: PageFives/Create
        public ActionResult Create()
        {
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName");
            return View();
        }

        // POST: PageFives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneGrossEmploymentIncome,ClientOneGrossSelfEmploymentIncome,ClientOneGroddPrivatePensionIncome,ClientOneGrossStatePension,ClientOneAdditionalIncome,ClientOneTotalAnnualIncome,ClientOneTotalGrossMonthlyIncome,ClientOneTotalNetMonthlyIncome,ClientOneTaxRate,ClientOneAnyChangesToIncome,ClientOneAnyChangesToTax,ClientOneIncomeNotes,ClientTwoGrossEmploymentIncome,ClientTwoGrossSelfEmploymentIncome,ClientTwoGroddPrivatePensionIncome,ClientTwoGrossStatePension,ClientTwoAdditionalIncome,ClientTwoTotalAnnualIncome,ClientTwoTotalGrossMonthlyIncome,ClientTwoTotalNetMonthlyIncome,ClientTwoTaxRate,ClientTwoAnyChangesToIncome,ClientTwoAnyChangesToTax,ClientTwoIncomeNotes,FactFindId,CreatedDateTime"
                )] PageFive pageFive)
        {
            if (ModelState.IsValid)
            {
                db.PageFives.Add(pageFive);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFive.FactFindId);
            return View(pageFive);
        }

        // GET: PageFives/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFive.FactFindId);
            return View(pageFive);
        }

        // POST: PageFives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneGrossEmploymentIncome,ClientOneGrossSelfEmploymentIncome,ClientOneGroddPrivatePensionIncome,ClientOneGrossStatePension,ClientOneAdditionalIncome,ClientOneTotalAnnualIncome,ClientOneTotalGrossMonthlyIncome,ClientOneTotalNetMonthlyIncome,ClientOneTaxRate,ClientOneAnyChangesToIncome,ClientOneAnyChangesToTax,ClientOneIncomeNotes,ClientTwoGrossEmploymentIncome,ClientTwoGrossSelfEmploymentIncome,ClientTwoGroddPrivatePensionIncome,ClientTwoGrossStatePension,ClientTwoAdditionalIncome,ClientTwoTotalAnnualIncome,ClientTwoTotalGrossMonthlyIncome,ClientTwoTotalNetMonthlyIncome,ClientTwoTaxRate,ClientTwoAnyChangesToIncome,ClientTwoAnyChangesToTax,ClientTwoIncomeNotes,FactFindId,CreatedDateTime"
                )] PageFive pageFive)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageFive).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.FactFindId = new SelectList(db.FactFinds, "Id", "ClientOneName", pageFive.FactFindId);
            return View(pageFive);
        }

        // GET: PageFives/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            return View(pageFive);
        }

        // POST: PageFives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageFive = await db.PageFives.FindAsync(id);
            db.PageFives.Remove(pageFive);
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
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Attributes;
using HboFactFind.Domain.Questions;
using HboFactFind.EF;

namespace HboFactFind.Controllers.SubForms
{
    [Authentication]
    public class BreakDownOfLiabilitiesController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();
        // GET: BreakDownOfLiabilities
        public async Task<ActionResult> Index()
        {
            var breakDownOfLiabilitieses = _db.BreakDownOfLiabilitieses.Include(b => b.PageSeven);
            return View(await breakDownOfLiabilitieses.ToListAsync());
        }

        // GET: BreakDownOfLiabilities/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var breakDownOfLiabilities = await _db.BreakDownOfLiabilitieses.FindAsync(id);
            if (breakDownOfLiabilities == null)
            {
                return HttpNotFound();
            }
            return View(breakDownOfLiabilities);
        }

        // GET: BreakDownOfLiabilities/Create
        public ActionResult Create()
        {
            ViewBag.PageSevenId = new SelectList(_db.PageSevens, "Id", "AssetsNotes");
            return View();
        }

        // POST: BreakDownOfLiabilities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,PageSevenId,MoregateLoadCreditOwner,Lender,Amount,RepaymentType,RepaymentDate,CreatedDateTime")] BreakDownOfLiabilities breakDownOfLiabilities)
        {
            if (ModelState.IsValid)
            {
                _db.BreakDownOfLiabilitieses.Add(breakDownOfLiabilities);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.PageSevenId = new SelectList(_db.PageSevens, "Id", "AssetsNotes", breakDownOfLiabilities.PageSevenId);
            return View(breakDownOfLiabilities);
        }

        // GET: BreakDownOfLiabilities/Edit/5
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var breakDownOfLiabilities = await _db.BreakDownOfLiabilitieses.FindAsync(id);
            if (breakDownOfLiabilities == null)
            {
                return HttpNotFound();
            }
            ViewBag.PageSevenId = new SelectList(_db.PageSevens, "Id", "AssetsNotes", breakDownOfLiabilities.PageSevenId);
            return PartialView("Partials/_BreakDownOfLiabilitiesEdit", breakDownOfLiabilities);

        }

        // POST: BreakDownOfLiabilities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,PageSevenId,MoregateLoadCreditOwner,Lender,Amount,RepaymentType,RepaymentDate,CreatedDateTime")] BreakDownOfLiabilities breakDownOfLiabilities)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(breakDownOfLiabilities).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.PageSevenId = new SelectList(_db.PageSevens, "Id", "AssetsNotes", breakDownOfLiabilities.PageSevenId);
            return View(breakDownOfLiabilities);
        }

        // GET: BreakDownOfLiabilities/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var breakDownOfLiabilities = await _db.BreakDownOfLiabilitieses.FindAsync(id);
            if (breakDownOfLiabilities == null)
            {
                return HttpNotFound();
            }
            return PartialView("Partials/_BreakDownOfLiabilitiesDelete", breakDownOfLiabilities);
        }

        // POST: BreakDownOfLiabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [AjaxValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var breakDownOfLiabilities = await _db.BreakDownOfLiabilitieses.FindAsync(id);
            _db.BreakDownOfLiabilitieses.Remove(breakDownOfLiabilities);
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
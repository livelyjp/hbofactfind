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
            [Bind(
                Include =
                    "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo,ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone,ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth,ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence,ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename,ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty,ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth,ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber,ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency,ClientTwoExtraInformation,CreatedDateTime"
                )] PageSeven pageSeven)
        {
            if (!ModelState.IsValid) return View(pageSeven);
            _db.Entry(pageSeven).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            //var factFind = await _db.FactFinds.FindAsync(pageSeven.Id);

            //factFind.ClientOneName = string.Format("{0} {1}", pageSeven.ClientOneForename, pageSeven.ClientOneSurnames);
            //factFind.ClientTwoName = string.Format("{0} {1}", pageSeven.ClientTwoForename, pageSeven.ClientTwoSurnames);

            //_db.Entry(factFind).State = EntityState.Modified;

            return RedirectToAction("Index");
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
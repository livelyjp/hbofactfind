using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageFiveController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageFives.ToListAsync());
        }

        // GET: PageFives/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await _db.PageFives.FindAsync(id);
            if (pageFive == null)
            {
                return HttpNotFound();
            }
            return View(pageFive);
        }

        // GET: PageFives/Edit/5
        [Route("~/FactFind/PageFive/{factFindId}")]
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

            var page = await _db.PageFives.FirstAsync(x => x.Id == factFind.PageFiveId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageFives/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageFive/{factFindId}")]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo,ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone,ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth,ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence,ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename,ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty,ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth,ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber,ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency,ClientTwoExtraInformation,CreatedDateTime"
                )] PageFive pageFive)
        {
            if (!ModelState.IsValid) return View(pageFive);
            _db.Entry(pageFive).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            //var factFind = await _db.FactFinds.FindAsync(pageFive.Id);

            //factFind.ClientOneName = string.Format("{0} {1}", pageFive.ClientOneForename, pageFive.ClientOneSurnames);
            //factFind.ClientTwoName = string.Format("{0} {1}", pageFive.ClientTwoForename, pageFive.ClientTwoSurnames);

            //_db.Entry(factFind).State = EntityState.Modified;

            return RedirectToAction("Index");
        }

        // GET: PageFives/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageFive = await _db.PageFives.FindAsync(id);
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
            var pageFive = await _db.PageFives.FindAsync(id);
            _db.PageFives.Remove(pageFive);
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
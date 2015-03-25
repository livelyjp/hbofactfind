using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageOneController : Controller
    {
        private readonly HboDbContext _db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await _db.PageOnes.ToListAsync());
        }

        // GET: PageOnes/Details/5
        public async Task<ActionResult> Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageOne = await _db.PageOnes.FindAsync(id);
            if (pageOne == null)
            {
                return HttpNotFound();
            }
            return View(pageOne);
        }

        // GET: PageOnes/Edit/5
        [Route("~/FactFind/PageOne/{factFindId}")]
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

            var page = await _db.PageOnes.FirstAsync(x => x.Id == factFind.PageOneId);

            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: PageOnes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageOne/{factFindId}")]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo,ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone,ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth,ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence,ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename,ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty,ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth,ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber,ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency,ClientTwoExtraInformation,CreatedDateTime"
                )] PageOne pageOne)
        {
            if (!ModelState.IsValid) return View(pageOne);
            _db.Entry(pageOne).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            //var factFind = await _db.FactFinds.FindAsync(pageOne.Id);

            //factFind.ClientOneName = string.Format("{0} {1}", pageOne.ClientOneForename, pageOne.ClientOneSurnames);
            //factFind.ClientTwoName = string.Format("{0} {1}", pageOne.ClientTwoForename, pageOne.ClientTwoSurnames);

            //_db.Entry(factFind).State = EntityState.Modified;

            return RedirectToAction("Index");
        }

        // GET: PageOnes/Delete/5
        public async Task<ActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageOne = await _db.PageOnes.FindAsync(id);
            if (pageOne == null)
            {
                return HttpNotFound();
            }
            return View(pageOne);
        }

        // POST: PageOnes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long id)
        {
            var pageOne = await _db.PageOnes.FindAsync(id);
            _db.PageOnes.Remove(pageOne);
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
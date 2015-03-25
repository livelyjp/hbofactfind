using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using HboFactFind.Domain.Pages;
using HboFactFind.EF;

namespace HboFactFind.Controllers
{
    public class PageOneController : Controller
    {
        private readonly HboDbContext db = new HboDbContext();

        public async Task<ActionResult> Index()
        {
            return View(await db.PageOnes.ToListAsync());
        }

        // GET: PageOnes/Edit/5
        [Route("~/FactFind/PageOne/{id}")]
        public async Task<ActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pageOne = await db.PageOnes.FindAsync(id);
            if (pageOne == null)
            {
                return HttpNotFound();
            }
            return View(pageOne);
        }

        // POST: PageOnes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageOne/{id}")]
        public async Task<ActionResult> Edit(
            [Bind(
                Include =
                    "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo,ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone,ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth,ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence,ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename,ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty,ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth,ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber,ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency,ClientTwoExtraInformation,CreatedDateTime"
                )] PageOne pageOne)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pageOne).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pageOne);
        }



        //[Route("~/FactFind/PageOne/{id}")]
        //public ActionResult Create(int id)
        //{
        //    if (db.FactFinds.Any(x => x.Id.Equals(id))) return RedirectToAction("Index", "FactFind");
        //    ViewBag.PageId = id;
        //    return View("Create");
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Route("~/FactFind/PageOne/{id}")]
        //public async Task<ActionResult> Create(
        //    [Bind(
        //        Include =
        //            "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo," +
        //            "ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone," +
        //            "ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth," +
        //            "ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence," +
        //            "ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename," +
        //            "ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty," +
        //            "ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth," +
        //            "ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber," +
        //            "ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency," +
        //            "ClientTwoExtraInformation,CreatedDateTime"
        //        )] PageOne pageOne)
        //{
        //    if (!ModelState.IsValid) return View("Create", pageOne);

        //    db.PageOnes.Add(pageOne);
        //    await db.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
    }
}
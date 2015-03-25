using System.Data.Entity;
using System.Linq;
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

        [Route("~/FactFind/PageOne/{id}")]
        public ActionResult Create(int id)
        {
            if (db.FactFinds.Any(x => x.Id.Equals(id))) return RedirectToAction("Index", "FactFind");
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("~/FactFind/PageOne/{id}")]
        public async Task<ActionResult> Create(
            [Bind(
                Include =
                    "Id,ClientOneTitle,ClientOneForename,ClientOneSurnames,ClientOneAddressLineOne,ClientOneAddressLineTwo," +
                    "ClientOneAddressLineThree,ClientOneCounty,ClientOnePostCode,ClientOneEmailAddress,ClientOneHomeTelephone," +
                    "ClientOneMobileTelephone,ClientOneDateOfBirth,ClientOneSex,ClientOneMartialStatus,ClientOneGoodHealth," +
                    "ClientOneSmoked,ClientOneNationalInsuranceNumber,ClientOneNationality,ClientOneCountryOfBirth,ClientOneCountryOfResidence," +
                    "ClientOneDomicile,ClientOneTaxationResidency,ClientOneExtraInformation,ClientTwoTitle,ClientTwoForename," +
                    "ClientTwoSurnames,ClientTwoAddressLineOne,ClientTwoAddressLineTwo,ClientTwoAddressLineThree,ClientTwoCounty," +
                    "ClientTwoPostCode,ClientTwoEmailAddress,ClientTwoHomeTelephone,ClientTwoMobileTelephone,ClientTwoDateOfBirth," +
                    "ClientTwoSex,ClientTwoMartialStatus,ClientTwoGoodHealth,ClientTwoSmoked,ClientTwoNationalInsuranceNumber," +
                    "ClientTwoNationality,ClientTwoCountryOfBirth,ClientTwoCountryOfResidence,ClientTwoDomicile,ClientTwoTaxationResidency," +
                    "ClientTwoExtraInformation,CreatedDateTime"
                )] PageOne pageOne)
        {
            if (!ModelState.IsValid) return View("Create", pageOne);

            db.PageOnes.Add(pageOne);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
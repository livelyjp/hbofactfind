using System.Web.Mvc;

namespace HboFactFind.Controllers
{
    public class PageOneController : Controller
    {
        // GET: PageOne
        [Route("~/FactFind/PageOne/{id}")]
        public ActionResult PageOne(int id)
        {
            return View();
        }
    }
}
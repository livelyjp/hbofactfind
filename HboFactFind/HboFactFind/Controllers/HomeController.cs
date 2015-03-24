using System.Web.Mvc;
using HboFactFind.Utils;

namespace HboFactFind.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PasswordHasher password = new PasswordHasher("793436");
            var hash = password.PasswordHash;
            var salt = password.PasswordSalt;

            password = new PasswordHasher("123abc");
            var hash1 = password.PasswordHash;
            var salt1 = password.PasswordSalt;


            return View();
        }
    }
}
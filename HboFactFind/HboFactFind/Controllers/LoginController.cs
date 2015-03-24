using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using HboFactFind.EF;
using HboFactFind.Utils;
using HboFactFind.ViewModels;

namespace HboFactFind.Controllers
{
    public class LoginController : Controller
    {
        private readonly HboDbContext _dbContext = new HboDbContext();
        //
        // GET: /Login/

        /// <summary>
        ///     Login User View
        /// </summary>
        /// <returns>Login View</returns>
        [HttpGet]
        public ActionResult Index()
        {
            if (SecurityUtil.AuthenticUser(User)) return RedirectToAction("Index", "FactFind");
            return View();
        }

        /// <summary>
        ///     Login User Post Back
        /// </summary>
        /// <param name="loginModel">User Login Form</param>
        /// <returns>Login View</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginViewModel loginModel)
        {
            if (SecurityUtil.AuthenticUser(User)) return RedirectToAction("Index", "Dashboard");
            if (ModelState.IsValid)
            {
                var existingUser = _dbContext.Users.FirstOrDefault(user => user.Id == loginModel.EmailAddress);
                if (existingUser != null)
                {
                    if (SecurityUtil.IsPasswordValid(existingUser, loginModel.Password))
                    {
                        //Password Valid
                        FormsAuthentication.SetAuthCookie(existingUser.Id.ToString(), false);
                        return RedirectToAction("Index", "Dashboard");
                    }
                }
            }
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View();
        }

        public ActionResult Signout()
        {
            if (User.Identity.IsAuthenticated) FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
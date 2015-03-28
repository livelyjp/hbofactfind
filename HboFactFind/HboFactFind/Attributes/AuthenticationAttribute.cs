using System;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace HboFactFind.Attributes
{
    public class AuthenticationAttribute : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            var user = filterContext.HttpContext.User;
            if (user == null || !user.Identity.IsAuthenticated)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }
    }
}
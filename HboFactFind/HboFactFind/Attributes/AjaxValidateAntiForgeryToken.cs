﻿using System;
using System.Net;
using System.Web.Helpers;
using System.Web.Mvc;

namespace HboFactFind.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AjaxValidateAntiForgeryToken : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var request = filterContext.HttpContext.Request;

            //  Only validate POSTs
            if (request.HttpMethod != WebRequestMethods.Http.Post) return;
            //  Ajax POSTs and normal form posts have to be treated differently when it comes
            //  to validating the AntiForgeryToken
            if (request.IsAjaxRequest())
            {
                try
                {
                    var antiForgeryCookie = request.Cookies[AntiForgeryConfig.CookieName];

                    var cookieValue = antiForgeryCookie != null
                        ? antiForgeryCookie.Value
                        : null;

                    AntiForgery.Validate(cookieValue, request.Headers["__RequestVerificationToken"]);
                }
                catch (HttpAntiForgeryException e)
                {
                    throw new HttpAntiForgeryException("Anti forgery token not found");
                }
            }
            else
            {
                new ValidateAntiForgeryTokenAttribute()
                    .OnAuthorization(filterContext);
            }
        }
    }
}
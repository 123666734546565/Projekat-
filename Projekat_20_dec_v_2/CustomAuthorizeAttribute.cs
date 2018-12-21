using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekat_20_dec_v_2
{
    [AttributeUsage( AttributeTargets.Method )]
    public class CustomAuthorizeAttribute:AuthorizeAttribute
    {
        public string ViewName { get; set; }

        public CustomAuthorizeAttribute()
        {
            ViewName = "AuthorizeFailed";
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            isUserAuthotized(filterContext);
        }


        void isUserAuthotized(AuthorizationContext filterContext)
        {

            if (filterContext.Result == null)
                return;
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                ViewDataDictionary dic = new ViewDataDictionary();
                dic.Add("Message", "Nemate pravo pristupa ovoj stranici!!");
                var result = new ViewResult() {ViewName = this.ViewName, ViewData = dic};
                filterContext.Result = result;
            }
        }
    }
}
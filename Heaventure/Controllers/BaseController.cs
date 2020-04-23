using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace Heaventure.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(
            ActionExecutingContext filterContext)
        {
            string culture = filterContext.RouteData.Values["culture"]?.ToString()
                                ?? "en";

            // Set the action parameter just in case we didn't get one
            // from the route.
            filterContext.ActionParameters["culture"] = culture;

            var cultureInfo = CultureInfo.GetCultureInfo(culture);

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Because we've overwritten the ActionParameters, we
            // make sure we provide the override to the 
            // base implementation.
            base.OnActionExecuting(filterContext);
        }

        public ActionResult RedirectToLocalized()
        {
            return RedirectPermanent("/en");
        }
    }
}
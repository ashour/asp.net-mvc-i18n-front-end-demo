using Heaventure.Data;
using System.Web.Mvc;

namespace Heaventure.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = Constellation.All();

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = Constellation.FindById(id);

            return View(model);
        }
    }
}
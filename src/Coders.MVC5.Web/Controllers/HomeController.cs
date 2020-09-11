using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Coders.MVC5.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MVC5ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
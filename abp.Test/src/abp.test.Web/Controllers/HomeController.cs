using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace abp.test.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : testControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}
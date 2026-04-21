using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using THUONGPROJECT.Controllers;

namespace THUONGPROJECT.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : THUONGPROJECTControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

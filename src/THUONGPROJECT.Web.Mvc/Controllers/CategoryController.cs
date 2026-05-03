using Microsoft.AspNetCore.Mvc;
using THUONGPROJECT.Controllers;
using THUONGPROJECT.Categories;

namespace THUONGPROJECT.Web.Controllers
{
    // Sử dụng THUONGPROJECTControllerBase để kế thừa các tính năng chung của controller
    public class CategoryController : THUONGPROJECTControllerBase
    {
        public ActionResult Index() 
        {
            return View(); // đưa về giao diện mặc định index
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace COMP003.LectureActivity5.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

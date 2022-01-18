using Microsoft.AspNetCore.Mvc;

namespace EducalProjectT210.Areas.educaladmin.Controllers
{
    public class DashBoard : Controller
    {
        [Area("EducalAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

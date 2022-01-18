using EducalProjectT210.Models;
using Microsoft.AspNetCore.Mvc;

namespace EducalProjectT210.Areas.educaladmin.Controllers
{
    [Area(nameof(educaladmin))]
    public class HorizontalController : Controller
    {
        private readonly CourseDBContext _context;
        public HorizontalController(CourseDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }
    }
}

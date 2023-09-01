using Microsoft.AspNetCore.Mvc;
using MVCNupat.Data;
using MVCNupat.Models;

namespace MVCNupat.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;

        public TeacherController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Teacher> getTeach = _db.Teachers;
            return View(getTeach);
        }
    }
}

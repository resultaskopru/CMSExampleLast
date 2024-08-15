using CMSExample.DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace MvcExample.Website.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}

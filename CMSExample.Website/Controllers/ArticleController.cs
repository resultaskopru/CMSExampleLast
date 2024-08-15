using Microsoft.AspNetCore.Mvc;
using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.UnitOfWork;
using System.Diagnostics;

namespace MvcExample.Website.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var articles = _unitOfWork.Articles.GetAll();
            return View(articles);
        }

        
    }
}



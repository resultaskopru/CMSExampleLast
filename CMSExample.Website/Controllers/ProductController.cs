using Microsoft.AspNetCore.Mvc;
using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.UnitOfWork;
using System.Diagnostics;

namespace MvcExample.Website.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var products = _unitOfWork.Products.GetAll();
            return View(products);
        }
        

    }
}



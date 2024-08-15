using Microsoft.AspNetCore.Mvc;
using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.UnitOfWork;
using System.Diagnostics;

namespace CMSExample.Admin.Controllers
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
        public IActionResult Products()
        {
            var products =_unitOfWork.Products.GetAll();
            return View(products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Products.Add(product);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View("Index", _unitOfWork.Products.GetAll());
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var product = _unitOfWork.Products.Get(id);
            if (product != null)
            {
                _unitOfWork.Products.Remove(product);
                _unitOfWork.Complete();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = _unitOfWork.Products.Get(product.Id);
                if (existingProduct != null)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.Stock = product.Stock;
                    existingProduct.Price = product.Price;
                    existingProduct.Description = product.Description;
                    existingProduct.ImageUrl = product.ImageUrl;


                    _unitOfWork.Complete();
                }
            }
            return RedirectToAction("Index");
        }
    }
}



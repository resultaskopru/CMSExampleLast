using Microsoft.AspNetCore.Mvc;
using CMSExample.DataAccess.Models;
using CMSExample.DataAccess.UnitOfWork;
using System.Diagnostics;

namespace CMSExample.Admin.Controllers
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
        public IActionResult Articles()
        {
            var articles =_unitOfWork.Articles.GetAll();
            return View(articles);
        }

        [HttpPost]
        public IActionResult AddArticle(Article article)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Articles.Add(article);
                _unitOfWork.Complete();
                return RedirectToAction("Index");
            }
            return View("Index", _unitOfWork.Articles.GetAll());
        }

        [HttpPost]
        public IActionResult DeleteArticle(int id)
        {
            var article = _unitOfWork.Articles.Get(id);
            if (article != null)
            {
                _unitOfWork.Articles.Remove(article);
                _unitOfWork.Complete();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateArticle(Article article)
        {
            if (ModelState.IsValid)
            {
                var existingArticle = _unitOfWork.Articles.Get(article.Id);
                if (existingArticle != null)
                {
                    existingArticle.Title = article.Title;
                    existingArticle.Description = article.Description;
                    existingArticle.ImageUrl = article.ImageUrl;
                    _unitOfWork.Complete();
                }
            }
            return RedirectToAction("Index");
        }
    }
}



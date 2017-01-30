using Microsoft.AspNetCore.Mvc;
using Greysis.Services;
using Greysis.Domain.Entities;

namespace Greysis.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            categoryService.GetAll();
        }
        public  IActionResult Index()
        {
            //var aa =_blogService.Deneme("sdfsdf");
            //_context.Repository<Category>().Add(new Category {  CategoryName="deds dsd" });
            //_context.Blog1.Add(new Blog { Title = "sfsdf  sd" });
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

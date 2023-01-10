using BoolkyBookWeb.Data.Persistence;
using BoolkyBookWeb.Models;
using BoolkyBookWeb.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BoolkyBookWeb.Controllers
{

    public class CategoryController : Controller
    {
        ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = categoryService.Get(Category.table);

            return View(categories);
        }

    }
}

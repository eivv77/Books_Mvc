using BoolkyBookWeb.Data.Persistence;
using BoolkyBookWeb.Models;
using BoolkyBookWeb.Services.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;

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

            List<Category> catList = categories.AsEnumerable().Select(m => new Category()
            {
                Id = m.Field<int>("ID"),
                Name = m.Field<string>("Name"),
                DisplayOrder = m.Field<int>("DisplayOrder"),
                CreatedDateTime = m.Field<DateTime>("CreatedDateTime")
            }).ToList();

            return View(catList);
        }

    }
}

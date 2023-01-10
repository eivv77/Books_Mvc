using BoolkyBookWeb.Models;
using BoolkyBookWeb.Repos;
using BoolkyBookWeb.Services.Abstract;

namespace BoolkyBookWeb.Services.Concrete
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IRepository<Category> repo) : base(repo)
        {
        }

        public override void Add(Category entity, string table, string value)
        {
            value = $@"
                (ERP_Code_Bank, Bank_Code, Name) 
                VALUES('{entity.DisplayOrder},'{entity.Name}')
            ";
            base.Add(entity, table, value);
        }
    }
}

using BoolkyBookWeb.Repos;
using BoolkyBookWeb.Services.Abstract;
using System.Data;

namespace BoolkyBookWeb.Services.Concrete
{
    public class BaseService<TEntity> : IBaseService<TEntity>
    {
        public IRepository<TEntity> repo;

        public BaseService(IRepository<TEntity> repo)
        {
            this.repo = repo;
        }
        public DataTable Get(string table)
        {


            return repo.Get(table);
        }
        public virtual void Add(TEntity entity, string table, string value)
        {
            repo.Add(entity, table, value);
        }
    }
}

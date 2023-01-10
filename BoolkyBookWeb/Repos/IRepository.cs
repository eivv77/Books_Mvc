using System.Data;

namespace BoolkyBookWeb.Repos
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IRepository
    {
        public DataTable Get(string table);
        public void Add(TEntity entity, string table, string value);
    }
}

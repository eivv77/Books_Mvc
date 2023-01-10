using BoolkyBookWeb.Data.Persistence;
using System.Data;

namespace BoolkyBookWeb.Repos
{
    public class Repository: IRepository
    {
    }

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DataTable Get(string table)
        {
            string sql = $@"SELECT * FROM [{table}] ";
            return AppDbContext.Execute(sql);
        }

        public void Add(TEntity entity, string table, string value)
        {
            string sql = $@"INSERT INTO {table}" + value;
            AppDbContext.Execute(sql);
        }
    }
}

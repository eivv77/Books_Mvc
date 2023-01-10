using System.Data;

namespace BoolkyBookWeb.Services.Abstract
{
    public interface IBaseService<TEntity>
    {
        public DataTable Get(string table);
        public void Add(TEntity entity, string table, string value);


    }
}

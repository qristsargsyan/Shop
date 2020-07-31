using System.Threading.Tasks;

namespace Shop.BLL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
    }
}

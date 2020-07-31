using Shop.BLL;
using System.Threading.Tasks;

namespace Shop.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        readonly ShopContext _context;
        public Repository(ShopContext context)
        {
            _context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.AddAsync(entity);
        }
    }
}

using System.Linq;
using System.Threading.Tasks;
using BoatService.Web.DataAccess.Contracts;

namespace BoatService.Web.DataAccess.Implementations
{
    public class DbRepository<TEntity>: IDbRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }

        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public IQueryable<TEntity> Get()
        {
            return _context.Set<TEntity>().Where(e => e.IsActive);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public async Task Update(TEntity entity)
        {
            await Task.Run(() => _context.Set<TEntity>().Update(entity));
        }

        public async Task Delete(TEntity entity)
        {
            entity.IsActive = false; 
            await Task.Run(() => _context.Set<TEntity>().Update(entity));
        }

        public async Task Remove(TEntity entity)
        {
            await Task.Run(() => _context.Set<TEntity>().Remove(entity));
        }
    }
}
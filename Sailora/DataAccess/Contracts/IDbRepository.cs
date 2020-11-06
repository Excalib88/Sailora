using System.Linq;
using System.Threading.Tasks;

namespace BoatService.Web.DataAccess.Contracts
{
    public interface IDbRepository<TEntity>
    {
        Task Create(TEntity entity);
        
        /// <summary>
        /// Получение записей без удаленных
        /// </summary>
        IQueryable<TEntity> Get();
        
        /// <summary>
        /// Получение записей включая удаленные
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> GetAll();
        Task Update(TEntity entity);
        
        /// <summary>
        /// Удаление записи(изменение IsActive)
        /// </summary>
        /// <param name="entity"></param>
        Task Delete(TEntity entity);
        
        /// <summary>
        /// Полное удаление
        /// </summary>
        /// <param name="entity"></param>
        Task Remove(TEntity entity);
    }
}
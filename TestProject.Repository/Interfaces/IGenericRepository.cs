using System.Linq.Expressions;
using TestProject.Entity.ViewModels;

namespace TestProject.Repository.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class
{
    public IQueryable<TEntity> Table { get; }
    Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>>? expression = null, bool? getDeleted = false, Func<IQueryable<TEntity>, IQueryable<TEntity>>? includes = null);
    Task<PaginationViewModel<T>> GetPaginationViewModel<T>(string search,
      string order,
      int page,
      int pageSize,
      Expression<Func<TEntity, bool>> filter,
      Expression<Func<TEntity, object>>? orderBy = null,
      bool? isAscending = null,
      Func<IQueryable<TEntity>, IQueryable<TEntity>>? includes = null) where T : class;


}

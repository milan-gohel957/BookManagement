using System.Linq.Expressions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestProject.Entity.Data;
using TestProject.Entity.ViewModels;
using TestProject.Repository.Interfaces;

namespace TestProject.Repository.Implementations;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly ProjectContext _projectContext;
    private readonly DbSet<TEntity> _dbSet;
    private IMapper _mapper;
    public GenericRepository(ProjectContext projectContext, IMapper mapper)
    {
        _mapper  = mapper;
        _projectContext = projectContext;
        _dbSet = _projectContext.Set<TEntity>();
    }

    public IQueryable<TEntity> Table => _dbSet;
    public IQueryable<TEntity> NonDeletedQuery()
    {
        return _dbSet.Where(e => EF.Property<bool>(e, "IsDeleted") == false);
    }
    public async Task<TEntity?> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>>? expression = null, bool? getDeleted = false, Func<IQueryable<TEntity>, IQueryable<TEntity>>? includes = null)
    {
        if (expression == null) return await _dbSet.FirstOrDefaultAsync();
        includes?.Invoke(_dbSet);
        return getDeleted == true ? await _dbSet.FirstOrDefaultAsync(expression) : await NonDeletedQuery().FirstOrDefaultAsync(expression);
    }

    public async Task<PaginationViewModel<T>> GetPaginationViewModel<T>(string search,
       string order,
       int page,
       int pageSize,
       Expression<Func<TEntity, bool>> filter,
       Expression<Func<TEntity, object>>? orderBy = null,
       bool? isAscending = null,
       Func<IQueryable<TEntity>, IQueryable<TEntity>>? includes = null) where T : class
    {
        IQueryable<TEntity> query = _dbSet;

        if (order != null)
        {
            var property = typeof(T).GetProperty(order);
            if (property != null)
            {
                query = isAscending == true ? query.OrderBy(e => property) : query.OrderByDescending(e => property);
            }
        }

        if (includes != null)
        {
            query = includes(query);
        }
        if (!string.IsNullOrEmpty(search))
            query = query.Where(filter);
        if (orderBy != null)
        {
            if (isAscending == true)
            {
                query = query.OrderBy(orderBy);
            }
            else
            {
                query = query.OrderByDescending(orderBy);
            }
        }

        int totalItems = await query.CountAsync();

        // Calculate total pages
        int totalPages = (int)Math.Ceiling((double)totalItems / pageSize);

        // Apply pagination
        query = query
            .Skip((page - 1) * pageSize)
            .Take(pageSize);


        return new PaginationViewModel<T>()
        {
            Items = _mapper.Map<List<T>>(await query.ToListAsync()),
            Order = order??"",
            Page = page,
            PageSize = pageSize,
            TotalPages = totalPages,
            Search = search
        };


    }


}

using TestProject.Entity.Models;

namespace TestProject.Repository.Interfaces;

public interface IUnitOfWork
{
    public IGenericRepository<User> User { get; }
    public IGenericRepository<Role> Role { get; }
    Task<ResultObject> SaveAsync();
}

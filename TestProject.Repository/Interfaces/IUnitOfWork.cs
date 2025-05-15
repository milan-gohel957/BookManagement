using TestProject.Entity.Models;

namespace TestProject.Repository.Interfaces;

public interface IUnitOfWork
{
    public IGenericRepository<User> User { get; }
    public IGenericRepository<Role> Role { get; }
    public IGenericRepository<Book> Book{get;}
    public IGenericRepository<IssuedBook> IssuedBook{get;}
    Task<ResultObject> SaveAsync();
}

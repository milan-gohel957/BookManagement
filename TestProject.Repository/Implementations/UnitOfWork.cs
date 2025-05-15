using AutoMapper;
using TestProject.Entity.Data;
using TestProject.Entity.Models;
using TestProject.Repository.Interfaces;

namespace TestProject.Repository.Implementations;

public class UnitOfWork : IUnitOfWork
{
    public IGenericRepository<User> User { get; private set; }
    public IGenericRepository<Role> Role { get; private set; }
    public IGenericRepository<Book> Book{get; private set;}
    public IGenericRepository<IssuedBook> IssuedBook{get; private set;}
    private IMapper _mapper;
    private ProjectContext _context;

    public UnitOfWork(ProjectContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        User = new GenericRepository<User>(_context, _mapper);
        Role = new GenericRepository<Role>(_context, _mapper);
        Book = new GenericRepository<Book>(_context,_mapper);
        IssuedBook = new GenericRepository<IssuedBook>(_context,_mapper);
    }

    public async Task<ResultObject> SaveAsync()
    {
        try
        {
            await _context.SaveChangesAsync();
            return new() { Status = true, Message = "context Saved!" };
        }
        catch (Exception)
        {
            return new() { Status = false, Message = "Failed to save context." };
        }
    }
}

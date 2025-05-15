using AutoMapper;
using TestProject.Entity.Models;
using TestProject.Entity.ViewModels;

namespace TestProject.Entity.Mappings;
public class AutoMappings : Profile
{
    public AutoMappings()
    {
        CreateMap<Book, BookModel>();
    }
}

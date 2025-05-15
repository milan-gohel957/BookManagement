using TestProject.Entity.ViewModels;

namespace TestProject.Service.Interfaces;

public interface IBookService
{
    Task<ResultObject> CreateBook(BookModel bookModel);
    Task<(ResultObject, PaginationViewModel<BookModel>)> BookPagination(string order, int page, int pageSize, string search, bool isAscending);
    Task<ResultObject> UpdateBook(BookModel bookModel);
    Task<ResultObject> DeleteBook(int bookId);
}

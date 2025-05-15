using TestProject.Entity.ViewModels;

namespace TestProject.Service.Interfaces;

public interface IBookService
{
    Task<ResultObject> CreateBookAsync(BookModel bookModel);
    Task<(ResultObject, PaginationViewModel<BookModel>)> BookPaginationAsync(string order, int page, int pageSize, string search, bool isAscending);
    Task<ResultObject> UpdateBookAsync(BookModel bookModel);
    Task<ResultObject> DeleteBookAsync(int bookId);
    Task<(ResultObject, BookModel)> ShowUpsertBookModalAsync(int bookId);
    Task<ResultObject> IssueBookAsync(int bookId, int userId);

}

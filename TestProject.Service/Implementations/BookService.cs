using AutoMapper;
using Microsoft.Extensions.Hosting;
using TestProject.Entity.Enums;
using TestProject.Entity.Models;
using TestProject.Entity.ViewModels;
using TestProject.Repository.Interfaces;
using TestProject.Service.Helpers;

namespace TestProject.Service.Implementations;

public class BookService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHostEnvironment _hostEnvironment;
    public BookService(IMapper mapper, IUnitOfWork unitOfWork, IHostEnvironment hostEnvironment)
    {
        _hostEnvironment = hostEnvironment;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    // Create Book
    public async Task<ResultObject> CreateBook(BookModel bookModel)
    {
        try
        {
            Book newBook = _mapper.Map<Book>(bookModel);
            await FileUpload.UpdateProfileImageAsync(bookModel.UploadedBookImage, newBook, _hostEnvironment);

            newBook.CreatedAt = DateTime.Now;
            newBook.UpdatedAt = DateTime.Now;
            newBook.BookStatus = BookStatusEnum.Available;
            newBook.IsDeleted = false;

            await _unitOfWork.Book.AddAsync(newBook);

            return new() { Status = false, Message = "Book Created" };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error While Creating Book." };
        }
    }

    // Pagination
    public async Task<(ResultObject, PaginationViewModel<BookModel>)> BookPagination(string order, int page, int pageSize, string search, bool isAscending)
    {
        try
        {
            search = search.ToLower();
            PaginationViewModel<BookModel> booksPaginated = await _unitOfWork.Book.GetPaginationViewModel<BookModel>(
                search:search,
                order:order,
                page:page,
                pageSize:pageSize,
                filter: b => b.AuthorName.ToLower().Contains(search) || 
                            b.Title.ToLower().Contains(search) ||
                            b.BookStatus.ToString().Contains(search) ||
                            b.ISBN.ToLower().Contains(search) ||
                            b.PublishedYear.ToString().Contains(search),
                orderBy: order switch {
                    "id" => b => b.Id,
                    "isbn" => b => b.ISBN,
                    "title" => b => b.Title,
                    "publishYear" => b => b.PublishedYear,
                    "authorName" => b => b.AuthorName,
                    _ => null
                },
                isAscending
            );
            ResultObject resultObject = new(){Status = true, Message = "Success"};
            return (resultObject, booksPaginated);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return (new() { Status = false, Message = "Error While Creating Book." }, new());
        }
    }
    // Update Book
    public async Task<ResultObject> UpdateBook(BookModel bookModel)
    {
        try
        {
            if (bookModel.Id == null || bookModel.Id <= 0) return new() { Status = false, Message = "Book Not found" };

            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookModel.Id ?? 0);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found" };


            bool isISBNExists = await _unitOfWork.Book.GetAnyAsync(y => y.ISBN == bookModel.ISBN && y.Id != bookModel.Id);
            if (isISBNExists) return new() { Status = false, Message = "This ISBN Number already exists." };


            dbBook = _mapper.Map<Book>(bookModel);
            dbBook.UpdatedAt = DateTime.Now;

            ResultObject saveResult = await _unitOfWork.SaveAsync();
            if (!saveResult.Status)
            {
                return saveResult;
            }
            return new() { Status = true, Message = "Book Updated Successfully." };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error While Updating Book." };
        }
    }
    // Delete Book
    public async Task<ResultObject> DeleteBook(int bookId)
    {
        try
        {
            if (bookId <= 0) return new() { Status = false, Message = "Book Not found" };

            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookId);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found" };

            dbBook.IsDeleted = true;

            ResultObject saveResult = await _unitOfWork.SaveAsync();
            if (!saveResult.Status)
            {
                return saveResult;
            }
            return new() { Status = true, Message = "Book Deleted Successfully." };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error While deleting Book." };
        }
    }

}

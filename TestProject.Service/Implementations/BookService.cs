using System.Runtime.CompilerServices;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TestProject.Entity.Enums;
using TestProject.Entity.Models;
using TestProject.Entity.ViewModels;
using TestProject.Repository.Interfaces;
using TestProject.Service.Helpers;
using TestProject.Service.Interfaces;

namespace TestProject.Service.Implementations;

public class BookService : IBookService
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHostEnvironment _hostEnvironment;
    private readonly IAuthService _authService;

    public BookService(IMapper mapper, IUnitOfWork unitOfWork, IAuthService authService, IHostEnvironment hostEnvironment)
    {
        _authService = authService;
        _hostEnvironment = hostEnvironment;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    private static void MapBookAndBookModel(ref Book book, ref BookModel bookModel, bool isCreate)
    {
        book.AuthorName = bookModel.AuthorName;
        book.ISBN = bookModel.ISBN;
        book.PublishedYear = bookModel.PublishedYear;
        book.Title = bookModel.Title;
        book.TotalPages = bookModel.TotalPages;
        book.UpdatedAt = DateTime.Now;

        if (isCreate)
        {
            book.IsDeleted = false;
            book.UpdatedAt = DateTime.Now;
            book.CreatedAt = DateTime.Now;
        }
    }
    // Create Book
    public async Task<ResultObject> CreateBookAsync(BookModel bookModel)
    {
        try
        {
            Book newBook = new();

            bool isISBNExists = await _unitOfWork.Book.GetAnyAsync(y => y.ISBN == bookModel.ISBN && y.Id != bookModel.Id);
            if (isISBNExists) return new() { Status = false, Message = "This ISBN Number already exists." };
            
            MapBookAndBookModel(ref newBook, ref bookModel, isCreate: true);
            
            await FileUpload.UpdateProfileImageAsync(bookModel.UploadedBookImage, newBook, _hostEnvironment);

            await _unitOfWork.Book.AddAsync(newBook);

            return new() { Status = true, Message = "Book Created" };
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error While Creating Book." };
        }
    }

    // Pagination
    public async Task<(ResultObject, PaginationViewModel<BookModel>)> BookPaginationAsync(string order, int page, int pageSize, string search, bool isAscending)
    {
        try
        {
            int userId = _authService.GetUserId();
            if (userId == -1) return (new() { Status = false, Message = "Invalid user." }, new());
            var userTable = _unitOfWork.User.Table;

            var issuedBooks = _unitOfWork.IssuedBook.Table;
            List<IssuedBook> issuedBooksToUser = await issuedBooks.Where(ib => ib.UserId == userId && ib.IsDeleted == false && ib.IsIssued == true).ToListAsync();
            // search = search.ToLower();
            PaginationViewModel<BookModel> booksPaginated = await _unitOfWork.Book.GetPaginationViewModel<BookModel>(
                search: search,
                order: order,
                page: page,
                pageSize: pageSize,
                filter: b => b.AuthorName.ToLower().Contains(search) ||
                            b.Title.ToLower().Contains(search) ||
                            b.BookStatus.ToString().Contains(search) ||
                            b.ISBN.ToLower().Contains(search) ||
                            b.PublishedYear.ToString().Contains(search),
                orderBy: order switch
                {
                    "id" => b => b.Id,
                    "isbn" => b => b.ISBN,
                    "title" => b => b.Title,
                    "publishYear" => b => b.PublishedYear,
                    "authorName" => b => b.AuthorName,
                    _ => b => b.Id
                },
                isAscending
            );

            booksPaginated.IssuedBookIds = issuedBooksToUser.Select(b => b.BookId).ToList();

            ResultObject resultObject = new()
            {
                Status = true,
                Message = "Success"
            };
            return (resultObject, booksPaginated);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return (new() { Status = false, Message = "Error While Creating Book." }, new());
        }
    }
    // Update Book
    public async Task<ResultObject> UpdateBookAsync(BookModel bookModel)
    {
        try
        {
            if (bookModel.Id <= 0) return new() { Status = false, Message = "Book Not found" };

            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookModel.Id ?? 0);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found" };


            bool isISBNExists = await _unitOfWork.Book.GetAnyAsync(y => y.ISBN == bookModel.ISBN && y.Id != bookModel.Id);
            if (isISBNExists) return new() { Status = false, Message = "This ISBN Number already exists." };

            MapBookAndBookModel(ref dbBook, ref bookModel, isCreate: false);
            await FileUpload.UpdateProfileImageAsync(bookModel.UploadedBookImage, dbBook, _hostEnvironment);

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
    public async Task<ResultObject> DeleteBookAsync(int bookId)
    {
        try
        {
            if (bookId <= 0) return new() { Status = false, Message = "Book Not found" };

            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookId);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found" };

            if(dbBook.BookStatus == BookStatusEnum.Issued) return new(){Status =false, Message = "You can't Delete Issued Book"};
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

    public async Task<(ResultObject, BookModel)> ShowUpsertBookModalAsync(int bookId)
    {
        try
        {
            if (bookId <= 0)
            {
                return (new() { Status = true, Message = "Success." }, new());
            }
            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookId);
            if (dbBook == null) return (new() { Status = false, Message = "Error While deleting Book." }, new());

            return (new() { Status = true, Message = "Success." }, _mapper.Map<BookModel>(dbBook));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return (new() { Status = false, Message = "Error While deleting Book." }, new());
        }
    }

    public async Task<ResultObject> IssueBookAsync(int bookId)
    {
        try
        {
            int userId = _authService.GetUserId();
            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookId);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found." };

            if (dbBook.BookStatus == BookStatusEnum.Issued) return new() { Status = false, Message = "You can't issue this book, Because it is already assign to someone else." };

            bool isUserExists = await _unitOfWork.User.GetAnyAsync(u => u.Id == userId);
            if (!isUserExists) return new() { Status = false, Message = "User Not Found." };

            var issuedBooksTable = _unitOfWork.IssuedBook.Table;
            List<IssuedBook> issuedBooks = await issuedBooksTable.Where(ibt => ibt.UserId == userId && ibt.IsDeleted == false && ibt.IsIssued == true).ToListAsync();
            if (issuedBooks.Count >= 3) return new() { Status = false, Message = "You can't issue more than 3 books." };

            IssuedBook newBookIssue = new()
            {
                BookId = bookId,
                UserId = userId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsDeleted = false,
                IsIssued = true,
            };
            await _unitOfWork.IssuedBook.AddAsync(newBookIssue);

            dbBook.BookStatus = BookStatusEnum.Issued;

            ResultObject saveResult = await _unitOfWork.SaveAsync();
            if (!saveResult.Status)
            {
                return saveResult;
            }
            return new() { Status = true, Message = "Book Issued!" };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error Issuing Book." };
        }
    }

    public async Task<ResultObject> ReturnBookAsync(int bookId)
    {
        try
        {
            int userId = _authService.GetUserId();
            bool isUserExists = await _unitOfWork.User.GetAnyAsync(u => u.Id == userId);
            if (!isUserExists) return new() { Status = false, Message = "User Not Found." };

            Book? dbBook = await _unitOfWork.Book.GetItemByIdAsync(bookId);
            if (dbBook == null) return new() { Status = false, Message = "Book Not Found." };

            if (dbBook.BookStatus == BookStatusEnum.Available) return new() { Status = false, Message = "You can't return this book, Because it is already available." };

            dbBook.BookStatus = BookStatusEnum.Available;

            IssuedBook? issuedBook = await _unitOfWork.IssuedBook.GetFirstOrDefaultAsync(y => y.BookId == bookId && y.UserId == userId);
            if (issuedBook == null) return new() { Status = false, Message = "You can't Return this book, Because you have not issued this book." };
            issuedBook.IsIssued = false;

            ResultObject saveResult = await _unitOfWork.SaveAsync();
            if (!saveResult.Status)
            {
                return saveResult;
            }
            return new() { Status = true, Message = "Book Return Successfully!" };

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new() { Status = false, Message = "Error Returning book." };
        }
    }
}

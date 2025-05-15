using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestProject.Entity.ViewModels;
using TestProject.Service.Interfaces;

namespace TestProject.Web.Controllers;

[Authorize]
public class BookController : Controller
{
    private readonly IBookService _bookService;
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    public IActionResult Index()
    {
        return View();
    } 
    [HttpPost]
    public async Task<IActionResult> CreateBook(BookModel bookModel)
    {
        return Json(new {result = await _bookService.CreateBookAsync(bookModel)});
    }
    [HttpPost]
    public async Task<IActionResult> UpdateBook(BookModel bookModel)
    {
        return Json(new {result = await _bookService.UpdateBookAsync(bookModel)});
    }
    public async Task<IActionResult> BookPagination(int page, int pageSize, string search, string order, bool isAscending)
    {
        var (result, bookPaginationModel) = await _bookService.BookPaginationAsync(page:page, pageSize:pageSize, order:order, search:search, isAscending:isAscending);
        if(!result.Status) 
        {
            return Json(new{Result = result});
        }
        return PartialView("_BookPagination", bookPaginationModel);
    }

    [HttpGet]
    public async Task<IActionResult> ShowUpsertBookModal(int bookId)
    {
        var(result, bookModel) =await _bookService.ShowUpsertBookModalAsync(bookId);
        if(!result.Status){
            return Json(new{result});
        }
        return PartialView("_UpsertBookModal", bookModel);
    }
}   

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestProject.Entity.CustomValidators;
using TestProject.Entity.Models;
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
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> DeleteBook(int bookId)
    {
        return Json(new {result = await _bookService.DeleteBookAsync(bookId)});
    }
    [HttpPost]
    public async Task<IActionResult> IssueBook(int bookId, int userId)
    {
        return Json(new {result = await _bookService.IssueBookAsync(bookId:bookId, userId:userId)});
    }
    [HttpPost]
    [Authorize(Roles = "Admin")]
    [Trim]
    public async Task<IActionResult> CreateBook(BookModel bookModel)
    {
        if (!ModelState.IsValid) return Json(new { result = new ResultObject { Status = false, Message = "ModelState Is Invalid" } });
        return Json(new { result = await _bookService.CreateBookAsync(bookModel) });
    }
    [HttpPost]
    [Authorize(Roles = "Admin")]
    [Trim]
    public async Task<IActionResult> UpdateBook(BookModel bookModel)
    {
        if (!ModelState.IsValid) return Json(new { result = new ResultObject { Status = false, Message = "ModelState Is Invalid" } });
        return Json(new { result = await _bookService.UpdateBookAsync(bookModel) });
    }

    public async Task<IActionResult> BookPagination(int page, int pageSize, string search, string order, bool isAscending)
    {
        var (result, bookPaginationModel) = await _bookService.BookPaginationAsync(page: page, pageSize: pageSize, order: order, search: search, isAscending: isAscending);
        if (!result.Status)
        {
            return Json(new { Result = result });
        }
        return PartialView("_BookPagination", bookPaginationModel);
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public IActionResult ShowDeleteModal()
    {
        return PartialView("_DeleteBookModal");
    }
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> ShowUpsertBookModal(int bookId)
    {
        var (result, bookModel) = await _bookService.ShowUpsertBookModalAsync(bookId);
        if (!result.Status)
        {
            return Json(new { result });
        }
        return PartialView("_UpsertBookModal", bookModel);
    }
}

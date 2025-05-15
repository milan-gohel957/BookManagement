
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using TestProject.Entity.Models;
namespace TestProject.Service.Helpers;
public class FileUpload
{
    private static string GetUniqueFileName(string fileName)
    {
        fileName = Path.GetFileName(fileName);
        return string.Concat(Path.GetFileNameWithoutExtension(fileName)
, "_"
, Guid.NewGuid().ToString().AsSpan(0, 4)
, Path.GetExtension(fileName));
    }
    public static async Task UpdateProfileImageAsync(IFormFile? uploadedImage, Book book, IHostEnvironment _hostEnvironment)
    {

        if (uploadedImage != null)
        {
            var uniqueFileName = GetUniqueFileName(uploadedImage.FileName);
            var uploadsDirectory = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", "uploads", "books");
            var filePath = Path.Combine(uploadsDirectory, uniqueFileName);

            if (!string.IsNullOrEmpty(book.BookImageUrl))
            {
                string absolutePath = Path.Combine(_hostEnvironment.ContentRootPath, "wwwroot", book.BookImageUrl[1..]);

                if (File.Exists(absolutePath))
                {
                    try
                    {
                        File.Delete(absolutePath);  
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting the image: {ex.Message}");
                    }
                }
            }

            // Create the uploads directory if it doesn't exist
            if (!Directory.Exists(uploadsDirectory))
            {
                Directory.CreateDirectory(uploadsDirectory);
            }

            // Save the new image
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await uploadedImage.CopyToAsync(fileStream);
            }

            // Update the user's profile URL
            book.BookImageUrl = "/uploads/books/" + uniqueFileName;
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using BookApi.Models;

namespace BookApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        Book[] books = new Book[]
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Genre = "Classic", PublishedDate = new DateTime(1925, 4, 10), Price = 10.99m },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedDate = new DateTime(1960, 7, 11), Price = 8.99m },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedDate = new DateTime(1949, 6, 8), Price = 9.99m }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks() 
        {
            return Ok(books.ToList());
        }
    }
}

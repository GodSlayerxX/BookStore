using BookStore.BL.Interfaces;
using BookStore.Models.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController()
        {
            _bookService = _bookService;
        }
        [HttpGet("GetBookById")]
        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }
        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }
        [HttpPost]
        public void Add([FromBody]Book book)
        {
            _bookService.Add(book);
        }
        [HttpDelete]
        public void Delete([FromBody]Book book)
        {
            _bookService.Remove(id: book.Id);
        }
    }
}

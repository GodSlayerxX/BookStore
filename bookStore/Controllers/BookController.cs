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
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public Book? Get(int id)
        {
            if (id < 0) return null;

            return _bookRepository.GetBook(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Book book)
        {
            if (book == null) return;

            _bookRepository.AddBook(book);
        }
    }
}
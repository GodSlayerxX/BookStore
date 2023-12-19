using BookStore.BL.Interfaces;
using BookStore.Models.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController()
        {
            _authorService = _authorService;
        }
        [HttpGet("GetBookById")]
        public Author GetAuthorById(int id)
        {
            return _authorService.GetById(id);
        }
        [HttpGet("GetAllAuthors")]
        public List<Author> GetAllAuthors()
        {
            return _authorService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Author author)
        {
            _authorService.Add(author);
        }

        [HttpDelete]
        public void Delete([FromBody] Author author)
        {
            _authorService.Remove(id: author.Id);
        }

    }
}

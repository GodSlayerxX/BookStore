using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.BL.Interfaces;

namespace BookStore.BL.Services
{
    public class LibraryService
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public LibraryService(
            IAuthorService authorService,
            IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(
                GetAllBooksByAuthorRequest request)
        {
            var response = new GetAllBooksByAuthorResponse
            {
                Author = _authorService
                    .GetById(request.AuthorId),
                Books = _bookService
                    .GetAllByAuthorAfterReleaseDate(
                        request.AuthorId,
                        request.DateAfter)
            };

            return response;
        }
    }
}
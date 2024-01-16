using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.BL.Interfaces;
using BookStore.Models.Request;
using BookStore.Models.Responses;

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

        public GetBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(
                GetBooksByAuthorRequest request)
        {
            var response = new GetBooksByAuthorResponse
            {
                Author = _authorService
                    .GetById(request.AuthorId),
                Books = _bookService
                    .GetAllByAuthorAfterReleaseDate(
                        request.AuthorId,
                        request.AfterDate)
            };

            return response;
        }
    }
}
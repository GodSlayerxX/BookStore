using BookStore.Models.Request;
using BookStore.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(GetBooksByAuthorRequest request);
    }
}
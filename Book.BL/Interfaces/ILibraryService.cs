using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public class ILibraryService
    {
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(GetAllBooksByAuthorRequest request);
    }
}
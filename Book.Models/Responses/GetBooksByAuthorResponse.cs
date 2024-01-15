using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.Models.Users;

namespace BookStore.Models.Responses
{
    public class GetBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Books { get; set; }
    }
}

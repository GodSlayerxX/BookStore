using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.MemoryDb
{
    public static class OutMemoryDb
    {
        public static List<Book> booksData
                = new List<Book>()
                {
                    new Book()
                    {
                        Id = 1,
                        Title = "Name 1",
                        AuthorId = 10,
                    },
                    new Book()
                    {
                        Id = 2,
                        Title = "Name 2",
                        AuthorId = 15,
                    },
                    new Book()
                    {
                        Id = 3,
                        Title = "Name 3",
                        AuthorId = 12,
                    }
                };
    }
}

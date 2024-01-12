using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            OutMemoryDb.booksData.Add(book);
        }

        public List<Book> GetAll()
        {
            return OutMemoryDb.booksData;
        }

        public Book GetById(int id)
        {
            return OutMemoryDb.booksData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var book = GetById(id);
            OutMemoryDb.booksData.Remove(book);
        }
    }
}

using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.Models;

namespace BookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDb.booksData.Add(book);
        }

        public List<Book> GetAll()
        {
            return InMemoryDb.booksData;
        }

        public Book GetById(int id)
        {
            return InMemoryDb.booksData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var book = GetById(id);
            InMemoryDb.booksData.Remove(book);
        }
        public List<Book> GetAllByAuthor(int authorId)
        {
            return InMemoryDb.BookData.Where(b => b.AuthorId == authorId).ToList();
        }
    }
}
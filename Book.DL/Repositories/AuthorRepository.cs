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
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDb.authorsData.Add(author);
        }

        public List<Author> GetAll()
        {
            return InMemoryDb.authorsData;
        }

        public Author GetById(int id)
        {
            return InMemoryDb.authorsData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.authorsData.Remove(author);
        }
    }
}

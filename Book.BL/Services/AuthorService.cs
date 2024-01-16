﻿using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            if (id > 50000) return null;

            return _authorRepository.GetById(id);
        }
        public void Add(Author author)
        {
            _authorRepository.Add(author);
        }
        public void Remove(int id)
        {
            _authorRepository.Remove(id);
        }
    }
}
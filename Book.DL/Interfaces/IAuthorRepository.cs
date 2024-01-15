﻿using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author GetById(int id);

        void Add (Author author);

        void Remove(int id);
    }
}
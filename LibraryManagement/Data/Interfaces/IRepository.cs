﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        //find and filter properties
        IEnumerable<T> Find(Func<T, bool> predicate);

        //search by ID
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        int Count(Func<T, bool> predicate);


    }
}

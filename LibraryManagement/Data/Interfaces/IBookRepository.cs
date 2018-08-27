using LibraryManagement.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Data.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllwithAuthor();

        IEnumerable<Book> FindWithAuthor(Func<Book,bool>predicate);

        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);

    }
}

using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task<Book> Create(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Book> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

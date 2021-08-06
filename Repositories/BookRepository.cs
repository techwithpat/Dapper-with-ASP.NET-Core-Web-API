using BookAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public Task<IEnumerable<Book>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Book> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Book> Create(Book book)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Book book)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

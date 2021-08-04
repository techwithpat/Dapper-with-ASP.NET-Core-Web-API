using BookAPI.Models;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;

        public BookRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("Default");
        }

        public async Task<Book> Create(Book book)
        {
            var sql = @"INSERT INTO Books (Title, Author, Description) VALUES (@Title, @Author, @Description)";

            using (var connection = new SqlConnection(_connectionString))
            {
                _ = await connection.ExecuteAsync(sql, new { book.Title, book.Author, book.Description })
                    .ConfigureAwait(false);

                return book;
            }
        }

        public async Task<IEnumerable<Book>> Get()
        {
            var sql = "SELECT * FROM Books";

            using (var connection = new SqlConnection(_connectionString))
            {
                var books = await connection.QueryAsync<Book>(sql).ConfigureAwait(false);
                return books;
            }
        }

        public async Task<Book> Get(int id)
        {
            var sql = "SELECT * FROM Books WHERE Id = @BookId";

            using (var connection = new SqlConnection(_connectionString))
            {
                var book = await connection.QueryFirstOrDefaultAsync<Book>(sql, new { BookId = id })
                                           .ConfigureAwait(false);
                return book;
            }
        }

        public async Task Update(Book book)
        {
            var sql = "UPDATE Books SET Title='@Title', Author=@Author, Description=@Description WHERE Id = @Id;";

            using (var connection = new SqlConnection(_connectionString))
            {
                _ = await connection.ExecuteAsync(sql, new {book.Id, book.Title, book.Author, book.Description})
                    .ConfigureAwait(false);
            }
        }

        public async Task Delete(int id)
        {
            var sql = "DELETE from Books WHERE Id = @Id;";

            using (var connection = new SqlConnection(_connectionString))
            {
                _ = await connection.ExecuteAsync(sql, new { Id = id })
                    .ConfigureAwait(false);
            }
        }       
    }
}

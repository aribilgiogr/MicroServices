using Endpoint_SQLite.Data;

namespace Endpoint_SQLite
{
    public interface ILibraryService
    {
        // Define CRUD operations here
        Task<Book> GetBookAsync(int bookId);
        Task<Author> GetAuthorAsync(int authorId);
        Task<Publisher> GetPublisherAsync(int publisherId);

        Task<IEnumerable<Book>> GetBooks(int? authorId = null, int? publisherId = null);
        Task<IEnumerable<Author>> GetAuthors();
        Task<IEnumerable<Publisher>> GetPublishers();

        Task<Book> AddBookAsync(Book book);
        Task<Author> AddAuthorAsync(Author author);
        Task<Publisher> AddPublisherAsync(Publisher publisher);

        Task<Book> UpdateBookAsync(Book book);
        Task<Author> UpdateAuthorAsync(Author author);
        Task<Publisher> UpdatePublisherAsync(Publisher publisher);

        Task DeleteBookAsync(int bookId);
        Task DeleteAuthorAsync(int authorId);
        Task DeletePublisherAsync(int publisherId);
    }
}

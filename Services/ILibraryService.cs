using Web2_1604.Model;

namespace Web2_1604.Services
{
    public interface ILibraryService
    {
        // Author Services
        Task<List<Authors>> GetAuthorsAsync(); // GET All Authors
        Task<Authors> GetAuthorAsync(Guid id, bool includeBooks = false); // GET Single Author
        Task<Authors> AddAuthorAsync(Authors author); // POST New Author
        Task<Authors> UpdateAuthorAsync(Authors author); // PUT Author
        Task<(bool, string)> DeleteAuthorAsync(Authors author); // DELETE Author

        // Book Services
        Task<List<Books>> GetBooksAsync(); // GET All Books
        Task<Books> GetBookAsync(Guid id); // Get Single Book
        Task<Books> AddBookAsync(Books book); // POST New Book
        Task<Books> UpdateBookAsync(Books book); // PUT Book
        Task<(bool, string)> DeleteBookAsync(Books book); // DELETE Book
    }
}

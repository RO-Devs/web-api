using BussinesLayer.Repositories.Core;
using DataLayer.Models.Books;
using DataLayer.ViewModels.Books;

namespace BussinesLayer.Interfaces.Books
{
    public interface IBooksService : IRepository<Book, BookViewModel>
    {
    }
}
using AutoMapper;
using BussinesLayer.Interfaces.Books;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Books;
using DataLayer.ViewModels.Books;

namespace BussinesLayer.Services.Books
{
    public class BooksService : Repository<Book, BookViewModel, BooksDbContext>, IBooksService
    {
        public BooksService(BooksDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

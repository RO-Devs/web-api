using AutoMapper;
using BussinesLayer.Interfaces.Authors;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Authors;
using DataLayer.ViewModels.Authors;

namespace BussinesLayer.Repositories.Authors
{
    public class AuthorService : Repository<Author, AuthorViewModel, BooksDbContext>, IAuthorService
    {
        public AuthorService(BooksDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

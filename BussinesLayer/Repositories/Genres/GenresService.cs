using AutoMapper;
using BussinesLayer.Interfaces.Genres;
using BussinesLayer.Repositories.Core;
using DataLayer.Contexts;
using DataLayer.Models.Genres;
using DataLayer.ViewModels.Genres;

namespace BussinesLayer.Repositories.Genres
{
    public class GenresService : Repository<Genre, GenreViewModel, BooksDbContext>, IGenresService
    {
        public GenresService(BooksDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

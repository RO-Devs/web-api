using BussinesLayer.Repositories.Core;
using DataLayer.Models.Genres;
using DataLayer.ViewModels.Genres;

namespace BussinesLayer.Interfaces.Genres
{
    public interface IGenresService : IRepository<Genre, GenreViewModel>
    {

    }
}
using BussinesLayer.Interfaces.Genres;
using DataLayer.Models.Genres;
using DataLayer.ViewModels.Genres;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Core;

namespace WebApi.Controllers.Genres
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : CoreController<IGenresService, Genre, GenreViewModel>
    {
        public GenresController(IGenresService service) : base(service)
        {
        }
    }
}

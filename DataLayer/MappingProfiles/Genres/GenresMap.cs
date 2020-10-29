using AutoMapper;
using DataLayer.Models.Genres;
using DataLayer.ViewModels.Genres;

namespace DataLayer.MappingProfiles.Genres
{
    public class GenresMap : Profile
    {
        public GenresMap()
        {
            CreateMap<Genre, GenreViewModel>();
        }
    }
}

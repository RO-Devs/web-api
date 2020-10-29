using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataLayer.Models.Authors;
using DataLayer.ViewModels.Authors;

namespace DataLayer.MappingProfiles.Authors
{
    public class AuthorsMap : Profile
    {
        public AuthorsMap()
        {
            CreateMap<Author, AuthorViewModel>();
        }
    }
}

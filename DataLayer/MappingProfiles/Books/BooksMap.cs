using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DataLayer.Models.Books;
using DataLayer.ViewModels.Books;

namespace DataLayer.MappingProfiles.Books
{
    public class BooksMap : Profile
    {
        public BooksMap()
        {
            CreateMap<Book, BookViewModel>();
        }
    }
}

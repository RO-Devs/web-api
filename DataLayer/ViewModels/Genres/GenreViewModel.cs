using System.Collections.Generic;
using DataLayer.ViewModels.Books;
using DataLayer.ViewModels.Core;

namespace DataLayer.ViewModels.Genres
{
    public class GenreViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public IEnumerable<BookViewModel> Books { get; set; }
    }
}

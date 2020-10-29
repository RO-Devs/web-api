using DataLayer.ViewModels.Authors;
using DataLayer.ViewModels.Core;
using System;

namespace DataLayer.ViewModels.Books
{
    public class BookViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Editorial { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public virtual AuthorViewModel Author { get; set; }
        public virtual AuthorViewModel Genre { get; set; }
    }
}

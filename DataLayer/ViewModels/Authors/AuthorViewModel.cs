using DataLayer.ViewModels.Books;
using System;
using System.Collections.Generic;

namespace DataLayer.ViewModels.Authors
{
    public class AuthorViewModel
    {
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Alias { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual IEnumerable<BookViewModel> Books { get; set; }
    }
}

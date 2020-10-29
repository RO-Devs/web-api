using System;
using System.Collections.Generic;
using DataLayer.Models.Books;
using DataLayer.Models.Core;

namespace DataLayer.Models.Authors
{
    public class Author : BaseModel
    {
        public string Names { get; set; }
        public string LastNames { get; set; }
        public string Alias { get; set; }
        public DateTime BirthDate { get; set; }
        public virtual IEnumerable<Book> Books { get; set; }
    }
}

using DataLayer.Models.Books;
using DataLayer.Models.Core;
using System.Collections.Generic;

namespace DataLayer.Models.Genres
{
    public class Genre : BaseModel
    {
        public string Name { get; set; }
        public virtual IEnumerable<Book> Book { get; set; }
    }
}

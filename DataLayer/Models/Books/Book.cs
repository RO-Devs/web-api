using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models.Authors;
using DataLayer.Models.Core;
using DataLayer.Models.Genres;

namespace DataLayer.Models.Books
{
    public class Book : BaseModel
    {
        public string Name { get; set; }
        public string Editorial { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}

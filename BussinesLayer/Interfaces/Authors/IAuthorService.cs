using BussinesLayer.Repositories.Core;
using DataLayer.Models.Authors;
using DataLayer.ViewModels.Authors;

namespace BussinesLayer.Interfaces.Authors
{
    public interface IAuthorService : IRepository<Author, AuthorViewModel>
    {

    }
}
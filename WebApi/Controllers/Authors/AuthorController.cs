using BussinesLayer.Interfaces.Authors;
using DataLayer.Models.Authors;
using DataLayer.ViewModels.Authors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Core;

namespace WebApi.Controllers.Authors
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : CoreController<IAuthorService,Author,AuthorViewModel>
    {
        public AuthorController(IAuthorService service) : base(service)
        {
        }
    }
}

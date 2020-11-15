using BussinesLayer.Interfaces.Books;
using DataLayer.Models.Books;
using DataLayer.ViewModels.Books;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Core;

namespace WebApi.Controllers.Books
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BooksController : CoreController<IBooksService, Book,BookViewModel>
    {
        public BooksController(IBooksService service) : base(service)
        {
        }
    }
}

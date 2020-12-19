using BussinesLayer.Interfaces.Auth;
using BussinesLayer.Services.Auth;
using DataLayer.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AuthService _authService;
        private readonly IOptions<JwtSetting> _jwtOptions;

        public UnitOfWork(IOptions<JwtSetting> jwtOptions) => _jwtOptions = jwtOptions;


        public IAuthService IAuthService => _authService ??= new AuthService(_jwtOptions);

    }
}

using BussinesLayer.Interfaces.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinesLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAuthService IAuthService { get; }

    }
}

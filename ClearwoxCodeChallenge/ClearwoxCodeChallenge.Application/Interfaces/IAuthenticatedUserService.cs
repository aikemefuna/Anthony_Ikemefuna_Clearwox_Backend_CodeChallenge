using System;
using System.Collections.Generic;
using System.Text;

namespace ClearwoxCodeChallenge.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}

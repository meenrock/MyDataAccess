using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Net;
using System.Threading.Tasks;
using CommonTypes.Authentication;

namespace IdentityServices.Controllers;

[Route("v1")]
public class AuthController
{
    private readonly IActionContextAccessor _contextAccessor;

    public AuthController(IActionContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public async Task<IActionResult> LogIn([FromBody] UserLogInModel logInModel)
    {
        
    }
    
    
}
using Microsoft.AspNetCore.Mvc;
using Users.Catalog.Models.Dtos;

namespace Users.Catalog.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<UserDto>> Get()
    {
        return Ok();
    }
}
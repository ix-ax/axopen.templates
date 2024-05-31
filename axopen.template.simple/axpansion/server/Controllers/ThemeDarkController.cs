using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace axosimple.server.Controllers;

[Route("/[controller]")]
[ApiController]
public class ThemeDarkController : ControllerBase
{
    public async Task<ActionResult> ChangeTheme([FromQuery] string theme)
    {
        Response.Cookies.Append("themeDark", theme);
        return Redirect("/");
    }
}

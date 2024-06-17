using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace axosimple.server.Controllers;

[Route("/[controller]")]
[ApiController]
public class ThemeColorController : ControllerBase
{
    public async Task<ActionResult> ChangeThemeColor([FromQuery] string themeColor)
    {
        Response.Cookies.Append("ThemeColor", themeColor);
        return Redirect("/");
    }
}

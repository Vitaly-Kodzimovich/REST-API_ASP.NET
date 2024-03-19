using Microsoft.AspNetCore.Mvc;

namespace Vlog.Controllers;

public class ErrorsController : Controller
{
    [Route("/Error")]
    public IActionResult Error()
    {
        return Problem();
    }
}
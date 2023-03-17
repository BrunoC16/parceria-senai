
using Microsoft.AspNetCore.Mvc;

public class ParceriasController : Controller
{
    private readonly ILogger<ParceriasController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}

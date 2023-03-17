
using   Microsoft.AspNetCore.Mvc;

public class CiscoController:Controller
{
    private readonly ILogger<CiscoController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}
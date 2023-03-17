
using   Microsoft.AspNetCore.Mvc;

public class GoogleController:Controller
{
    private readonly ILogger<GoogleController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}
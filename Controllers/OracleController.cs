
using Microsoft.AspNetCore.Mvc;

public class OracleController:Controller
{
    private readonly ILogger<OracleController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}





using   Microsoft.AspNetCore.Mvc;

public class MicrosoftController:Controller
{
    private readonly ILogger<MicrosoftController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}
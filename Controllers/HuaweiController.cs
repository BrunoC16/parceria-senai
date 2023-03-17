
using   Microsoft.AspNetCore.Mvc;

public class HuaweiController:Controller
{
    private readonly ILogger<HuaweiController>? _logger;
    public IActionResult Index()
    {
        return View(); //página cshtml
    }
}
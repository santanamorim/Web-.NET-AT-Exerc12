using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class DadosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

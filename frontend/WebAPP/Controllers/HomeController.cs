using Flurl.Http;

using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using WebAPP.Models;

namespace WebAPP.Controllers;
public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public async Task<IActionResult> ListarPedido()
    {
        var lista = await "https://localhost:9000/listar-pedidos".GetJsonAsync<List<Pedido>>();
        return View(nameof(Index), lista);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

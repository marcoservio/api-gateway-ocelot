using Microsoft.AspNetCore.Mvc;

namespace PedidoAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController(ILogger<PedidoController> logger) : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Pao", "Farinha", "Ovo", "Bolo", "Queijo", "Carne", "Cenoura", "Agua", "Chocolate", "Pimenta"
    ];

    private readonly ILogger<PedidoController> _logger = logger;

    public IEnumerable<Pedido> Get()
    {
        _logger.LogInformation("Get Pedido");

        return Enumerable.Range(1, 5).Select(index => new Pedido
        {
            Id = Guid.NewGuid(),
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Nome = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

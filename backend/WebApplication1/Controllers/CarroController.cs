using WebApplication1.Model;

using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[Route("[controller]")]
[ApiController]
public class CarroController : ControllerBase
{
    private static readonly string[] Carros =
    [
        "Volkswagen Golf", "Ford Mustang", "Toyota Corolla", "Honda Civic", "Chevrolet Camaro", "BMW Serie 3",
        "Mercedes-Benz Classe C", "Tesla Model S", "Subaru Impreza", "Audi A4"
    ];

    [HttpGet]
    public IEnumerable<Carro> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Carro
        {
            Id = Guid.NewGuid(),
            Name = Carros[Random.Shared.Next(Carros.Length)],
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        })
        .ToArray();
    }
}

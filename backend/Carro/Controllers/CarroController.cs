using Microsoft.AspNetCore.Mvc;

namespace Carro.Controllers;

[Route("[controller]")]
[ApiController]
public class CarroController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Volkswagen Golf", "Ford Mustang", "Toyota Corolla", "Honda Civic",
        "Chevrolet Camaro", "BMW Serie 3", "Mercedes-Benz Classe C", "Tesla Model S", "Subaru Impreza",
        "Audi A4"
    };

    public IEnumerable<Model.Carro> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Model.Carro
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

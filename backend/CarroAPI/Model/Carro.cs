namespace CarroAPI.Model;

public class Carro
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateOnly Date { get; set; }
}

namespace PedidoAPI;

public class Pedido
{
    public DateOnly Date { get; set; }

    public Guid Id { get; set; }

    public string? Nome { get; set; }
}

namespace BlueProjectTest.Models;

public class Produto
{
    public int ProdutoId { get; set; } = 0;
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; } = decimal.Zero;
    public int Estoque { get; set; } = 0;
    public DateTime DataCadastro { get; set; }
}

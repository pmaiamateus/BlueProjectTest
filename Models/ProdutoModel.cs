namespace BlueProjectTest.Models;

public class Produto
{
    public int ProdutoId { get; set; } = 0;
    public string Nome { get; set { if (value.Length > 100) throw new ArgumentException("Tamanho máximo de 50 caracteres"); else Nome = value; } } = string.Empty;
    public string Descricao { get; set { if (value.Length > 255) throw new ArgumentException("Tamanho máximo de 255 caracteres"); else Descricao = value; } } = string.Empty;
    public decimal Preco { get; set { if (value < 0) throw new ArgumentException("Valor não pode ser menor que zero"); else Preco = value; } } = decimal.Zero;
    public int Estoque { get; set { if (value < 0) throw new ArgumentException("Valor não pode ser menor que zero"); else Estoque = value; } } = 0;
    public DateTime DataCadastro { get; set; }
}

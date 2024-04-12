namespace Teste.Modelos.Pagamento;

internal class Produto : IPagavel
{
    public Produto(string nome, double preco, int quantidadeDeProdutos)
    {
        Nome = nome;
        PrecoUnitario = preco;
        QuantidadeDeProdutos = quantidadeDeProdutos;
    }

    public string Nome { get; set; }
    public double PrecoUnitario { get; }
    public int QuantidadeDeProdutos { get; }
    public double CalcularPagamento()
    {
        return PrecoUnitario * QuantidadeDeProdutos;
    }
}

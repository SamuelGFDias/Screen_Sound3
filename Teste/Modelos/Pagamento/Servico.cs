namespace Teste.Modelos.Pagamento;

internal class Servico : IPagavel
{
    public Servico(int horas, double taxa)
    {
        HorasTrabalhadas = horas;
        TaxaHoraria = taxa;
    }

    public int HorasTrabalhadas { get; }
    public double TaxaHoraria { get; }
    public double CalcularPagamento()
    {
        return HorasTrabalhadas * TaxaHoraria;
    }
}

namespace Teste.Modelos.Geometria;

internal class Quadrado : IForma
{
    public double Lado{ get; set; }
    public double CalcularArea()
    {
        return Lado * Lado;
    }

    public double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}   

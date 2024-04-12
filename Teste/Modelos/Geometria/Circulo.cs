namespace Teste.Modelos.Geometria;

internal class Circulo : IForma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

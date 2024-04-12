namespace Teste.Modelos.Veiculo;

internal class Veiculo : IVoavel, IPilotavel
{
    public void Pilotar()
    {
        Console.WriteLine("Pilotando"); ;
    }

    public void Voar()
    {
        Console.WriteLine("Voando"); ;
    }
}

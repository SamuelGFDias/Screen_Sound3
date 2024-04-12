namespace Teste.Modelos.Empresa;

internal class Gerente : Funcionario
{
    public Gerente(string nome, double salario) : base(nome, salario, cargo:"Gerente")
    {
    }
    public List<Funcionario> Geridos { get; } = new();
}

namespace Teste.Modelos.Empresa;

internal abstract class Funcionario
{
    public Funcionario(string nome, double salario, string cargo)
    {
        Nome = nome;
        Salario = salario;
        Cargo = cargo;
    }

    public string Nome { get; }
    public double Salario { get; }
    public string Cargo { get; }
    public string Resumo =>
        $"O {Cargo} {Nome} recebe {Salario:C}";
}

namespace Teste.Modelos.Empresa;

internal class Analista : Funcionario
{
    public Analista(string nome, double salario, string formacao) : base(nome, salario, cargo: "Analista")
    {
        Formacao = formacao;
    }
    public string Formacao { get; }
}

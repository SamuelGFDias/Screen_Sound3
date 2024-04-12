namespace Teste.Modelos.Empresa;

internal class Programador : Funcionario
{
    public Programador(string nome, double salario, string linguagemFavorita) : base(nome, salario, cargo:"Programador")
    {
        LinguagemFavorita = linguagemFavorita;
    }
    public string LinguagemFavorita { get; }
}

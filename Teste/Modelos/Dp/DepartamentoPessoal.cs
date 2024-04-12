namespace Teste.Modelos.Dp;

internal class DepartamentoPessoal
{
    public static void ExibeFolha(List<Colaborador> colaboradores)
    {
        foreach (Colaborador c in colaboradores)
        {
            var salarioDoMes = (c.Salario * c.Anuenio) - c.Descontos;
            Console.WriteLine($"- {c.Nome}: {salarioDoMes:C}");
        }
    }
}

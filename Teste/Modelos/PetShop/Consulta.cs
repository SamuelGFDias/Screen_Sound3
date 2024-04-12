namespace PetShop.Modelos;

internal class Consulta
{
    public Consulta(string categoria, Pet pet, Dono dono, Medico veterinario)
    {
        Categoria = categoria;
        Pet = pet;
        Dono = dono;
        Veterinario = veterinario;
    }

    public string Categoria { get; }
    public Pet Pet { get;}
    public Dono Dono { get; }
    public Medico Veterinario { get; }  

    public void ExibirDetalhes()
    {
        Console.WriteLine("Detalhes da Consulta:");
        Console.WriteLine($"Veterinário: {Veterinario.Nome} - {Veterinario.Especializacao}");
        Console.WriteLine($"Dono: {Dono.Nome}");
        Console.WriteLine($"Pet: {Pet.Especie} - {Pet.Raca}");
    }
}

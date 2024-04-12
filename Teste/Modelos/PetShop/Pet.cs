namespace PetShop.Modelos;

internal class Pet
{
    public Pet(string especie, string raca)
    {
        Especie = especie;
        Raca = raca;
    }

    public string Especie { get; }
    public string Raca { get; }
}

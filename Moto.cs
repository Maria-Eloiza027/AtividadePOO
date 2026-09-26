namespace AtividadePOO;

public class Moto : Veiculo
{
    public Moto(string modelo, int ano) : base(modelo, ano)
    {
    }

    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} acelerou e cortou giro!");
    }
}
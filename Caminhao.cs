namespace AtividadePOO;

public class Caminhao : Veiculo
{
    public Caminhao(string modelo, int ano) : base(modelo, ano)
    {
    }

    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} acelerou rápido pelas ruas!");
    }
}
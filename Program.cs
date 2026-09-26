namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculo =
        [
            new Caminhao("Mercedes", 1970),

            new Moto("BMW", 2009),

            new Carro("Porsche", 1963)
        ];

        foreach (var veiculoAtual in veiculo)
        {
            veiculoAtual.Ligar();
            veiculoAtual.Acelerar();
        }
    }
}
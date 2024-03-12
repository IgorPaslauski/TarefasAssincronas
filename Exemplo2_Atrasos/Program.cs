namespace TarefasAssincronas.Exemplo1_Atrasoss;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Início do programa.");

        await Task.Delay(2000); // Aguarda 2 segundos

        Console.WriteLine("Continuação após a pausa.");
    }
}
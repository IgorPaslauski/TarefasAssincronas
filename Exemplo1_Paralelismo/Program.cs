namespace TarefasAssincronas.Exemplo1_Paralelismo;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Início do programa.");

        await Task.Run(() =>
        {
            // Código a ser executado em paralelo
            Console.WriteLine("Tarefa paralela em execução.");
        });

        Console.WriteLine("Continuação após a conclusão da tarefa paralela.");
    }
}
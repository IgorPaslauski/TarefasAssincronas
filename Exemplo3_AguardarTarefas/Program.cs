namespace TarefasAssincronas.Exemplo3_AguardarTarefas;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Início do programa.");

        List<Task> tasks = new List<Task>
        {
            Task.Run(() => Console.WriteLine("Tarefa 1")),
            Task.Run(() => Console.WriteLine("Tarefa 2"))
        };

        // Aguarda a conclusão de todas as tarefas
        await Task.WhenAll(tasks);

        Console.WriteLine("Continuação após a conclusão de todas as tarefas.");
    }
}
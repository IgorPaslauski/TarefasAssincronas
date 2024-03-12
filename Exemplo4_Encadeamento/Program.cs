namespace TarefasAssincronas.Exemplo4_Encadeamento;


class Program
{
    static async Task Main()
    {
        Console.WriteLine("Início do programa.");

        await Task.Run(() => Console.WriteLine("Tarefa 1"))
            .ContinueWith(tarefaAnterior => Console.WriteLine("Tarefa 2 a ser executada após Tarefa 1"));

        Console.WriteLine("Continuação após o encadeamento de tarefas.");
    }
}
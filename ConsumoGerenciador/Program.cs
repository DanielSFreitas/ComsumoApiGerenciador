using ConsumoGerenciador.Entities;
using ConsumoGerenciador.Services;

class Program 
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Informe o ID:");
        
        if (int.TryParse(Console.ReadLine(), out int Id))
        {
            TarefaServices tarefaServices = new TarefaServices();

            Tarefa tarefaencontrada = await tarefaServices.Integracao(Id);

            if (!tarefaencontrada.Verificacao)
            {
                Console.WriteLine("Tarefa Encontrada");
                Console.WriteLine($"Nome: {tarefaencontrada.Titulo}");
                Console.WriteLine($"Descrição: {tarefaencontrada.Descricao}");
                Console.WriteLine($"Status: {tarefaencontrada.Status}");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Certifique-se de inserir um número inteiro válido.");
        }
    }
}

using System.Net.Http;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;
using System.Text.Json.Serialization;
using ConsumoGerenciador.Entities;
using Newtonsoft.Json;


namespace ConsumoGerenciador.Services
{
    public class TarefaServices
    {
        private readonly HttpClient _httpClient;

        public TarefaServices()
        {
            _httpClient = new HttpClient();
        }

      public async Task<Tarefa> Integracao(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"http://localhost:5262/tarefa/{id}");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();

                // Usando Newtonsoft.Json para desserialização
                var jsonObject = JsonConvert.DeserializeObject<Tarefa>(jsonString);
                Console.WriteLine($"Id após desserialização: {jsonObject.Id}");

                if (jsonObject != null)
                {
                    
                    return jsonObject;
                }
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Erro na solicitação HTTP: {ex.Message}");
        }
        catch (System.Text.Json.JsonException ex)
        {
            Console.WriteLine($"Erro na desserialização JSON: {ex.Message}");
        }

        // Lidar com o caso em que a solicitação falha ou a desserialização é malsucedida
        return new Tarefa
        {
            Verificacao = true
        };
    }
}
}
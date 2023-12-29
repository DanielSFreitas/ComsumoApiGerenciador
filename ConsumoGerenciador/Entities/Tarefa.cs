using System.Text.Json.Serialization;

namespace ConsumoGerenciador.Entities
{
    public class Tarefa
    {
        
        [JsonPropertyName("id")]
        public int Id;

        [JsonPropertyName("titulo")]
        public string Titulo;

        [JsonPropertyName("descricao")]
        public string Descricao;

        [JsonPropertyName("data")]
        public DateTime Data;

        [JsonPropertyName("status")]
        public string Status;

        public bool Verificacao = false;
    
}
}
# Consumo da API Gerenciador de Tarefas
Este projeto demonstra como consumir a API Gerenciador de Tarefas, obtendo detalhes sobre tarefas com base em seus IDs. O projeto é escrito em C# e utiliza a biblioteca HttpClient para realizar solicitações HTTP.

# Estrutura do Projeto
O projeto é organizado em namespaces para melhor modularidade e clareza:

## ConsumoGerenciador.Entities
### EnumStatusTarefa**
Um enum que define os possíveis status de uma tarefa, como "Pendente" e "Finalizado".
### Tarefa
Uma classe que representa a entidade de tarefa.
Utiliza atributos JsonPropertyName para mapear propriedades para os campos correspondentes no JSON retornado pela API.
Inclui uma propriedade adicional Verificacao para indicar se a tarefa foi encontrada.
## ConsumoGerenciador.Services
### TarefaServices
Uma classe que encapsula a lógica de integração com a API Gerenciador de Tarefas.
Usa a biblioteca HttpClient para enviar solicitações HTTP.
Inclui um método Integracao que realiza uma solicitação GET para obter detalhes da tarefa com base em um ID fornecido.
Utiliza a biblioteca Newtonsoft.Json para desserialização, manipulando possíveis erros durante a solicitação e desserialização.
### Program
O arquivo principal que contém o método Main.
Solicita ao usuário que insira um ID de tarefa.
Instancia a classe TarefaServices para obter detalhes da tarefa.
Exibe os detalhes da tarefa se encontrada, senão exibe uma mensagem indicando que a tarefa não foi encontrada.
## Como Usar
Clone o repositório para o seu ambiente local.
Certifique-se de ter o ambiente de desenvolvimento C# configurado.
Execute o aplicativo e siga as instruções para inserir o ID da tarefa.
## Melhorias Implementadas
Tratamento de erros aprimorado durante a solicitação HTTP e desserialização JSON.
Uso do bloco using com HttpClient para garantir uma liberação adequada de recursos.
Melhorias na apresentação de mensagens no console para maior clareza.
Sinta-se à vontade para contribuir, reportar problemas ou sugerir melhorias para este projeto.

namespace ChatIARag.API.Models;

public class Conversation
{
    // Identificador único da conversa (UUID)
    public Guid Id { get; set; }

    // Identificador do usuário dono da conversa (UUID)
    public required Guid UserId { get; set; }

    // Referência ao usuário dono (propriedade de navegação)
    public User User { get; set; }

    // Chave da API para acessar o provedor de IA (OpenRouter/OpenAI)
    public string ApiKey { get; set; }

    // Nome do modelo de IA selecionado (ex: "gpt-4", "claude", "llama", etc)
    public string Model { get; set; }

    // Nome do provedor de IA (ex: "openai", "anthropic")
    public string Provider { get; set; }

    // Prompt de sistema usado para personalizar o comportamento da IA na conversa
    public string SystemPrompt { get; set; }

    // Temperatura (criatividade da resposta): baixa = conservador, alta = criativo
    public double Temperature { get; set; }

    // Número máximo de tokens (tamanho/limite da resposta da IA)
    public int MaxTokens { get; set; }

    // Data de criação da conversa (auditoria)
    public DateTime CreatedAt { get; set; }

    // Data da última atualização dessa conversa
    public DateTime UpdatedAt { get; set; }

    // Mensagens que pertencem a essa conversa (relacionamento 1:N)
    public ICollection<Message>? Messages { get; set; }

    // Documentos usados como contexto nesta conversa (para RAG)
    public ICollection<Document>? Documents { get; set; }
}

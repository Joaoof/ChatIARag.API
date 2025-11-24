namespace ChatIARag.API.Models;

public class Configuration
{
    public Guid Id { get; set; }
    public string ApiKey { get; set; }
    public string Model { get; set; }
    public string Provider { get; set; }
    public string SystemPrompt { get; set; }
    public double Temperature { get; set; }
    public int MaxTokens { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

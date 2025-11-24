namespace ChatIARag.API.DTOs;

public class UpdateConfigurationDto
{
    public string Model { get; set; }
    public string Provider { get; set; }
    public string SystemPrompt { get; set; }
    public double Temperature { get; set; }
    public int MaxTokens { get; set; }
}

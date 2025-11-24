namespace ChatIARag.API.DTOs;

public class DocumentResponseDto
{
    public Guid Id { get; set; }
    public string FileName { get; set; } = string.Empty;
    public string FileType { get; set; }
    public bool Status { get; set; }
    public int ChunkCount { get; set; }
}

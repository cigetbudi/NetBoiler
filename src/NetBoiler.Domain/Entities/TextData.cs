namespace NetBoiler.Domain.Entities;

public class TextData
{
    public Guid Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
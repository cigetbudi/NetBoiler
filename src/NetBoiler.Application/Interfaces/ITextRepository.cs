namespace NetBoiler.Application.Interfaces
{
  public interface ITextRepository
{
    Task SaveTextAsync(string text);
}
}
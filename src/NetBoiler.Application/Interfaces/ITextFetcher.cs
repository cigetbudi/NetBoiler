namespace NetBoiler.Application.Interfaces;
public interface ITextFetcher
{
    Task<string> FetchTextAsync();
}
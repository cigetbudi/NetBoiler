using MediatR;
using NetBoiler.Application.Interfaces;

namespace NetBoiler.Application.Commands.FetchAndSaveText;

public class FetchAndSaveTextHandler : IRequestHandler<FetchAndSaveTextCommand>
{
    private readonly ITextFetcher _fetcher;
    private readonly ITextRepository _repository;

    public FetchAndSaveTextHandler(ITextFetcher fetcher, ITextRepository repository)
    {
        _fetcher = fetcher;
        _repository = repository;
    }

    public async Task<Unit> Handle(FetchAndSaveTextCommand request, CancellationToken cancellationToken)
    {
        var text = await _fetcher.FetchTextAsync();
        await _repository.SaveTextAsync(text);
        return Unit.Value;
    }

}
using MediatR;

namespace NetBoiler.Application.Features.Commands;

public class FetchAndSaveTextCommandHandler : IRequestHandler<FetchAndSaveTextCommand, bool>
{
    private readonly TextFetcher _textFetcher;

    public FetchAndSaveTextCommandHandler(TextFetcher textFetcher)
    {
        _textFetcher = textFetcher;
    }
    public Task<bool> Handle(FetchAndSaveTextCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
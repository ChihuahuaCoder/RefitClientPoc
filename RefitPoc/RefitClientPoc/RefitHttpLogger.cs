using Microsoft.Extensions.Logging;

namespace RefitClientPoc;

public class RefitHttpLogger : DelegatingHandler
{
    private readonly ILogger _logger;

    public RefitHttpLogger(ILogger logger , HttpMessageHandler innerHandler = null) : base(innerHandler ?? new HttpClientHandler()) {
        this._logger = logger;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Request: {request}", request);
        
        var response = await base.SendAsync(request, cancellationToken);

        _logger.LogInformation("Response: {response}", response);

        return response;
    }
}

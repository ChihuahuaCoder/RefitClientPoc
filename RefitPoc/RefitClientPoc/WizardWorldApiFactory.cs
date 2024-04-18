using Microsoft.Extensions.Logging;
using Refit;

namespace RefitClientPoc;

public static class WizardWorldApiFactory {
    public static IWizardWorldApi Create() {
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        var logger = loggerFactory.CreateLogger<RefitHttpLogger>();
        return RestService.For<IWizardWorldApi>(new HttpClient(new RefitHttpLogger(logger)) {
            BaseAddress = new Uri("https://wizard-world-api.herokuapp.com")
        });
    }
}

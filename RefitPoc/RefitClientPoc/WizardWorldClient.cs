using Refit;
using RefitClientPoc.ElixirsData;

namespace RefitClientPoc;

public class WizardWorldClient {
    private readonly IWizardWorldApi _wizardWorldApi = RestService.For<IWizardWorldApi>("https://wizard-world-api.herokuapp.com");

    public async Task<Elixir> GetElixir(Guid id) {
        return await _wizardWorldApi.GetElixir(new Guid("2bc0184a-65ad-4899-90b7-3c6ce1e3156e"));
    }
}

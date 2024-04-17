using Refit;
using RefitClientPoc.ElixirsData;

namespace RefitClientPoc;

public class WizardWorldClient {
    private readonly IWizardWorldApi _wizardWorldApi = RestService.For<IWizardWorldApi>("https://wizard-world-api.herokuapp.com");

    public async Task<Elixir> GetElixir(Guid id) {
        return await _wizardWorldApi.GetElixir(id);
    }

    public async Task<ICollection<Elixir>> GetElixirs() {
        return await _wizardWorldApi.GetElixirs();
    }
}

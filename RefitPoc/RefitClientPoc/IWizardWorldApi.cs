using Refit;
using RefitClientPoc.Elixirs;
using RefitClientPoc.Feedback;

namespace RefitClientPoc;

public interface IWizardWorldApi {
    [Get("/Elixirs/{id}")]
    Task<Elixir> GetElixir(Guid id);

    [Get("/Elixirs")]
    Task<ICollection<Elixir>> GetElixirs(ElixirsQueryParams elixirsQueryParams);

    [Post("/Feedback")]
    Task PostFeedback(FeedbackRequest feedbackRequest);
}

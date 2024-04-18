using System.Text.Json.Serialization;

namespace RefitClientPoc.Feedback;

public class FeedbackRequest {
    [JsonPropertyName("feedbackType")]
    public FeedbackType? Type { get; set; }
    [JsonPropertyName("feedback")]
    public string? Message { get; set; }
    [JsonPropertyName("entityId")]
    public Guid? Id { get; set; }
}

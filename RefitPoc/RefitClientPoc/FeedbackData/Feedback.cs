using System.Text.Json.Serialization;

namespace RefitClientPoc.FeedbackData;

public record Feedback {
    [JsonPropertyName("feedbackType")]
    public FeedbackType Type { get; set; }
    [JsonPropertyName("feedback")]
    public string Message { get; set; }
    [JsonPropertyName("entityId")]
    public Guid Id { get; set; }
}

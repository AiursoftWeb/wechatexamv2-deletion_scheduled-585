using Aiursoft.WeChatExamV2.Entities;
using Newtonsoft.Json;

namespace Aiursoft.WeChatExamV2.Models.ContentSearchViewModels;

public class ContentSearchItem
{
    public Guid Id { get; set; }
    public bool IsKnowledgePoint { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Preview { get; set; } = string.Empty;
    public string Answer { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public QuestionType? QuestionType { get; set; }

    [JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public double Score { get; set; }
}

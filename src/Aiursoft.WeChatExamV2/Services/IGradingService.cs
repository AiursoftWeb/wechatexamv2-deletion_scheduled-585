using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Services;

public interface IGradingService
{
    Task<GradingResult> GradeAsync(Question question, string userAnswer);
    Task<GradingResult> GradeAsync(string userAnswer, string standardAnswer, GradingStrategy strategy, int maxScore, string content);
    Task<GradingResult> GradeAsync(string userAnswer, string standardAnswer, GradingStrategy strategy, int maxScore, string content, string explanation);
}

public class GradingResult
{
    public bool IsCorrect { get; set; }
    public int Score { get; set; }
    public string Comment { get; set; } = string.Empty;
}

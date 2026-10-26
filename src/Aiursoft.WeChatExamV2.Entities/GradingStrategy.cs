using System.ComponentModel.DataAnnotations;

namespace Aiursoft.WeChatExamV2.Entities;

public enum GradingStrategy
{
    [Display(Name = "精确匹配")]
    ExactMatch,
    [Display(Name = "模糊匹配")]
    FuzzyMatch,
    [Display(Name = "AI判题")]
    AiEval
}

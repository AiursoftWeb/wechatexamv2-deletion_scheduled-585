using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aiursoft.WeChatExamV2.Models.PracticeViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Practice Test";
    }

    public string? Mtql { get; set; }
    public QuestionType? QuestionType { get; set; }
    public IEnumerable<SelectListItem> QuestionTypeOptions { get; set; } = new List<SelectListItem>();
    public List<Question> Questions { get; set; } = new();
}

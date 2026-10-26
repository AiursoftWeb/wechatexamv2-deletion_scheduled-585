using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.PracticeViewModels;

public class PracticeViewModel : UiStackLayoutViewModel
{
    public PracticeViewModel()
    {
        PageTitle = "Practice Session";
    }

    public List<Question> Questions { get; set; } = new();
}

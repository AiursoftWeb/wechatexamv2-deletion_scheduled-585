using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.ExamsViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Exam Details";
    }

    public Exam? Exam { get; set; }
    public List<ExamRecord> Records { get; set; } = new();
}

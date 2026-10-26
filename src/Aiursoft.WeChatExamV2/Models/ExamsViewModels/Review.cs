using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.ExamsViewModels;

public class ReviewViewModel : UiStackLayoutViewModel
{
    public ReviewViewModel()
    {
        PageTitle = "Review Exam Record";
    }

    public ExamRecord? Record { get; set; }
    public List<QuestionSnapshot> Questions { get; set; } = new();
    
    // For manual grading
    public int NewTotalScore { get; set; }
    public string TeacherComment { get; set; } = string.Empty;
}

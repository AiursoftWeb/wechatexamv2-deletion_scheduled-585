using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.FeedbacksViewModels;

public class IndexViewModel: UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Feedback";
    }
    public List<Feedback> Feedbacks { get; set; } = new();
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public FeedbackStatus? StatusFilter { get; set; }
    public FeedbackType? TypeFilter { get; set; }
}

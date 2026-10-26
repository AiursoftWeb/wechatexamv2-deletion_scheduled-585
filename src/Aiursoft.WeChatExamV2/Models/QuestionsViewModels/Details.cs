using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.QuestionsViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Question Details";
    }

    public Question? Question { get; set; }

    public Category? Category { get; set; }

    public string? ReturnUrl { get; set; }
}

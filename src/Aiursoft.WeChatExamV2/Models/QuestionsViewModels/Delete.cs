using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.QuestionsViewModels;

public class DeleteViewModel : UiStackLayoutViewModel
{
    public DeleteViewModel()
    {
        PageTitle = "Delete Question";
    }

    public required Question Question { get; set; }

    public Category? Category { get; set; }

    public string? ReturnUrl { get; set; }
}

using Aiursoft.UiStack.Layout;

namespace Aiursoft.WeChatExamV2.Models.ErrorViewModels;

public class UnauthorizedViewModel: UiStackLayoutViewModel
{
    public UnauthorizedViewModel()
    {
        PageTitle = "Unauthorized";
    }

    public required string ReturnUrl { get; init; }
}

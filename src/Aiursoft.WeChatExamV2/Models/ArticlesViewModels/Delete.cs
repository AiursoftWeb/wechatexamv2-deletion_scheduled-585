using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.ArticlesViewModels;

public class DeleteViewModel : UiStackLayoutViewModel
{
    public DeleteViewModel()
    {
        PageTitle = "Delete Article";
    }

    public required Article Article { get; set; }
}

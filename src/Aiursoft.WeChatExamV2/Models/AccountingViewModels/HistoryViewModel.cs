using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.AccountingViewModels;

public class HistoryViewModel : UiStackLayoutViewModel
{
    public HistoryViewModel()
    {
        PageTitle = "VIP Change History";
    }

    public List<Change> Changes { get; set; } = [];
}

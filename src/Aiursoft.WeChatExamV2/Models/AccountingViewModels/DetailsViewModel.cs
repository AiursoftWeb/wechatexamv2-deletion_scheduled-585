using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Services;

namespace Aiursoft.WeChatExamV2.Models.AccountingViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel(DateTime month)
    {
        PageTitle = $"Finance Report - {month:yyyy-MM}";
    }

    public required MonthlyActiveUserReport Report { get; set; }
}

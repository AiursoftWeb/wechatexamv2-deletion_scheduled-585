using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.PaymentOrdersViewModels;

public class IndexViewModel: UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Payment Orders";
    }

    public List<PaymentOrder> Orders { get; set; } = [];
    public PaymentOrderStatus? StatusFilter { get; set; }
    public string? UserIdFilter { get; set; }
    public int TotalCount { get; set; }
    public int CurrentPage { get; set; } = 1;
    public int PageSize { get; set; } = 50;
}

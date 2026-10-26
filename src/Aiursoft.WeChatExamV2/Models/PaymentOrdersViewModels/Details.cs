using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.PaymentOrdersViewModels;

public class DetailsViewModel: UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Payment Order Details";
    }

    public required PaymentOrder Order { get; set; }
}

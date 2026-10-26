using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.PaymentOrdersViewModels;

public class UserPaymentsViewModel: UiStackLayoutViewModel
{
    public UserPaymentsViewModel()
    {
        PageTitle = "User Payments";
    }

    public required string UserId { get; set; }
    public string? UserDisplayName { get; set; }
    public List<PaymentOrder> Orders { get; set; } = [];
    public List<VipMembership> VipMemberships { get; set; } = [];
}

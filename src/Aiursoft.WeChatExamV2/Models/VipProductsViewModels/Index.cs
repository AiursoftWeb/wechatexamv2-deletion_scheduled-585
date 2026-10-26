using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.VipProductsViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "VIP Products";
    }

    public List<VipProduct> Products { get; set; } = [];
    public string? SearchQuery { get; set; }
}

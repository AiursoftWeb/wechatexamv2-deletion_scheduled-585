using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;
using Aiursoft.WeChatExamV2.Services;

namespace Aiursoft.WeChatExamV2.Models.DistributionChannelsViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Channel Details";
    }

    public required DistributionChannel Channel { get; set; }
    public required ChannelStats Stats { get; set; }
}

using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;
using Aiursoft.WeChatExamV2.Services;

namespace Aiursoft.WeChatExamV2.Models.DistributionChannelsViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Distribution Channels";
    }

    public List<DistributionChannel> Channels { get; set; } = [];
    public Dictionary<Guid, ChannelStats> ChannelStats { get; set; } = [];
    public string? SearchQuery { get; set; }
}

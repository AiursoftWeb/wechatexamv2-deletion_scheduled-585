using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.DistributionChannelsViewModels;

public class DeleteViewModel : UiStackLayoutViewModel
{
    public DeleteViewModel()
    {
        PageTitle = "Delete Distribution Channel";
    }

    public required DistributionChannel Channel { get; set; }
    public int RegistrationCount { get; set; }
}

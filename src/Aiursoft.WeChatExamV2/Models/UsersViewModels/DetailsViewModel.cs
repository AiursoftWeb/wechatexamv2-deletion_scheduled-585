using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Authorization;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.AspNetCore.Identity;

namespace Aiursoft.WeChatExamV2.Models.UsersViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "User Details";
    }

    public required User User { get; set; }

    public required IList<IdentityRole> Roles { get; set; }

    public required List<PermissionDescriptor> Permissions { get; set; }
}

using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Authorization;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.AspNetCore.Identity;

namespace Aiursoft.WeChatExamV2.Models.RolesViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Role Details";
    }

    public required IdentityRole Role { get; set; }

    public required List<PermissionDescriptor> Permissions { get; set; }

    public required IList<User> UsersInRole { get; set; }
}

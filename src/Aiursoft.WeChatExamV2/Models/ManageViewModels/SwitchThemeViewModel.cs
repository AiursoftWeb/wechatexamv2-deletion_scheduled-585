using System.ComponentModel.DataAnnotations;

namespace Aiursoft.WeChatExamV2.Models.ManageViewModels;

public class SwitchThemeViewModel
{
    [Required]
    public required string Theme { get; set; }
}

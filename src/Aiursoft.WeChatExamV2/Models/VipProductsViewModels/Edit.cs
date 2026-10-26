using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Aiursoft.WeChatExamV2.Models.VipProductsViewModels;

public class EditViewModel : UiStackLayoutViewModel
{
    public EditViewModel()
    {
        PageTitle = "Edit VIP Product";
    }

    public Guid Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public VipProductType Type { get; set; }
    public Guid? CategoryId { get; set; }

    [Range(1, int.MaxValue)]
    public int PriceInFen { get; set; }

    [Range(1, int.MaxValue)]
    public int DurationDays { get; set; }
    public bool IsEnabled { get; set; }
    public List<SelectListItem> Categories { get; set; } = [];
}

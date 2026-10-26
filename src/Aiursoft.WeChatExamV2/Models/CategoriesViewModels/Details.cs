using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.CategoriesViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "Category Details";
    }

    public required Category Category { get; set; }

    public List<KnowledgePoint> AssociatedKnowledgePoints { get; set; } = new();
}

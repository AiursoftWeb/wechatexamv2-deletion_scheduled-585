using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.KnowledgePointsViewModels;

public class DetailsViewModel : UiStackLayoutViewModel
{
    public DetailsViewModel()
    {
        PageTitle = "KnowledgePoint Details";
    }

    public string? ReturnUrl { get; set; }

    public required KnowledgePoint KnowledgePoint { get; set; }

    public List<Category> AssociatedCategories { get; set; } = new();

    public List<Question> AssociatedQuestions { get; set; } = new();
}

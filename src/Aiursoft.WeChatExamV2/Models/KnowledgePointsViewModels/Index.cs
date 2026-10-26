using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.KnowledgePointsViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "KnowledgePoints";
    }

    public List<KnowledgePoint> KnowledgePoints { get; set; } = new();

    public List<KnowledgePoint> RootKnowledgePoints { get; set; } = new();
}

using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.TaxonomiesViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Taxonomies Management";
    }
    public List<Taxonomy> Taxonomies { get; set; } = new();
    public Dictionary<int, int> TagCounts { get; set; } = new();
}

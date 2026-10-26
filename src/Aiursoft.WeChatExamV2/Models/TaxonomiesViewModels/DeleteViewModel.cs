using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.TaxonomiesViewModels;

public class DeleteViewModel : UiStackLayoutViewModel
{
    public DeleteViewModel()
    {
        PageTitle = "Delete Taxonomy";
    }

    public Taxonomy Taxonomy { get; set; } = null!;
    public int TagCount { get; set; }
}

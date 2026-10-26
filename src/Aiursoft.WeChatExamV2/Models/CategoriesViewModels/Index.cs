using Aiursoft.UiStack.Layout;
using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Models.CategoriesViewModels;

public class IndexViewModel : UiStackLayoutViewModel
{
    public IndexViewModel()
    {
        PageTitle = "Categories";
    }

    public List<Category> Categories { get; set; } = new();

    public List<Category> RootCategories { get; set; } = new();
}

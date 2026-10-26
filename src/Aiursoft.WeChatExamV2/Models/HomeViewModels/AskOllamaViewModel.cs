using Aiursoft.UiStack.Layout;

namespace Aiursoft.WeChatExamV2.Models.HomeViewModels;

public class AskOllamaViewModel : UiStackLayoutViewModel
{
    public AskOllamaViewModel()
    {
        PageTitle = "Ask Ollama";
    }

    public string? Question { get; set; }
    public string? Answer { get; set; }
}

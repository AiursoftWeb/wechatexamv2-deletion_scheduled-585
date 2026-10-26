using System.Diagnostics;
using Aiursoft.WeChatExamV2.Models.ErrorViewModels;
using Aiursoft.WeChatExamV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.WeChatExamV2.Controllers.Management;

/// <summary>
/// This controller is used to show error pages.
/// </summary>
public class ErrorController : Controller
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return this.StackView(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [Route("Error/Unauthorized")]
    [HttpGet]
    public IActionResult UnauthorizedPage([FromQuery] string returnUrl = "/")
    {
        if (!Url.IsLocalUrl(returnUrl))
        {
            returnUrl = "/";
        }

        return this.StackView(new UnauthorizedViewModel
        {
            ReturnUrl = returnUrl
        }, viewName: "Unauthorized");
    }
}

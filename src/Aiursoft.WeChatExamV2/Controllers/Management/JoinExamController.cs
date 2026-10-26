using Aiursoft.WebTools.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Aiursoft.WeChatExamV2.Controllers.Management;

[Authorize]
[LimitPerMin]
public class JoinExamController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Index", "TestPapers");
    }
}

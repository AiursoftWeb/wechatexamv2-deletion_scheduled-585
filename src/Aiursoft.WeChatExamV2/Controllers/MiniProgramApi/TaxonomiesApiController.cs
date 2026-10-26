using Aiursoft.WeChatExamV2.Models.MiniProgramApi;
using Aiursoft.WeChatExamV2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

using Aiursoft.WeChatExamV2.Services.Authentication;

namespace Aiursoft.WeChatExamV2.Controllers.MiniProgramApi;

[Route("api/miniprogramapi/taxonomies")]
[ApiController]
[WeChatUserOnly]
public class TaxonomiesApiController(
    ITaxonomyService taxonomyService,
    ITagService tagService,
    IPaperAccessService paperAccessService) : ControllerBase
{
    [AllowAnonymous]
    [HttpGet]
    [Produces(typeof(List<TaxonomyDto>))]
    public async Task<IActionResult> Index([FromQuery] Guid? categoryId)
    {
        var taxonomies = await taxonomyService.GetAllTaxonomiesAsync(categoryId, includeCategory: true);
        var dtos = taxonomies.Select(t => new TaxonomyDto
        {
            Id = t.Id,
            Name = t.Name
        });
        return Ok(dtos);
    }

    [AllowAnonymous]
    [HttpGet("{id}/tags")]
    [Produces(typeof(List<TagDto>))]
    public async Task<IActionResult> GetTags(int id)
    {
        var tags = await tagService.GetTagsByTaxonomyIdAsync(id);
        
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var accessStatus = await paperAccessService.GetUserAccessStatusAsync(userId);

        var dtos = tags.Select(t =>
        {
            return new TagDto
            {
                Id = t.Id,
                DisplayName = t.DisplayName,
                NormalizedName = t.NormalizedName,
                IsFree = t.IsFree,
                HasAccess = QuestionAccess.CanUseTag(t, accessStatus)
            };
        }).ToList();
        
        return Ok(dtos);
    }
}

using Aiursoft.UiStack.Navigation;
using Aiursoft.WebTools.Attributes;
using Aiursoft.WeChatExamV2.Authorization;
using Aiursoft.WeChatExamV2.Entities;
using Aiursoft.WeChatExamV2.Models.ContentSearchViewModels;
using Aiursoft.WeChatExamV2.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.WeChatExamV2.Controllers.Management;

[Authorize(Policy = AppPermissionNames.CanReadQuestions)]
[LimitPerMin]
public class ContentSearchController(WeChatExamV2DbContext db, ContentVectorSearchService search) : Controller
{
    [RenderInNavBar(NavGroupName = "Administration", NavGroupOrder = 9999,
        CascadedLinksGroupName = "Content Management", CascadedLinksIcon = "folder-tree",
        CascadedLinksOrder = 1, LinkText = "Search Content", LinkOrder = 0)]
    public async Task<IActionResult> Index(string? query, string kind = "all", Guid? categoryId = null)
    {
        var model = new IndexViewModel
        {
            Query = query?.Trim() ?? string.Empty, Kind = kind, CategoryId = categoryId,
            Categories = await db.Categories.AsNoTracking().OrderBy(c => c.Title).ToListAsync(HttpContext.RequestAborted)
        };
        if (model.Query.Length > 500 || kind is not ("all" or "questions" or "knowledge")) return BadRequest();
        (model.Results, model.UsedAi) = await search.SearchAsync(model.Query, kind, categoryId,
            cancellationToken: HttpContext.RequestAborted);
        return this.StackView(model);
    }

    public async Task<IActionResult> Questions(string? query, QuestionType? questionType, Guid? categoryId,
        bool useAi = true, bool includeSearchStatus = false)
    {
        if (query?.Length > 500) return BadRequest();
        var (results, usedAi) = await search.SearchAsync(query?.Trim() ?? string.Empty, "questions", categoryId,
            questionType, useAi, cancellationToken: HttpContext.RequestAborted);
        return includeSearchStatus ? Json(new { results, usedAi }) : Json(results);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = AppPermissionNames.CanEditAnyKnowledgePoint)]
    public async Task<IActionResult> SimilarKnowledgePointDrafts([FromBody] RecommendationRequest request)
    {
        if (!ModelState.IsValid || request.Id != Guid.Empty || string.IsNullOrWhiteSpace(request.Text)) return BadRequest();
        var (available, results) = await search.SimilarKnowledgePointsAsync(request, HttpContext.RequestAborted);
        return Json(new { available, results });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = AppPermissionNames.CanEditAnyKnowledgePoint)]
    public async Task<IActionResult> SimilarKnowledgePoints([FromBody] RecommendationRequest request)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (!await db.KnowledgePoints.AnyAsync(k => k.Id == request.Id, HttpContext.RequestAborted)) return NotFound();
        var (available, results) = await search.SimilarKnowledgePointsAsync(request, HttpContext.RequestAborted);
        return Json(new { available, results });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = AppPermissionNames.CanEditAnyKnowledgePoint)]
    public async Task<IActionResult> RecommendedQuestions([FromBody] RecommendationRequest request)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (!await db.KnowledgePoints.AnyAsync(k => k.Id == request.Id, HttpContext.RequestAborted)) return NotFound();
        var (available, results) = await search.RecommendAsync(request, true, HttpContext.RequestAborted);
        return Json(new { available, results });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = AppPermissionNames.CanAddQuestions)]
    public async Task<IActionResult> SimilarQuestionDrafts([FromBody] RecommendationRequest request)
    {
        if (!ModelState.IsValid || request.Id != Guid.Empty || string.IsNullOrWhiteSpace(request.Text)) return BadRequest();
        var (available, results) = await search.RecommendAsync(request, false, HttpContext.RequestAborted);
        return Json(new { available, results });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = AppPermissionNames.CanEditQuestions)]
    public async Task<IActionResult> SimilarQuestions([FromBody] RecommendationRequest request)
    {
        if (!ModelState.IsValid) return BadRequest();
        if (!await db.Questions.AnyAsync(q => q.Id == request.Id, HttpContext.RequestAborted)) return NotFound();
        var (available, results) = await search.RecommendAsync(request, false, HttpContext.RequestAborted);
        return Json(new { available, results });
    }
}

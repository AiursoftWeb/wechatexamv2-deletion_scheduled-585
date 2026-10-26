using Aiursoft.WeChatExamV2.Entities;

namespace Aiursoft.WeChatExamV2.Services;

public interface ITaxonomyService
{
    Task<Taxonomy> AddTaxonomyAsync(string name, Guid[]? categoryIds = null);
    Task<List<Taxonomy>> GetAllTaxonomiesAsync(Guid? categoryId = null, bool includeCategory = false);
    Task<Taxonomy?> GetTaxonomyByIdAsync(int id);
    Task DeleteTaxonomyAsync(int id);
    Task UpdateTaxonomyAsync(Taxonomy taxonomy, Guid[]? categoryIds = null);
}

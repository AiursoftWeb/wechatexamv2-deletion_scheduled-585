using Aiursoft.DbTools;
using Aiursoft.DbTools.InMemory;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Aiursoft.WeChatExamV2.InMemory;

public class InMemorySupportedDb : SupportedDatabaseType<WeChatExamV2DbContext>
{
    public override string DbType => "InMemory";

    public override IServiceCollection RegisterFunction(IServiceCollection services, string connectionString)
    {
        return services.AddAiurInMemoryDb<InMemoryContext>();
    }

    public override WeChatExamV2DbContext ContextResolver(IServiceProvider serviceProvider)
    {
        return serviceProvider.GetRequiredService<InMemoryContext>();
    }
}

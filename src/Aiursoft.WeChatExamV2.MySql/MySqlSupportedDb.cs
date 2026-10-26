using Aiursoft.DbTools;
using Aiursoft.DbTools.MySql;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Aiursoft.WeChatExamV2.MySql;

public class MySqlSupportedDb(bool allowCache, bool splitQuery) : SupportedDatabaseType<WeChatExamV2DbContext>
{
    public override string DbType => "MySql";

    public override IServiceCollection RegisterFunction(IServiceCollection services, string connectionString)
    {
        return services.AddAiurMySqlWithCache<MySqlContext>(
                connectionString, 
            splitQuery: splitQuery,
            allowCache: allowCache);
    }

    public override WeChatExamV2DbContext ContextResolver(IServiceProvider serviceProvider)
    {
        return serviceProvider.GetRequiredService<MySqlContext>();
    }
}

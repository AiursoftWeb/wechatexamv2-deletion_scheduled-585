using Aiursoft.DbTools;
using Aiursoft.DbTools.Sqlite;
using Aiursoft.WeChatExamV2.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Aiursoft.WeChatExamV2.Sqlite;

public class SqliteSupportedDb(bool allowCache, bool splitQuery) : SupportedDatabaseType<WeChatExamV2DbContext>
{
    public override string DbType => "Sqlite";

    public override IServiceCollection RegisterFunction(IServiceCollection services, string connectionString)
    {
        return services.AddAiurSqliteWithCache<SqliteContext>(
            connectionString,
            splitQuery: splitQuery,
            allowCache: allowCache);
    }

    public override WeChatExamV2DbContext ContextResolver(IServiceProvider serviceProvider)
    {
        return serviceProvider.GetRequiredService<SqliteContext>();
    }
}

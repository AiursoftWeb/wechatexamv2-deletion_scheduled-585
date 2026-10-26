using Aiursoft.WeChatExamV2.Entities;
using Microsoft.EntityFrameworkCore;


namespace Aiursoft.WeChatExamV2.Sqlite;

public class SqliteContext(DbContextOptions<SqliteContext> options) : WeChatExamV2DbContext(options)
{
    public override Task<bool> CanConnectAsync()
    {
        return Task.FromResult(true);
    }
}

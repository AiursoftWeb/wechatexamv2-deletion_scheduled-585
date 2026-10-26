using Aiursoft.WeChatExamV2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.WeChatExamV2.InMemory;

public class InMemoryContext(DbContextOptions<InMemoryContext> options) : WeChatExamV2DbContext(options)
{
    public override Task MigrateAsync(CancellationToken cancellationToken)
    {
        return Database.EnsureCreatedAsync(cancellationToken);
    }

    public override Task<bool> CanConnectAsync()
    {
        return Task.FromResult(true);
    }
}

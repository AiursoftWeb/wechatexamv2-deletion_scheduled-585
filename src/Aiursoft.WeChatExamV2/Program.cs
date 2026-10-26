using Aiursoft.DbTools;
using Aiursoft.ClickhouseLoggerProvider;
using Aiursoft.WeChatExamV2.Entities;
using static Aiursoft.WebTools.Extends;

namespace Aiursoft.WeChatExamV2;

public class Program
{
    public static async Task Main(string[] args)
    {
        var app = await AppAsync<Startup>(args);
        await app.Services.InitLoggingTableAsync();
        await app.UpdateDbAsync<WeChatExamV2DbContext>();
        await app.SeedAsync();
        await app.CopyAvatarFileAsync();
        await app.RunAsync();
    }
}

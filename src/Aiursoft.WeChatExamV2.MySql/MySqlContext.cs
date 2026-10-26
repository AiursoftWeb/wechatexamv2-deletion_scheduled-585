using Aiursoft.WeChatExamV2.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aiursoft.WeChatExamV2.MySql;

public class MySqlContext(DbContextOptions<MySqlContext> options) : WeChatExamV2DbContext(options);

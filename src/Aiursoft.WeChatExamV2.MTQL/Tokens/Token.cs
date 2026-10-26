namespace Aiursoft.WeChatExamV2.MTQL.Tokens;

public enum TokenType
{
    Tag,
    And,
    Or,
    Not,
    LParen,
    RParen
}

public record Token(TokenType Type, string Value);

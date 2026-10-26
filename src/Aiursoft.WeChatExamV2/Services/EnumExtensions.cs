using System.ComponentModel.DataAnnotations;

namespace Aiursoft.WeChatExamV2.Services;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var type = value.GetType();
        var name = Enum.GetName(type, value);
        if (name != null)
        {
            var field = type.GetField(name);
            if (field != null)
            {
                if (Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) is DisplayAttribute attr)
                {
                    return attr.Name ?? value.ToString();
                }
            }
        }
        return value.ToString();
    }
}
